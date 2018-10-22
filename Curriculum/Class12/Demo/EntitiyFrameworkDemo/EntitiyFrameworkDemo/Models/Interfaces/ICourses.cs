using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Models.Interfaces
{
	public interface ICourses
	{
		Task CreateCourseAsync(Course course);

		Task UpdateCourse(int courseId, Course course);

		Task DeleteCourse(int courseId);

		Task<Course> FindCourse(int? courseId);

		Task<List<Course>> GetCourses();
	}
}
