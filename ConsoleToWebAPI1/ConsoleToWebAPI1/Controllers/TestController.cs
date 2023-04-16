using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI1.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from GET";
        }

        public string Get1()
        {
            return "Hello from GET";
        }
    }
}
