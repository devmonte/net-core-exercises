using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _08_Routing.Models;

namespace _08_Routing.Controllers
{
    public class MvcController : Controller
    {
        private readonly ILogger<MvcController> _logger;

        public MvcController(ILogger<MvcController> logger)
        {
            _logger = logger;
        }

        public string Test()
        {
            return "Hello";
        }

    }
}
