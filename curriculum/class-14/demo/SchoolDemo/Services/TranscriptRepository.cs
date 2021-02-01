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
  public class TranscriptRepository : ITranscript
  {
    private SchoolDbContext _context;

    public TranscriptRepository(SchoolDbContext context)
    {
      _context = context;
    }
    public async Task<Transcript> Create(Transcript transcript)
    {
      _context.Entry(transcript).State = EntityState.Added;
      await _context.SaveChangesAsync();
      return transcript;
    }

    public async Task<Transcript> GetOne(int studentId, int courseId)
    {

      Transcript transcript = await _context.Transcripts.FirstOrDefaultAsync(x => x.StudentId == studentId && x.CourseId == courseId);
      Student student = await _context.Students.FindAsync(studentId);
      Course course = await _context.Courses.FindAsync(courseId);

      transcript.Student = student;
      transcript.Course = course;

      return transcript;
    }

    public async Task<List<Transcript>> GetAll()
    {
      var transcript = await _context.Transcripts.ToListAsync();
      return transcript;
    }

    public async Task<Transcript> Update(int id, Transcript transcript)
    {
      _context.Entry(transcript).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return transcript;
    }

    public async Task Delete(int studentId, int courseId)
    {
      Transcript transcript = await GetOne(studentId, courseId);
      _context.Entry(transcript).State = EntityState.Deleted;
      await _context.SaveChangesAsync();
    }

  }
}
