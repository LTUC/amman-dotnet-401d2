using EntitiyFrameworkDemo.Models;
using Microsoft.EntityFrameworkCore;

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

			modelBuilder.Entity<Student>().HasData(
			   new Student
			   {
				   ID = 1,
				   FirstName = "Jack",
				   LastName = "Shepard",
				   Age = 36
			   },
			   new Student
			   {
				   ID = 2,
				   FirstName = "Kate",
				   LastName = "Austin",
				   Age = 29
			   },
			   new Student
			   {
				   ID = 3,
				   FirstName = "Araya",
				   LastName = "Stark",
				   Age = 16
			   }
			);

			modelBuilder.Entity<Course>().HasData(
				new Course
				{
					ID = 1,
					Name = "seattle-dotnet-401d5",
					Technology = Tech.DotNet,
					Price = 5000.00m

				},
				new Course
				{
					ID = 2,
					Name = "seattle-jave-401d2",
					Technology = Tech.Java,
					Price = 6000m
				},
				new Course
				{
					ID = 3,
					Name = "seattle-javascript-401d10",
					Technology = Tech.JavaScript,
					Price = 3000m
				}
			);
		}

		public DbSet<Course> Courses { get; set; }
		public DbSet<CourseCode> CourseCodes { get; set; }
		public DbSet<CourseEnrollments> CourseEnrollments { get; set; }
		public DbSet<Student> Student { get; set; }
		public DbSet<Transcript> Transcripts { get; set; }


	}
}
