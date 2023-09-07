using AuthMVCDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuthMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Remember(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                CookieOptions cookieOptions = new CookieOptions();

                cookieOptions.Expires = DateTime.Now.AddDays(7);

                HttpContext.Response.Cookies.Append("name", name, cookieOptions);

            }

            return Content("Ok, I saved it");

        }

        public IActionResult ThisIsMe() 
        {
            string name = HttpContext.Request.Cookies["name"];

            ViewData["name"] = name;
            ViewBag.Name = name;

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}