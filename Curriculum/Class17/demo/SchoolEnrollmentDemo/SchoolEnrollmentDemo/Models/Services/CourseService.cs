using SchoolEnrollmentDemo.Data;
using SchoolEnrollmentDemo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolEnrollmentDemo.Models.Services
{
    public class CourseService : ICourseManager
    {
        private SchoolDbContext _context;

        public CourseService(SchoolDbContext context)
        {
            _context = context;
        }
        public Task CreateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetCourse(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetCourses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Enrollment> GetEnrollmentsByCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
