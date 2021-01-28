using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolDemo.Data;
using SchoolDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SchoolDemo.Models.Interfaces.Services
{
  public class StudentRepository : IStudent
  {
    private SchoolDbContext _context;

    public StudentRepository(SchoolDbContext context)
    {
      _context = context;
    }
    public async Task<Student> Create(Student student)
    {
      _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Added;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<Student> GetOne(int id)
    {
      Student student = await _context.Students.FindAsync(id);
      return student;
    }

    public async Task<List<Student>> GetAll()
    {
      var students = await _context.Students.ToListAsync();
      return students;
    }

    public async Task<Student> Update(int id, Student student)
    {
      _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task Delete(int id)
    {
      Student student = await GetOne(id);
      _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
      await _context.SaveChangesAsync();
    }


  }
}
