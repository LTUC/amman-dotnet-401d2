using EntitiyFrameworkDemo.Data;
using EntitiyFrameworkDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Models.Services
{
	public class Enrollment : ICourses , IStudent
	{
		private SchoolDbContext _context;

		public Enrollment(SchoolDbContext context)
		{
			_context = context;
		}

		public async Task CreateCourseAsync(Course course)
		{
			_context.Add(course);
			await _context.SaveChangesAsync();
		}

		public async Task CreateStudentAsync(Student student)
		{
			_context.Add(student);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteCourse(int courseId)
		{
			var course = await _context.Courses.FindAsync(courseId);
			_context.Courses.Remove(course);
			await _context.SaveChangesAsync();

		}

		public async Task DeleteStudentAsync(int studentId)
		{
			var student = await _context.Student.FindAsync(studentId);
			_context.Student.Remove(student);
			await _context.SaveChangesAsync();
		}

		public async Task<Course> FindCourse(int? courseId)
		{
			var course = await _context.Courses.FirstOrDefaultAsync(m => m.ID == courseId);

			return course;
		}

		public async Task<Student> FindStudentAsync(int studentId)
		{
			var student = await _context.Student.FirstOrDefaultAsync(m => m.ID == studentId);

			return student;
		}

		public async Task<List<Course>> GetCourses()
		{
			return await _context.Courses.ToListAsync();
		}

		public async Task UpdateCourse(int courseId, Course course)
		{
			_context.Update(course);
			await _context.SaveChangesAsync();
			
			
		}

		public async Task UpdateStudentAsync(int studentId, Student student)
		{
			_context.Update(student);
			await _context.SaveChangesAsync();
		}
	}




}
