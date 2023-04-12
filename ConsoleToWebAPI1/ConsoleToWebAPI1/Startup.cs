﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI1
{
    public class Startup
    {
        public void ConfigureService(IServiceCollection service)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                   await context.Response.WriteAsync("Hello From new Web API");
                });

                endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello From new Web API testing");
                });
            });
        }
    }
}
