using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ConsoleToWebAPI1
{
    public class CustomMiddleWear : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello From New File\n");

            await next(context);

            await context.Response.WriteAsync("Hello from New me \n");
        }
    }
}
