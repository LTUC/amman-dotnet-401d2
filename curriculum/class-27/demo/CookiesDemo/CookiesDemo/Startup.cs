using CookiesDemo.Auth.Models;
using CookiesDemo.Auth.Services;
using CookiesDemo.Auth.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiesDemo
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

    // 1. Add a property to hold our configuration
    public IConfiguration Configuration { get; }

    // 2. Add a constructor to receive our condfiguration (through some magic)
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {

      services.AddMvc();

      services.AddDbContext<DemoDbContext>(options =>
      {
        string connectionString = Configuration.GetConnectionString("DefaultConnection");
        options.UseSqlServer(connectionString);
      });

      services.AddIdentity<AuthUser, IdentityRole>(options =>
      {
        options.User.RequireUniqueEmail = true;
      })
      .AddEntityFrameworkStores<DemoDbContext>();


      // NOTE: We could use our JWT service and manually create and read tokens via cookie ...
      /*
      services.AddScoped<JwtTokenService>();
      services.AddAuthentication(options =>
      {
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
      })
        .AddJwtBearer(options =>
        {
          // Tell the authenticaion scheme "how/where" to validate the token + secret
          options.TokenValidationParameters = JwtTokenService.GetValidationParameters(Configuration);

          options.Events = new JwtBearerEvents
          {
            OnMessageReceived = context =>
            {
              context.Token = context.Request.Cookies["auth"];
              return Task.CompletedTask;
            }
          };

        });
      */

      // Alternatively to JWT, use the built-in authentication system
      services.AddAuthentication();

      // Policies
      services.AddAuthorization(options =>
      {
        // Add "Name of Policy", and the Lambda returns a definition
        options.AddPolicy("create", policy => policy.RequireClaim("permissions", "create"));
        options.AddPolicy("read", policy => policy.RequireClaim("permissions", "read"));
        options.AddPolicy("update", policy => policy.RequireClaim("permissions", "update"));
        options.AddPolicy("delete", policy => policy.RequireClaim("permissions", "delete"));
      });

      services.AddTransient<IUserService, IdentityUserService>();


      services.ConfigureApplicationCookie(options =>
      {
        options.AccessDeniedPath = "/login";
      });

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
      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
      });
    }
  }
}
