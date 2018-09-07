using EntitiyFrameworkDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Data
{
	public class SchoolDbContext : DbContext
	{
		public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<CourseEnrollments>().HasKey(ce => new { ce.CourseID, ce.StudentID });
		}

		public DbSet<Course> Courses { get; set; }
		public DbSet<CourseCode> CourseCodes { get; set; }
		public DbSet<CourseEnrollments> CourseEnrollments { get; set; }
		public DbSet<Student> Student { get; set; }
		public DbSet<Transcript> Transcripts { get; set; }


	}
}
