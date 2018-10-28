using EntitiyFrameworkDemo.Data;
using EntitiyFrameworkDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Models.Services
{
	public class CourseService : ICourses
	{
		private SchoolDbContext _context;

		public CourseService(SchoolDbContext context)
		{
			_context = context;
		}

		public async Task CreateCourseAsync(Course course)
		{
			_context.Add(course);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteCourse(int courseId)
		{
			var course = await _context.Courses.FindAsync(courseId);
			_context.Courses.Remove(course);
			await _context.SaveChangesAsync();

		}

		public async Task<Course> FindCourse(int? courseId)
		{
			var course = await _context.Courses.FirstOrDefaultAsync(m => m.ID == courseId);

			return course;
		}

		public async Task<List<CourseEnrollments>> GetCourseEnrollments()
		{
			return await _context.CourseEnrollments.Include(c => c.Course).Include(c => c.Student).ToListAsync() ;
		}

		public async Task<List<Course>> GetCourses()
		{
			return await _context.Courses.ToListAsync();
		}

		public async Task<CourseEnrollments> GetEnrollmentForCourseAsync(int? id)
		{
			var course = await _context.CourseEnrollments
			   .Include(c => c.Course)
			   .Include(c => c.Student)
			   .FirstOrDefaultAsync(m => m.CourseID == id);

			return course;
		}

		public async Task UpdateCourse(int courseId, Course course)
		{
			_context.Update(course);
			await _context.SaveChangesAsync();


		}

	}
}
