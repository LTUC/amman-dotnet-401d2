using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Models.Interfaces;

namespace SchoolTests
{
    public abstract class Mock : IDisposable
    {

        private readonly SqliteConnection _connection;

        protected readonly  SchoolAPIDbContext _db;

        public Mock()
        {
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();

            _db = new SchoolAPIDbContext( 
                new DbContextOptionsBuilder<SchoolAPIDbContext>()
                .UseSqlite(_connection).Options);

            _db.Database.EnsureCreated();


        }


        protected async Task<Student> CreateAndSaveTestStudent()
        {
            var student = new Student() { FirstName = "Test", LastName = "Test" };
            _db.Students.Add(student);

            await _db.SaveChangesAsync();

            //Assert.NotEqual(0, student.Id);

            return student;
        }


        protected async Task<Course> CreateAndSaveTestCourse()
        {
            var course = new Course() { CourseCode = "test", TechnologyId = 1 };
            _db.Courses.Add(course);
            await _db.SaveChangesAsync();

            //Assert.NotEqual(0, course.Id);

            return course;


        }



        public void Dispose()
        {

            _db?.Dispose();

            _connection?.Dispose();
        }
    }
}