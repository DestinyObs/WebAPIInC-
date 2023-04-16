using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI1.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        //single recource multpli URL
        
        [Route("~api/get-all")]
        [Route("~getall")]
        //overriding route using~
        [Route("~/get-all")]
        public string GetAll()
        {
            return "Hello My Lover";
        }


        //[Route("get-all-authors")]
        //[Route("[controller]/[action]")]
        public string GetAllAuthors()
        {
            return "Hello To The Author Of My Lover";
        }

        [Route("{id}")]
        public string GetById(int id)
        {
            return "Hello By Dear " + id;
        }


        //[Route("books/{id}/author/{authorId}")]
        //[Route("[controller]/[action]")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "Hello author address " + id + " with ID number " + authorId;
        }

        //[Route("search")]
        //[Route("[controller]/[action]")]
        public string SearchBooks(int id, int authorId, string name, int Price)
        {
            return "Search my Book Werey";
        }

    }
}
