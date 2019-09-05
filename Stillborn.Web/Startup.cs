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
using Stillborn.Services.Hubs;
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
            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 2;
            });
            services.AddScoped<RepositoryService>();
            services.AddScoped<IChatRoomService,ChatRoomService>();
            services.AddHostedService<DBFillHostedService>();
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chat");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
