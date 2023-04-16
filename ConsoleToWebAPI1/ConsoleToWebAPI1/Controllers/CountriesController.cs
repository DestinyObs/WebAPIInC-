using ConsoleToWebAPI1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleToWebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[BindProperties]
    public class CountriesController : ControllerBase
    {
        // [BindProperty(SupportsGet = true)]
        //public CountryModel Country { get; set; }


        //[BindProperty]
        //public string Name { get; set; }

        ////[BindProperty]
        //public string Population { get; set; }

        ////[BindProperty]
        //public string Area { get; set; }

        //passing with URL
        [HttpGet("{name}")]
        public IActionResult AddCountry([FromQuery] string name)
        {
            return Ok($"Name = {name}");

            //using query streams then order of parameter does not matter
        }
        ////bindin property not working
        //[HttpPost("")]
        //public IActionResult AddCountry()
        //{
        //    return Ok(this.Name);
        //}
    }
}

