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


		public int GetAverage(Student student)
		{
			int averageSum = 0;
			int counter = 0;
			foreach (var item in student.Transcripts)
			{
				switch (item.Grade.ToLower())
				{
					case "a":
						averageSum += 4;
						counter++;
						break;
					case "b":
						averageSum += 3;
						counter++;
						break;
					case "c":
						averageSum += 2;
						counter++;
						break;
					case "d":
						averageSum += 1;
						counter++;
						break;
					default:
						break;
				}

			}
			return 0;
		}

	}
}
