using SchoolDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set the composite key bindings using the fluent API
            modelBuilder.Entity<Enrollments>().HasKey(enrollment => new { enrollment.CourseID, enrollment.StudentID });

        }

        DbSet<Course> Courses { get; set; }
        DbSet<Enrollments> Enrollments { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Course> Transcripts { get; set; }
    }
}
