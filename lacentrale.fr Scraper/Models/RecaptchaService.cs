using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thatsthem_scraper.Models;

namespace lacentrale.fr_Scraper.Models
{
    public class RecaptchaService
    {
        public HttpCaller _caller = new HttpCaller();
        public async Task<string> GetRecaptchaId(string siteKey,string pageurl)
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
    }
}
