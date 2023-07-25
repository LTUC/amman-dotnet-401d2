using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
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


            builder.Services.AddTransient<ICourse, CourseService>();
            builder.Services.AddTransient<IStudent, StudentService>();
            builder.Services.AddTransient<ITechnology, TechnologyService>();

            var app = builder.Build();

            app.MapControllers();


            //app.MapGet("/", () => "Hello World!");

            app.MapGet("/Test/PrintHelo", () => "Hello From Test!");

            app.Run();
        }
    }
}