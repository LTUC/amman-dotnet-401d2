using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSDemo.Data;
using CMSDemo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CMSDemo
{
    public class Startup
    {
        // Using DI. We want to inject our different configurations
        public IConfiguration Configuration { get; }

        public Startup()
        {
            // This demo is using user Secrets. Be sure to enable this in your application
            // by right clicking on the project and selecting "Manage User Secrets". 
            // You will need to include default connection strings into this file.
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // register the database for non user related items
            services.AddDbContext<BlogDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // register the database for user related data
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("UserConnection")));


            // Register Identity within our application. Connect both our user DB and our Application
            // user as identity components.
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // required for the login/logout to work
            app.UseAuthentication();
 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
        }
    }
}
