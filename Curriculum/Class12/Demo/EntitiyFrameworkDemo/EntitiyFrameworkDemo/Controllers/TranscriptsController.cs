using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntitiyFrameworkDemo.Data;
using EntitiyFrameworkDemo.Models;

namespace EntitiyFrameworkDemo.Controllers
{
    public class TranscriptsController : Controller
    {
        private readonly SchoolDbContext _context;

        public TranscriptsController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Transcripts
        public async Task<IActionResult> Index()
        {
            var schoolDbContext = _context.Transcripts.Include(t => t.Course).Include(t => t.Student);
            return View(await schoolDbContext.ToListAsync());
        }

        // GET: Transcripts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcript = await _context.Transcripts
                .Include(t => t.Course)
                .Include(t => t.Student)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (transcript == null)
            {
                return NotFound();
            }

            return View(transcript);
        }

        // GET: Transcripts/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name");
            ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FirstName");
            return View();
        }

        // POST: Transcripts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StudentID,CourseID,Grade,Pass")] Transcript transcript)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transcript);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", transcript.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FirstName", transcript.StudentID);
            return View(transcript);
        }

        // GET: Transcripts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcript = await _context.Transcripts.FindAsync(id);
            if (transcript == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", transcript.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FirstName", transcript.StudentID);
            return View(transcript);
        }

        // POST: Transcripts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentID,CourseID,Grade,Pass")] Transcript transcript)
        {
            if (id != transcript.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transcript);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TranscriptExists(transcript.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", transcript.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FirstName", transcript.StudentID);
            return View(transcript);
        }

        // GET: Transcripts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transcript = await _context.Transcripts
                .Include(t => t.Course)
                .Include(t => t.Student)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (transcript == null)
            {
                return NotFound();
            }

            return View(transcript);
        }

        // POST: Transcripts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transcript = await _context.Transcripts.FindAsync(id);
            _context.Transcripts.Remove(transcript);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TranscriptExists(int id)
        {
            return _context.Transcripts.Any(e => e.ID == id);
        }
    }
}
