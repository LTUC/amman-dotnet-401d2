using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models.Services
{
  public class StudentService : IStudent
  {

    private SchoolDbContext _context;

    public StudentService(SchoolDbContext context)
    {
      _context = context;
    }
    public async Task<Student> Create(Student student)
    {
      // student is an instance of Sudent
      // the current state of the student object: raw

      _context.Entry(student).State = EntityState.Added;
      // the current state of the student object: added

      await _context.SaveChangesAsync();

      return student;
    }


    public async Task<List<Student>> GetStudents()
    {
      // var students = await _context.Students.ToListAsync();
      // return students;

      return await _context.Students
               .Include(s => s.Enrollments)
               .ThenInclude(e => e.Course)
               .Include(s => s.Transcripts)
               .ThenInclude(t => t.Course)
               .ToListAsync();
    }

    public async Task<Student> GetStudent(int id)
    {

      // WAS ...
      // Student student = await _context.Students.FindAsync(id);
      // return student;


      // Manually Tying it Together ...
      /*
      Student student = await _context.Students.FindAsync(id);
      var enrollments = await _context.Enrollments.Where(x => x.StudentId == id)
                                             .Include(x => x.Course)
                                             .ToListAsync();
      student.Enrollments = enrollments;

      return student;
      */

      // Better With LINQ!
      return await _context.Students
               .Include(s => s.Enrollments)
               .ThenInclude(e => e.Course)
               .Include(s => s.Transcripts)
               .ThenInclude(t => t.Course)
               .FirstOrDefaultAsync(s => s.Id == id);

    }

    public async Task<Student> UpdateStudent(int id, Student student)
    {
      _context.Entry(student).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task Delete(int id)
    {
      Student student = await GetStudent(id);
      _context.Entry(student).State = EntityState.Deleted;
      await _context.SaveChangesAsync();
    }

    public async Task AddGradeToTranscript(int studentId, Transcript grade)
    {
      var transcript = new Transcript
      {
        StudentId = studentId,
        CourseId = grade.CourseId,
        Grade = grade.Grade,
        Passed = (int)grade.Grade >= 3
      };

      _context.Transcripts.Add(transcript);
      await _context.SaveChangesAsync();
    }

  }
}
