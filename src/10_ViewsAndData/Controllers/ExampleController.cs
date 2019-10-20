using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _10_ViewsAndData.Models;

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
            ViewData["ExampleValue"] = 20;
            return View();
        }

        [HttpGet("2")]
        public IActionResult Index2()
        {
            ViewBag.ExampleValue = "Who wants tires for winter?!";
            return View();
        }

        [HttpGet("3")]
        public IActionResult Index3()
        {
            return View(new StudentViewModel { Age = 666, Name = "Ave C#!" });
        }

    }
}
