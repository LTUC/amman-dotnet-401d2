using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Models
{
    public class Student
    {
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public ICollection<CourseEnrollments> Courses { get; set; }
		public ICollection<Transcript> Transcripts { get; set; }

	}
}
