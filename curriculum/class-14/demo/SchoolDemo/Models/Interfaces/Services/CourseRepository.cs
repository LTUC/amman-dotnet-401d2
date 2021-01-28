using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolDemo.Data;
using SchoolDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SchoolDemo.Models.Interfaces.Services
{
  public class CourseRepository : ICourse
  {
    private SchoolDbContext _context;

    public CourseRepository(SchoolDbContext context)
    {
      _context = context;
    }
    public async Task<Course> Create(Course course)
    {
      _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Added;
      await _context.SaveChangesAsync();
      return course;
    }

    public async Task<Course> GetOne(int id)
    {
      Course course = await _context.Courses.FindAsync(id);
      return course;
    }

    public async Task<List<Course>> GetAll()
    {
      var course = await _context.Courses.ToListAsync();
      return course;
    }

    public async Task<Course> Update(int id, Course course)
    {
      _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      await _context.SaveChangesAsync();
      return course;
    }

    public async Task Delete(int id)
    {
      Course course = await GetOne(id);
      _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
      await _context.SaveChangesAsync();
    }


  }
}
