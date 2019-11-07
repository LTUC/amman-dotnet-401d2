using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolEnrollmentDemo.Models.Interfaces
{
    interface ICourseManager
    {
        // Creating
        Task CreateCourse(Course course);

        // updating
        Task UpdateCourse(Course course);

        //deleting
        Task DeleteCourse(int id);

        // Read
        Task<List<Course>> GetCourses();

        Task<Course> GetCourse(int? id);

        IEnumerable<Enrollments> GetEnrollmentsByCourse(int courseId);
    }
}
