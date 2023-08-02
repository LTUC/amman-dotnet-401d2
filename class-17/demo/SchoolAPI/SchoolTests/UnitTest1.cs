using SchoolAPI.Models;
using SchoolAPI.Models.Interfaces;
using SchoolAPI.Models.Services;

namespace SchoolTests
{
    public class UnitTest1 : Mock
    {
        [Fact]
        public async void Can_enroll_and_drop_a_student_method()
        {
            // Arrange 
            var student =  await CreateAndSaveTestStudent();

            var course = await CreateAndSaveTestCourse();

            var service = new CourseService(_db);


            // Act
            await service.AddStudent(course.Id, student.Id);

            // Assert
            var actualCourse = await service.GetCourse(course.Id);


            Assert.Contains(actualCourse.Enrollments, e => e.StudentId == student.Id);



        }

        [Fact]
        public async Task SeededData_TechnologyDbSet()
        {
            // Arrange
            var Technologies = new List<Technology>
        {
          new Technology { Id = 1, Name = "Javascript" },
              new Technology { Id = 2, Name = "Python" },
              new Technology { Id = 3, Name = "C#" },
              new Technology { Id = 4, Name = "Java" }

        };

            var service = new TechnologyService(_db);


            // Act
            var techs =  await service.GetTechnologies();
            Assert.Equal(Technologies.Count, techs.Count);
        }
    }
}