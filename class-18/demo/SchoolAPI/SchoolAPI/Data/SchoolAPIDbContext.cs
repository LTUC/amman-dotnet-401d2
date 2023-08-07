using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public class SchoolAPIDbContext : IdentityDbContext<ApplicationUser>
    {
        public SchoolAPIDbContext(DbContextOptions options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             base.OnModelCreating(modelBuilder);


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
    

       public DbSet<Student> Students { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Transcript> Transcripts { get; set; }
    }
}
