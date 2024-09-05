using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_NET_5
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        // Services here work by dependency injection
        // Dependency injection means the CLR will create the needed objects not me
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // For MVC
            //services.AddRazorPages(); // For Razor Pages Project
            //services.AddControllers(); // For API
            //services.AddMvc(); // Mix
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // The pipelines = middleware
        // Authorization and Authentication goes here inside configure
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // Exception page for developers only
            }
            app.UseStaticFiles(); // to use static files "CSS, JS, images"
            app.UseRouting(); // Middleware for routing requests
            // You may have more than one route

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                // Testing new endpoint to /index
                endpoints.MapGet("/index", async context =>
                {
                    await context.Response.WriteAsync("Hello there, Karim!");
                });

                // Route as a pattern
                // VERY IMPORTANT
                // SPACES IN ROUTE STRINGS HAVE MEANING
                // But you need to identify your project as an MVC
                // Segment may be static like previous route /index
                // Or dynamic using {} like the next example
                // Or mixed by adding a string before the {} like Page{controller}
                // defaults: new {action = "index"} ==> old way: if no action is sent go to index 
                // constraints: new {id = new IntRouteConstraint()} ==> old way: the id must be of int datatype
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Movies}/{action=GetMovie}/{id:int?}");
                // optional, default values and datatypes ==> new way
                // Check the other constraints in the lecture files

            });
        }
    }
}
