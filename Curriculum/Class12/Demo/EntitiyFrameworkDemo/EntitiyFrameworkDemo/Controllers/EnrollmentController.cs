using EntitiyFrameworkDemo.Models;
using EntitiyFrameworkDemo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Controllers
{
	public class EnrollmentController : Controller
	{
		private readonly IStudent _student;
		private readonly ICourses _courses;


		public EnrollmentController(IStudent student, ICourses courses)
		{
			_student = student;
			_courses = courses;
		}

		// GET: Enrollment
		public async Task<IActionResult> Index()
		{
			return View(await _courses.GetCourseEnrollments());
		}

		// GET: Enrollment/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var courseEnrollment = await _courses.GetEnrollmentForCourseAsync(id);

			if (courseEnrollment == null)
			{
				return NotFound();
			}

			return View(courseEnrollment);
		}

		// GET: Enrollment/Create
		public IActionResult Create()
		{
			ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name");
			ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FullName");
			return View();
		}

		// POST: Enrollment/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("StudentID,CourseID")] CourseEnrollments courseEnrollments)
		{
			if (ModelState.IsValid)
			{
				_context.Add(courseEnrollments);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", courseEnrollments.CourseID);
			ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FullName", courseEnrollments.StudentID);
			return View(courseEnrollments);
		}

		// GET: Enrollment/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var courseEnrollments = await _context.CourseEnrollments.FindAsync(id);
			if (courseEnrollments == null)
			{
				return NotFound();
			}
			ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", courseEnrollments.CourseID);
			ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FullName", courseEnrollments.StudentID);
			return View(courseEnrollments);
		}

		// POST: Enrollment/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("StudentID,CourseID")] CourseEnrollments courseEnrollments)
		{
			if (id != courseEnrollments.CourseID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(courseEnrollments);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!CourseEnrollmentsExists(courseEnrollments.CourseID))
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
			ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", courseEnrollments.CourseID);
			ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FullName", courseEnrollments.StudentID);
			return View(courseEnrollments);
		}

		// GET: Enrollment/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var courseEnrollments = await _context.CourseEnrollments
				.Include(c => c.Course)
				.Include(c => c.Student)
				.FirstOrDefaultAsync(m => m.CourseID == id);
			if (courseEnrollments == null)
			{
				return NotFound();
			}

			return View(courseEnrollments);
		}

		// POST: Enrollment/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var courseEnrollments = await _context.CourseEnrollments.FindAsync(id);
			_context.CourseEnrollments.Remove(courseEnrollments);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool CourseEnrollmentsExists(int id)
		{
			return _context.CourseEnrollments.Any(e => e.CourseID == id);
		}
	}
}
