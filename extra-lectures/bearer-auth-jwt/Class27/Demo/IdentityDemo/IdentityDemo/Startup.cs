using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityDemo.Data;
using IdentityDemo.Models;
using IdentityDemo.Models.Interfaces;
using IdentityDemo.Models.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

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
                options.UseSqlServer(Configuraiton.GetConnectionString("DefaultConnection"));
            });

            services.AddDbContext<UsersDbContext>(options =>
            {
                //Install-Package Microsoft.EntityFrameworkCore.SqlServer
                options.UseSqlServer(Configuraiton.GetConnectionString("UserConnection"));
            });


            // Register identity and associate it with the appuser and the usersdbcontext
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<UsersDbContext>()
                .AddDefaultTokenProviders();

            // REgisetring the JWT Authenticaiton Scheme
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuraiton["JWTIssuer"],
                    ValidAudience = Configuraiton["JWTIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuraiton["JWTKey"]))
                };
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

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                // using the default is fine and a nice shortcut
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
