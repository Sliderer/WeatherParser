using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace Weather
{
    class Parser
    {
        private string returnData = "Загрузка...";
        public delegate void ResponseGet(string response);
        public event ResponseGet responseGet;
        
        internal async void GetWeather(string url)
        {
            await Task.Run(() => GetWeatherAsync(url));
            responseGet?.Invoke(returnData);
        }

        private void GetWeatherAsync(string url)
        {
            WebRequest request;
            request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    string city = new Regex(@"<h1 class=""text-center medium-text-left"">(?<city>[^<]+) current weather").Match(data).Groups["city"].Value;
                    string temperature = new Regex(@"<span class=""value "">(?<temp>[^<]+)</span>").Match(data).Groups["temp"].Value;
                    string feelsLike = new Regex(@"<span class=""value colorize-server-side"" [^>]+.(?<feelsLike>[^<]+)</span>").Match(data).Groups["feelsLike"].Value;
                    string currentWeather = new Regex(@"<p class=""margin-bottom-0"">(?<currentWeather>[^<]+)").Match(data).Groups["currentWeather"].Value;
                    returnData = ("Температура: " + temperature + '\n' + "Ощущается как: " + feelsLike + '\n' + "Текущая погода: " + currentWeather);
                }
            }
        }
            
        public string GetReturnData
        {
            get
            {
                return returnData;
            }
        }
    }
}
