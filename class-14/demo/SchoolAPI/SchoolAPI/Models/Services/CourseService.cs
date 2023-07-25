using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models.Services
{
    public class CourseService : ICourse
    {

        private SchoolAPIDbContext _context;

        public CourseService(SchoolAPIDbContext context)
        {
            _context = context;
        }
        public async Task<Course> Create(Course course)
        {
            // course is an instance of Sudent
            // the current state of the course object: raw

            _context.Entry(course).State = EntityState.Added;
            // the current state of the course object: added

            await _context.SaveChangesAsync();

            return course;
        }


        public async Task<List<Course>> GetCourses()
        {
            // var courses = await _context.Courses.ToListAsync();
            // return courses;

            return await _context.Courses
              .Include(s => s.Enrollments)
              .ThenInclude(e => e.Student)
              .ToListAsync();

        }

        public async Task<Course> GetCourse(int id)
        {
            // Course course = await _context.Courses.FindAsync(id);
            // return course;

            var course = await _context.Courses
              .Include(s => s.Enrollments)
              .ThenInclude(e => e.Student)
              .FirstOrDefaultAsync(s => s.Id == id);

            return course;

        }

        public async Task<Course> UpdateCourse(int id, Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task Delete(int id)
        {
            Course course = await GetCourse(id);
            _context.Entry(course).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task AddStudent(int courseId, int studentId)
        {

            Enrollment enrollment = new Enrollment()
            {
                CourseId = courseId,
                StudentId = studentId
            };

            _context.Entry(enrollment).State = EntityState.Added;
            await _context.SaveChangesAsync();

        }

        public async Task RemoveStudentFromCourse(int courseId, int studentId)
        {
            // Find me the record where the course and student match our request
            var result = await _context.Enrollments.FirstOrDefaultAsync(x => x.CourseId == courseId && x.StudentId == studentId);

            _context.Entry(result).State = EntityState.Deleted;

            await _context.SaveChangesAsync();

        }

    }
}