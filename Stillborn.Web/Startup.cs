using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using Stillborn.Services.Services;

namespace Stillborn.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)//injection
        {
            services.AddMvc();
            services.AddAuthorization();
            services.AddDbContext<StillbornContext>();
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<StillbornContext>();
            services.AddScoped<RepositoryService>();
            services.AddHostedService<DBFillHostedService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
