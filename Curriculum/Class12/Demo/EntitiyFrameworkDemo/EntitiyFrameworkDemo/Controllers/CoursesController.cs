using EntitiyFrameworkDemo.Models;
using EntitiyFrameworkDemo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.Controllers
{
	public class CoursesController : Controller
	{
		private readonly ICourses _context;

		public CoursesController(ICourses context)
		{
			_context = context;
		}

		// GET: Courses
		public async Task<IActionResult> Index()
		{
			return View(await _context.GetCourses());
		}

		// GET: Courses/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var course = await _context.FindCourse(id);
			if (course == null)
			{
				return NotFound();
			}

			return View(course);
		}

		// GET: Courses/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Courses/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ID,Name,Technology,Price")] Course course)
		{
			if (ModelState.IsValid)
			{
				await _context.CreateCourseAsync(course);
				return RedirectToAction(nameof(Index));
			}
			return View(course);
		}

		// GET: Courses/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var course = await _context.FindCourse(id);
			if (course == null)
			{
				return NotFound();
			}
			return View(course);
		}

		// POST: Courses/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Technology,Price")] Course course)
		{
			if (id != course.ID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					await _context.UpdateCourse(id, course);
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!CourseExists(course.ID))
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
			return View(course);
		}

		// GET: Courses/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var course = await _context.FindCourse(id);
			if (course == null)
			{
				return NotFound();
			}

			return View(course);
		}

		// POST: Courses/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var course = await _context.FindCourse(id);
			await _context.DeleteCourse(course.ID);
			return RedirectToAction(nameof(Index));
		}

		private bool CourseExists(int id)
		{
			var course = _context.FindCourse(id);
			if (course != null)
			{
				return true;
			}
			return false;
		}
	}
}
