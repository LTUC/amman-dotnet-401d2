Questions:

Where do we test?
  - Local Computer?
  - What about on Github actions?
  - What about somewhere else?

You can't just pull in a DbContext, which is the actual connection...

Let's create and use an Abstract "Database Test Class", which lets use setup and tear down a testing database in memory for each test.

  - DB is "created"
  - DB is "used" by the tests
  - DB gets destroyed

This can run agnostically in any environment!

--- TESTS:
l
- Notice how we implement the Test Base Class!
- Need to add a test student and a test course before we can test
- Doing this in the test base?

using System.Threading.Tasks;
using Web.Services;
using Xunit;

namespace Web.Tests
{
  public class DatabaseCourseRepositoryTests : DatabaseTestBase
  {
    [Fact]
    public async Task Can_enroll_and_drop_a_student()
    {
      // Arrange
      var student = await CreateAndSaveTestStudent();
      var course = await CreateAndSaveTestCourse();

      var repository = new DatabaseCourseRepository(_db);

      // Act
      await repository.AddStudentAsync(
        courseId: course.Id,
        studentId: student.Id
      );

      // Assert
      var actualCourse = await repository.GetOneByIdAsync(course.Id);
      Assert.Contains(actualCourse.Enrollments, e => e.StudentId == student.Id);

      // Act
      await repository.DropStudentAsync(
        courseId: course.Id,
        studentId: student.Id
      );

      // Assert
      actualCourse = await repository.GetOneByIdAsync(course.Id);
      Assert.DoesNotContain(actualCourse.Enrollments, e => e.StudentId == student.Id);
    }
  }
}


-- Test Class - DatabaseTestBase.cs

using System;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;
using Xunit;

namespace Web.Tests
{
public abstract class DatabaseTestBase : IDisposable
{
private readonly SqliteConnection _connection;
protected readonly SchoolDbContext _db;

        public DatabaseTestBase()
        {
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();

            _db = new SchoolDbContext(
                new DbContextOptionsBuilder<SchoolDbContext>()
                    .UseSqlite(_connection)
                    .Options);

            _db.Database.EnsureCreated();
        }

        public void Dispose()
        {
            _db?.Dispose();
            _connection?.Dispose();
        }

        protected async Task<Student> CreateAndSaveTestStudent()
        {
            var student = new Student { FirstName = "Test", LastName = "Whatever" };
            _db.Students.Add(student);
            await _db.SaveChangesAsync();
            Assert.NotEqual(0, student.Id); // Sanity check
            return student;
        }

        protected async Task<Course> CreateAndSaveTestCourse()
        {
            var course = new Course { CourseCode = "test" };
            _db.Courses.Add(course);
            await _db.SaveChangesAsync();
            Assert.NotEqual(0, course.Id); // Sanity check
            return course;
        }
    }
}
