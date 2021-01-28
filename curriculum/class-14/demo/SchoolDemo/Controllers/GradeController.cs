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
  public class GradesController : ControllerBase
  {
    private readonly IGrade _grade;

    public GradesController(IGrade grade)
    {
      _grade = grade;
    }

    // GET: api/Grades
    [HttpGet]
    public async Task<IActionResult> GetGrades()
    {
      return Ok(await _grade.GetAll());
    }

    // GET: api/Grades/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Grade>> GetGrade(int id)
    {
      Grade grade = await _grade.GetOne(id);
      return grade;
    }

    // PUT: api/Grades/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPut("{id}")]
    public async Task<IActionResult> PutGrade(int id, Grade grade)
    {
      if (id != grade.Id)
      {
        return BadRequest();
      }

      var updatedGrade = await _grade.Update(id, grade);

      return Ok(updatedGrade);

    }

    // POST: api/Grades
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPost]
    public async Task<ActionResult<Grade>> PostGrade(Grade grade)
    {
      await _grade.Create(grade);
      // Returns a 201 Header
      // The body will be the result of calling GetGrade with the id
      return CreatedAtAction("GetGrade", new { id = grade.Id }, grade);
    }

    // DELETE: api/Grades/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteGrade(int id)
    {
      await _grade.Delete(id);
      return NoContent();
    }
  }
}
