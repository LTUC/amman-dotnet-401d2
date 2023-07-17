using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;

namespace EFDemo.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technology>().HasData(
                new Technology() { Id = 1, Name = "Javascript"},
                new Technology() { Id = 2, Name = "Advance DotNet Course" },
                new Technology() { Id = 3, Name = "Java Course" }
                );
        }

        // 
        public DbSet<Technology> Technologies { get; set; }


        public  DbSet<Student> Students { get; set; }

    }
}
