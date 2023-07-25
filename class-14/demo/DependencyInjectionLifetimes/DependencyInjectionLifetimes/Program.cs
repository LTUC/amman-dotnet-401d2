using DependencyInjectionLifetimes.Services.Classes;
using DependencyInjectionLifetimes.Services.Interfaces;

namespace DependencyInjectionLifetimes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            
            builder.Services.AddControllers();


            builder.Services.AddSingleton<ISingletonService, SingletonService>();

            builder.Services.AddTransient<ITransientService, TransientService>();

            builder.Services.AddScoped<IScopedService, ScopedService>();

            var app = builder.Build();

             app.MapControllers();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}