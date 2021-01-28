using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models;
using SchoolDemo.Models.Interfaces;

namespace SchoolDemo.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TranscriptsController : ControllerBase
  {
    private readonly ITranscript _transcript;

    public TranscriptsController(ITranscript transcript)
    {
      _transcript = transcript;
    }

    // GET: api/Transcripts
    [HttpGet]
    public async Task<IActionResult> GetTranscripts()
    {
      return Ok(await _transcript.GetAll());
    }

    // GET: api/Transcripts/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Transcript>> GetTranscript(int id)
    {
      Transcript transcript = await _transcript.GetOne(id);
      return transcript;
    }

    // PUT: api/Transcripts/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTranscript(int id, Transcript transcript)
    {
      if (id != transcript.Id)
      {
        return BadRequest();
      }

      var updatedTranscript = await _transcript.Update(id, transcript);

      return Ok(updatedTranscript);

    }

    // POST: api/Transcripts
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPost]
    public async Task<ActionResult<Transcript>> PostTranscript(Transcript transcript)
    {
      await _transcript.Create(transcript);
      // Returns a 201 Header
      // The body will be the result of calling GetTranscript with the id
      return CreatedAtAction("Get†ranscript", new { id = transcript.Id }, transcript);
    }

    // DELETE: api/Transcripts/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteTranscript(int id)
    {
      await _transcript.Delete(id);
      return NoContent();
    }
  }
}
