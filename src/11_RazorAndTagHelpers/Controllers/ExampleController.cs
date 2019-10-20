using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _11_RazorAndTagHelpers.Controllers
{
    public class ExampleController : Controller
    {
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
    }
}