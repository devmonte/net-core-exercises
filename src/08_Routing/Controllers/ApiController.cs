using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _08_Routing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet("index")]
        public string Index()
        {
            return "Say hello!";
        }


        [Route("secondIndex")]
        public string Index2()
        {
            return "Say hello again!";
        }


        [Route("/cookie")]
        public string Index3()
        {
            return "No cookie!";
        }
    }
}