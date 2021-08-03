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

    private SchoolDbContext _context;

    public CourseService(SchoolDbContext context)
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
      var courses = await _context.Courses.ToListAsync();
      return courses;
    }

    public async Task<Course> GetCourse(int id)
    {
      Course course = await _context.Courses.FindAsync(id);
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


  }
}
