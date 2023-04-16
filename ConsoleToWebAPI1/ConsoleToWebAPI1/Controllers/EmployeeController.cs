using ConsoleToWebAPI1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public IEnumerable<EmployeeModel>GetEmployee()
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel() {Id = 1, Name = "Employee 1"},
                new EmployeeModel() {Id = 2, Name = "Employee 2"},
                new EmployeeModel() {Id = 3, Name = "Employee 3"},
                new EmployeeModel() {Id = 4, Name = "Employee 4"},
                new EmployeeModel() {Id = 5, Name = "Employee 5"}

            };
        }
        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>() {
                new EmployeeModel() {Id = 1, Name = "Employee 6"},
                new EmployeeModel() {Id = 2, Name = "Employee 7"},
                new EmployeeModel() {Id = 3, Name = "Employee 8"},
                new EmployeeModel() {Id = 4, Name = "Employee 9"},
                new EmployeeModel() {Id = 5, Name = "Employee 10"}}
            );
        }


        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeBasicDeatils(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return new EmployeeModel() { Id = 1, Name = "Employee 20" };

        }
    }
}
