using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public class SchoolAPIDbContext : DbContext
    {
        public SchoolAPIDbContext(DbContextOptions options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This calls the base method, but does nothing
            // base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Technology>().HasData(
              new Technology { Id = 1, Name = "Javascript" },
              new Technology { Id = 2, Name = "Python" },
              new Technology { Id = 3, Name = "C#" },
              new Technology { Id = 4, Name = "Java" }
            );

            modelBuilder.Entity<Enrollment>().HasKey(
                enrollment => new { enrollment.StudentId, 
                    enrollment.CourseId }
                );

        }
    

       public DbSet<Student> Studetns { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Transcript> Transcripts { get; set; }
    }
}
