using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Models.Interfaces;
using SchoolAPI.Models.Services;
using System.Configuration;

namespace EFDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // regeisters necessary dependencies for routing and handling HTTP Requests
            builder.Services.AddControllers();

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
       options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
     );
            string connString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services
                .AddDbContext<SchoolAPIDbContext>
                (opions => opions.UseSqlServer(connString));






            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<SchoolAPIDbContext>();


            builder.Services.AddScoped<JwtTokenService>();

            builder.Services.AddTransient<IUser, IdentityUserService>();
            builder.Services.AddTransient<ICourse, CourseService>();
            builder.Services.AddTransient<IStudent, StudentService>();
            builder.Services.AddTransient<ITechnology, TechnologyService>();


            builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                // Tell the authenticaion scheme "how/where" to validate the token + secret
                options.TokenValidationParameters = JwtTokenService.GetValidationPerameters(builder.Configuration);
            });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("create", policy => policy.RequireClaim("permissions", "create"));
                options.AddPolicy("update", policy => policy.RequireClaim("permissions", "update"));
                options.AddPolicy("delete", policy => policy.RequireClaim("permissions", "delete"));

            });

            builder.Services.AddAuthorization();



            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "School API",
                    Version = "v1",
                });
            });


            var app = builder.Build();

           // app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseSwagger(aptions =>
            {
                aptions.RouteTemplate = "/api/{documentName}/swagger.json";
            });

            app.UseSwaggerUI(aptions =>
            {
                aptions.SwaggerEndpoint("/api/v1/swagger.json", "School API");
                aptions.RoutePrefix = "";
            });

            app.MapControllers();

            app.Run();
        }
    }
}