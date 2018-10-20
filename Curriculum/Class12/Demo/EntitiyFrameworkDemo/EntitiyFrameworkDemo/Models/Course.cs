using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiyFrameworkDemo.Models
{
	public class Course
	{
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }

		[EnumDataType(typeof(Tech))]
		public Tech Technology { get; set; }

		[Required]
		[DataType(DataType.Currency)]
		public decimal Price { get; set; }

		public ICollection<CourseEnrollments> Students { get; set; }


	}

	public enum Tech
	{
		DotNet,
		Java,
		Python,
		JavaScript
	}

}
