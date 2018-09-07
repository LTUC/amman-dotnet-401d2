using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Models
{
    public class Course
    {
		public int ID { get; set; }
		public string Name { get; set; }
		public CourseCode CourseCodeID { get; set; }
		public decimal Price { get; set; }

		CourseCode CourseCode { get; set; }

		public ICollection<CourseEnrollments> Students { get; set; }
	}
}
