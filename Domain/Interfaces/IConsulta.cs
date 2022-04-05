using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IConsulta
    {
        Root GetWeather(string ciudad);
        string GetImageLocation(Weather w);

        DateTime convertToDateTime(long milisegundos);
    }
}
