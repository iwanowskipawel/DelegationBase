using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Delegation.Models.Repositories;
using Delegation.Models.FakeRepositories;

namespace Delegation
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IBusinessTripRepository, FakeBusinessTripRepository>();
            services.AddMvc();
            services.AddControllers(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //    if (env.IsDevelopment())
            //    {
            //        app.UseDeveloperExceptionPage();
            //    }

            //    app.UseRouting();

            //    app.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapGet("/", async context =>
            //        {
            //            await context.Response.WriteAsync("Hello World!");
            //        });
            //    });
            //}
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=BusinessTripController}/{action=List}/{id?}");
            });
        }
    }
}
