
using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Infraestructura
{
    public class JsonConsultaRepository : IConsulta
    {

        private Root infoClima;
        private const string ApiKey = "9e7a17c08359f3a339918e8a3f3b0ffa";

        public Root GetWeather(string ciudad)
        {
            using (WebClient obj = new WebClient()) {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={ciudad}&appid=ApiKey";
                var json = obj.DownloadString(url);
                infoClima = JsonConvert.DeserializeObject<Root>(json);
            return infoClima;
            }
        }

      

        public string GetImageLocation(Weather w)
        {
            string imageLocation = $"https://openweathermap.org/img/w/{w.icon}.png";
            return imageLocation;
        }

        public DateTime convertToDateTime(long milisegundos)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milisegundos).ToLocalTime();
            return day;
        }
    }
}
