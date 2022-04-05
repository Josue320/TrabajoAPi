using AppCore.Iservices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Service
{
    public class ConsultaService : IService
    {

        private IService service;

        public ConsultaService(IService service)
        {
            this.service = service;
        }
        public DateTime convertToDateTime(long milisegundos)
        {
            throw new NotImplementedException();
        }

        public string GetImageLocation(Weather w)
        {
            throw new NotImplementedException();
        }

        public Root GetWeather(string ciudad)
        {
            throw new NotImplementedException();
        }
    }
}
