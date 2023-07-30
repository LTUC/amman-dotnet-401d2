using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models.DTO;
using SchoolAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models.Services
{
    public class StudentService : IStudent
    {

        private SchoolAPIDbContext _context;
        private ICourse _courses;

        public StudentService(SchoolAPIDbContext context, ICourse courseService)
        {
            _context = context;
            _courses = courseService;

        }
        public async Task<StudentDTO> Create(NewStudentDto newStudentDto)
        {

            // Add the student
            Student student = new Student()
            {
                FirstName = newStudentDto.Name.Split(" ").First<string>(),
                LastName = newStudentDto.Name.Split(" ").Last<string>()
            };

            _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            await _context.SaveChangesAsync();

            // Use the Courses Service to get a course from the course service
            Course course = await _courses.GetCourseByCode(newStudentDto.CourseCode);

            // Use the Courses Service to add an enrollment for the student and course
            await _courses.AddStudent(course.Id, student.Id);

            StudentDTO addedStudent = await GetStudent(student.Id);

            return addedStudent;

        }


        public async Task<List<StudentDTO>> GetStudents()
        {
            // var students = await _context.Students.ToListAsync();
            // return students;

            return await _context.Studetns
              .Select(student => new StudentDTO
              {
                  Id = student.Id,
                  FirstName = student.FirstName,
                  LastName = student.LastName,
                  CourseDTOs = student.Enrollments
                    .Select(t => new CourseDTO
                    {
                        CourseCode = t.Course.CourseCode,
                        Technology = t.Course.Technology.Name
                    }).ToList()
              }).ToListAsync();

        }

        public async Task<StudentDTO> GetStudent(int id)
        {
            StudentDTO student = await _context.Studetns
              .Select(student => new StudentDTO
              {
                  Id = student.Id,
                  FirstName = student.FirstName,
                  LastName = student.LastName,
                  CourseDTOs = student.Enrollments
                    .Select(t => new CourseDTO
                    {
                        CourseCode = t.Course.CourseCode,
                        Technology = t.Course.Technology.Name
                    }).ToList()
              }).FirstOrDefaultAsync(s => s.Id == id);

            return student;

        }

        public async Task<Student> UpdateStudent(int id, Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task Delete(int id)
        {
            Student student = await _context.Studetns.FindAsync(id);
            _context.Entry(student).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

    }
}