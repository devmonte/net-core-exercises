﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DI.Services
{
    public class SouthPolandWeatherService : IWeatherService
    {
        public string GetConcreteWeather() => "South: quite good weather!";
    }
}
