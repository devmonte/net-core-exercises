using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DI.Services
{
    public class NorthPolandWeatherService : IWeatherService
    {
        public string GetConcreteWeather() => "North: bad weather!";
    }
}
