using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace _07_Configuration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IOptionsMonitor<WeatherForecast> _weather;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptionsMonitor<WeatherForecast> weather)
        {
            _logger = logger;
            _weather = weather;
        }

        [HttpGet]
        public string Get()
        {
            return _weather.CurrentValue.Summary;
        }
    }
}
