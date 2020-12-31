using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityDemo.Data;
using IdentityDemo.Models.Interfaces;
using IdentityDemo.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace IdentityDemo
{
    public class Startup
    {
        public IConfiguration Configuraiton { get; }

        public Startup(IConfiguration configuration)
        {
            Configuraiton = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // this will allow us to use the Controllers for our API calls without the req of razor pages or views
            services.AddControllers();

            services.AddDbContext<BlogDbContext>(options =>
            {
                //Install-Package Microsoft.EntityFrameworkCore.SqlServer
                options.UseSqlServer(Configuraiton.GetConnectionString("DefaultConnecton"));
            });

            services.AddTransient<IPostManager, PostService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // using the default is fine and a nice shortcut
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
