using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimePersonSolution.Models;

namespace TimePersonSolution.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(int begYear, int endingYear)
		{
			return RedirectToAction("Result", new { begYear, endingYear });
		}

		[HttpGet]
		public IActionResult Result(int begYear, int endingYear)
		{
			return  View(TimePerson.GetPersons(begYear, endingYear));
		}
	}
}
