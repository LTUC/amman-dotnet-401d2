using EntitiyFrameworkDemo.Data;
using EntitiyFrameworkDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Models.Services
{
	public class StudentService : IStudent
	{
		private SchoolDbContext _context;

		public StudentService(SchoolDbContext context)
		{
			_context = context;
		}

		public async Task CreateStudentAsync(Student student)
		{
			_context.Add(student);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteStudentAsync(int studentId)
		{
			var student = await _context.Student.FindAsync(studentId);
			_context.Student.Remove(student);
			await _context.SaveChangesAsync();
		}

		public async Task<Student> FindStudentAsync(int studentId)
		{
			var student = await _context.Student.FirstOrDefaultAsync(m => m.ID == studentId);

			return student;
		}

		public async Task UpdateStudentAsync(int studentId, Student student)
		{
			_context.Update(student);
			await _context.SaveChangesAsync();
		}
	}
}
