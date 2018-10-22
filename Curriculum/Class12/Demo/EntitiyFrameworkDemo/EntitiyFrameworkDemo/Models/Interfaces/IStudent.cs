using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Models.Interfaces
{
	interface IStudent
	{
		Task CreateStudentAsync(Student student);

		Task UpdateStudentAsync(int studentId, Student student);

		Task DeleteStudentAsync(int studentId);

		Task<Student> FindStudentAsync(int studentId);
	}
}
