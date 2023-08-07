using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Models.Interfaces;
using SchoolAPI.Models.Services;

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

            builder.Services.AddTransient<IUser, IdentityUserService>();
            builder.Services.AddTransient<ICourse, CourseService>();
            builder.Services.AddTransient<IStudent, StudentService>();
            builder.Services.AddTransient<ITechnology, TechnologyService>();



            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "School API",
                    Version = "v1",
                });
            });


            var app = builder.Build();

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