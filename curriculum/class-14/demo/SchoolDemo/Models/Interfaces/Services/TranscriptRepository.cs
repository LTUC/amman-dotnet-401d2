using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolDemo.Data;
using SchoolDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SchoolDemo.Models.Interfaces.Services
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
      _context.Entry(transcript).State = Microsoft.EntityFrameworkCore.EntityState.Added;
      await _context.SaveChangesAsync();
      return transcript;
    }

    public async Task<Transcript> GetOne(int id)
    {
      Transcript transcript = await _context.Transcripts.FindAsync(id);
      return transcript;
    }

    public async Task<List<Transcript>> GetAll()
    {
      var transcript = await _context.Transcripts.ToListAsync();
      return transcript;
    }

    public async Task<Transcript> Update(int id, Transcript transcript)
    {
      _context.Entry(transcript).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      await _context.SaveChangesAsync();
      return transcript;
    }

    public async Task Delete(int id)
    {
      Transcript transcript = await GetOne(id);
      _context.Entry(transcript).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
      await _context.SaveChangesAsync();
    }

  }
}
