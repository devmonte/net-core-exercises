using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_DI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _02_DI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IEnumerable<IWeatherService> _weatherServices;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEnumerable<IWeatherService> weatherServices)
        {
            _logger = logger;
            _weatherServices = weatherServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string weather = "";
            foreach(var weatherService in _weatherServices)
            {
                weather += weatherService.GetWeather();
            }

            return Ok(weather);
        }
    }
}
