using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleToWebAPI1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleWear>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello From Destiny\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from use-2\n");


            //});

            //app.UseMiddleware<CustomMiddleWear>();

            //app.Map("/nitish", CustomCode);

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from use-3\n");
            //    await next();
            //    await context.Response.WriteAsync("Please be my friend\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("I want to be your friend\n");
                
            //});

            //app.Run(async context => 
            //{
            //    await context.Response.WriteAsync("Hello From Destiny2 \n");
            //});
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from nitish\n");

            });
        }
    }
}
