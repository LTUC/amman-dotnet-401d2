using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolDemo.Data;
using SchoolDemo.Models;
using SchoolDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SchoolDemo.Services
{
  public class GradeRepository : IGrade
  {
    private SchoolDbContext _context;

    public GradeRepository(SchoolDbContext context)
    {
      _context = context;
    }
    public async Task<Grade> Create(Grade grade)
    {
      _context.Entry(grade).State = Microsoft.EntityFrameworkCore.EntityState.Added;
      await _context.SaveChangesAsync();
      return grade;
    }

    public async Task<Grade> GetOne(int id)
    {
      Grade grade = await _context.Grades.FindAsync(id);
      return grade;
    }

    public async Task<List<Grade>> GetAll()
    {
      var grade = await _context.Grades.ToListAsync();
      return grade;
    }

    public async Task<Grade> Update(int id, Grade grade)
    {
      _context.Entry(grade).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      await _context.SaveChangesAsync();
      return grade;
    }

    public async Task Delete(int id)
    {
      Grade grade = await GetOne(id);
      _context.Entry(grade).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
      await _context.SaveChangesAsync();
    }


  }
}
