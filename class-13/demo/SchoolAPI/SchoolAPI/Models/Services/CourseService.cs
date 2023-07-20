using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models.Interfaces;

namespace SchoolAPI.Models.Services
{
    public class CourseService : ICourse
    {

        private readonly SchoolAPIDbContext _context;

        public CourseService(SchoolAPIDbContext context)
        {
            _context = context;
        }

        public async Task<Course> Create(Course course)
        {
            _context.Courses.Add(course);

            await _context.SaveChangesAsync();


            //_context.Entry(course).State = EntityState.Added;

            //await _context.SaveChangesAsync();


            return course;
        }

        public async Task Delete(int id)
        {
            Course course = await GetCourse(id);

            _context.Entry(course).State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<Course> GetCourse(int courseId)
        {
            Course course = await _context.Courses.FindAsync(courseId);

            return course;
           
        }

        public async Task<List<Course>> GetCourses()
        {
            var courses = await _context.Courses.ToListAsync();

            return courses;
        }

        public async Task<Course> UpdateCourse(int id, Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            await _context.SaveChangesAsync();


            return course;
        }
    }
}
