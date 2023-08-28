using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.ViewModels;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Person person = new Person()
            {
                Name = "Anas",
                Faculity = "IT"
            };

            return View(person);
        }

        public IActionResult Folks()
        {
            List<Person> people = new List<Person>()
            {
                new Person(){Name = "Anas Alshmah", Faculity= "Mathmatical"},
                new Person(){Name = "Al-Obeidat, Odai", Faculity= "Civil Engineer"},
                new Person(){Name = "Albesani, Ammar ", Faculity= "Civil Engineer"},
                new Person(){Name = "alswaiti, Abdel Rahman ", Faculity= "IT"}
            };
            return View(people);
        }

        public IActionResult StudentInformation(string studentName)
        {
            Person person = new Person()
            {
                Name = studentName,
                Faculity = "IT"
            };

            UniInfo uniInfo = new UniInfo() { Name = "PSUT" };

            StudentInfoVM studentInfoVM = new StudentInfoVM()
            {
                Person = person,
                UniInfo = uniInfo
            };

            return View(studentInfoVM);

        }




        public ViewResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}