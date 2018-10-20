using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiyFrameworkDemo.Models
{
	public class Student
	{
		public int ID { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }

		public string FullName => $"{FirstName} {LastName}";

		[Required]
		public int Age { get; set; }

		public ICollection<CourseEnrollments> Courses { get; set; }
		public ICollection<Transcript> Transcripts { get; set; }

	}
}
