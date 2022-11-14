using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using thatsthem_scraper.Models;

namespace lacentrale.fr_Scraper.Models
{
    public class RecaptchaService
    {
        public ChromeDriver _driver;
        public HttpCaller _caller = new HttpCaller();
        public async Task ResolveV2Captcha(string pageurl,IWebElement elmt)
        {
            do
            {
                _driver.ExecuteScript("arguments[0].setAttribute('style','')", elmt);
                var recaptchaResponse = await GetRecaptchaId("6LcSzk8bAAAAAOTkPCjprgWDMPzo_kgGC3E5Vn-T", pageurl);
                elmt.SendKeys(recaptchaResponse);
                await Task.Delay(5000);
                _driver.ExecuteScript("captchaCallback();");
                await Task.Delay(5000);
                if (_driver.PageSource.Contains("de que nos estamos a dirigir a si, e não a um robot"))
                {
                    await Task.Delay(1000);
                    _driver.Quit();
                    continue;
                }
                do
                {
                    var x = _driver.FindElement(By.Id("recherche-react-home"));
                    break;

                } while (true); 
            } while (true);
        }
        public async Task<string> GetRecaptchaId(string siteKey, string pageurl)
        {
            var url = $"http://2captcha.com/in.php?key=6032005e1a3e0d53dac9999ffe7eb083&method=userrecaptcha&googlekey={siteKey}&pageurl={pageurl}&json=1";
            var objt = new JObject();
            var tries = 1;
            var id = "";
            var recpatchaResponse = "";
            do
            {
                try
                {
                    var _json = await _caller.GetHtml(url);
                    if (_json.Contains("502 Bad Gateway"))
                    {
                        Reporter.Error($"Service respond:\"502 Bad Gateway\" (GetSession func \"while getting Id of the captcha\") " + " ==> retried request(s): " + tries);
                        await Task.Delay(2000);
                        tries++;
                        continue;
                    }
                    if (_json.Contains("Service Unavailable"))
                    {
                        Reporter.Error("Service Unavailable (GetIdRecaptcha func)");
                        await Task.Delay(5000);
                        return "Service Unavailable";
                    }
                    objt = JObject.Parse(_json);
                    id = (string)objt.SelectToken("..request");
                    break;
                }
                catch (Exception)
                {
                    await Task.Delay(1000);
                    continue;
                }
            } while (true);
            try
            {
                recpatchaResponse = await GetRecpatchaResponse(id);
            }
            catch (Exception)
            {

                await GetRecaptchaId(siteKey, pageurl);
            }
            return recpatchaResponse;
        }
        private async Task<string> GetRecpatchaResponse(string id)
        {
            var url = $"http://2captcha.com/res.php?action=get&key=6032005e1a3e0d53dac9999ffe7eb083&id={id}&json=1";
            var objt = new JObject();
            var recpatchaResponse = "";
            var tries = 1;
            do
            {
                var _json = await _caller.GetHtml(url);
                if (_json.Contains("502 Bad Gateway"))
                {
                    Reporter.Error("Service respond:\"502 Bad Gateway\" (GetSession func \"while getting the recaptcah reponse\")" + " ==> retried request(s): " + tries);
                    await Task.Delay(2000);
                    tries++;
                    continue;
                }
                if (_json.Contains("Service Unavailable"))
                {
                    Reporter.Error("Service Unavailable (GetRecpatchaResponse func)");
                    await Task.Delay(5000);
                    return "Service Unavailable";
                }
                try
                {
                    objt = JObject.Parse(_json);
                    recpatchaResponse = (string)objt.SelectToken("..request");
                    //503 Service Unavailable
                    if (recpatchaResponse == "CAPCHA_NOT_READY")
                    {
                        await Task.Delay(5000);
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Reporter.Error($"unexpected Error: {ex.ToString()} \r\n unexpected response from 2captcha service: {_json}");
                    return "Service Unavailable";
                }
                return recpatchaResponse;
            } while (true);
        }
       
        public async Task<string> ResolveAudioCaptcha(string audioUrl)
        {
            WebClient client = new WebClient();
            client.Headers.Add("Host", "dd.prod.captcha-delivery.com");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
            client.DownloadFile(audioUrl, "audio.wav");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            Grammar gr = new DictationGrammar();
            sre.LoadGrammar(gr);
            sre.SetInputToWaveFile("audio.wav");
            sre.BabbleTimeout = new TimeSpan(int.MaxValue);
            sre.InitialSilenceTimeout = new TimeSpan(int.MaxValue);
            sre.EndSilenceTimeout = new TimeSpan(100000000);
            sre.EndSilenceTimeoutAmbiguous = new TimeSpan(100000000);

            StringBuilder sb = new StringBuilder();
            while (true)
            {
                try
                {
                    var recText = sre.Recognize();
                    if (recText == null)
                    {
                        break;
                    }

                    sb.Append(recText.Text);
                }
                catch (Exception)
                {
                    break;
                }
            }
            var audioText = sb.ToString();
            var numbers = audioText.Substring(audioText.LastIndexOf(' ') + 1);
            var cookieBiulde = new StringBuilder();


            var inputs = _driver.FindElements(By.XPath("//div[@class='audio-captcha-input-container']/input"));
            for (int i = 0; i < inputs.Count; i++)
            {
                inputs[i].SendKeys(numbers[i].ToString());
            }
            await Task.Delay(3000);
            foreach (var cookie in _driver.Manage().Cookies.AllCookies)
            {
                cookieBiulde.Append(cookie.Name + "=" + cookie.Value + ";");
                await Task.Delay(1000);
            }
            _driver.Quit();
            cookieBiulde.Length--;
            var cookies = cookieBiulde.ToString();
            return cookies;
        }
       
    }
}
