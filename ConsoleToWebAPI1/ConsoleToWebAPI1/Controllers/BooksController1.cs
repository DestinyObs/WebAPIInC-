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
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]
        public string GetById(int id)
        {
            return "Hello By Dear " + id;
        }
        //alpha must only be the alpha contraint
        //lenght must be exactly the set amount
        //minlenght cannoot go beneath the given minimum
        //max lenght cannot go beyond the maximum
        //reguired
        //regex.... use like regex(expression)

        [Route("{id:Length(5):alpha}")]
        public string GetByIdString(string id)
        {
            return "Hello By Dear new String " + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "Hello to you my regeex " + id;
        }

    }
}
