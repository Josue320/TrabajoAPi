using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Iservices
{
   public interface IService
    {
        Root GetWeather(string ciudad);
        string GetImageLocation(wheather w);

        DateTime convertToDateTime(long milisegundos);

    }
}
