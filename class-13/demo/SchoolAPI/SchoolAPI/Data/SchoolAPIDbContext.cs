using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public class SchoolAPIDbContext : DbContext
    {
        public SchoolAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Studetns { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
