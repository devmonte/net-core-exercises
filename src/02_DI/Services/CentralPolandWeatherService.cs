﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DI.Services
{
    public class CentralPolandWeatherService : IWeatherService
    {
        public string GetConcreteWeather() => "South: Data unavailable!";
    }
}
