using Microsoft.EntityFrameworkCore;
using RazorPagesDemo.Data;
using RazorPagesDemo.Services;
using RazorPagesDemo.Services.Interfaces;

namespace RazorPagesDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            builder.Services.AddRazorPages();

            string connString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services
                            .AddDbContext<DemoDbContext>
                            (opions => opions.UseSqlServer(connString));

            builder.Services.AddTransient<IPersonService, PersonService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //Home/Index

            app.MapRazorPages();    

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}