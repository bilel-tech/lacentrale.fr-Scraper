﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace lacentrale.fr_Scraper.Models
{
    public class Httpcaller2
    {
        HttpClient _httpClient;
        HttpClientHandler _httpClientHandler = new HttpClientHandler()
        {
            //CookieContainer = new CookieContainer(),
            UseCookies = false,
            //Proxy = wproxy,
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        };
        public Httpcaller2()
        {
            _httpClient = new HttpClient(_httpClientHandler);
            _httpClient.DefaultRequestHeaders.Add("User-Agent", " Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36 Edg/106.0.1370.37");
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9");
        }
        public async Task<HtmlDocument> GetDoc(string url, int maxAttempts = 1)
        {
            var html = await GetHtml(url, maxAttempts);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            return doc;
        }
        public async Task<string> GetHtml(string url, int maxAttempts = 3)
        {

            do
            {
                try
                {
                    var response = await _httpClient.GetAsync(url);
                    string html = await response.Content.ReadAsStringAsync();
                    return html;
                }
                catch (WebException ex)
                {
                    await Task.Delay(2000);
                }
                catch (Exception ex)
                {
                    await Task.Delay(2000);
                }
            } while (true);
        }
        public async Task<string> PostJson(string url, string json, int maxAttempts = 1)
        {
            int tries = 0;
            do
            {
                try
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    // content.Headers.Add("x-appeagle-authentication", Token);
                    var r = await _httpClient.PostAsync(url, content);
                    var s = await r.Content.ReadAsStringAsync();
                    return (s);
                }
                catch (WebException ex)
                {
                    var errorMessage = "";
                    try
                    {
                        errorMessage = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                    }
                    catch (Exception)
                    {
                    }
                    tries++;
                    if (tries == maxAttempts)
                    {
                        throw new Exception(ex.Status + " " + ex.Message + " " + errorMessage);
                    }
                    await Task.Delay(2000);
                }
            } while (true);

        }
        public async Task<string> PostFormData(string url, List<KeyValuePair<string, string>> formData, int maxAttempts = 1)
        {
            var formContent = new FormUrlEncodedContent(formData);
            int tries = 0;
            do
            {
                try
                {
                    var response = await _httpClient.PostAsync(url, formContent);
                    string html = await response.Content.ReadAsStringAsync();
                    return html;
                }
                catch (WebException ex)
                {
                    var errorMessage = "";
                    try
                    {
                        errorMessage = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                    }
                    catch (Exception)
                    {
                    }
                    tries++;
                    if (tries == maxAttempts)
                    {
                        throw new Exception(ex.Status + " " + ex.Message + " " + errorMessage);
                    }
                    await Task.Delay(2000);
                }
            } while (true);
        }
    }
}
