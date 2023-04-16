﻿using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id = 1, Name = "Dumb"},
                new AnimalModel() {Id = 2, Name = "Dummy Head"}
            };
        }


        [Route("")]
        public IActionResult GetAnimals()
        {
            
            var animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id = 1, Name = "Dumb"},
                new AnimalModel() {Id = 2, Name = "Dummy Head"}
            };

            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            

            return LocalRedirect("~/api/animals");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();

            }
            else
            {
                return Ok(animals);
            }

        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var animal = animals.FirstOrDefault(x => x.Id == id);

            if (animal == null)
            {
                return NotFound();
            }
                return Ok(animal);
        }

        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);

            return CreatedAtAction("~/api/animals", new { id = animal.Id }, animal);
        }

    }
}
