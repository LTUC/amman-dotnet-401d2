using Microsoft.EntityFrameworkCore;
using RazorPagesDemo.Models.Entities;

namespace RazorPagesDemo.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Anas", Age = 35 },
                new Person { Id = 2, Name = "Ahmad", Age = 28 },
                new Person { Id = 3, Name = "Omar", Age = 26 },
                new Person { Id = 4, Name = "Osam", Age = 27 }
            );
        }

        public DbSet<Person> People { get; set; }
    }
}
