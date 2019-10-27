using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CustomTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _10_ViewsAndData.Controllers
{
    public class ExampleController : Controller
    {
        private readonly ILogger<ExampleController> _logger;

        public ExampleController(ILogger<ExampleController> logger)
        {
            _logger = logger;
        }

        [HttpGet("1")]
        public IActionResult Index1()
        {
            return View();
        }

        [HttpGet("2")]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpGet("3")]
        public IActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public string Submit(ExampleViewModel model)
        {
            return model.Age.ToString();
        }

    }
}
