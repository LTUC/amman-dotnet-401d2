using FormsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormsDemo.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Add()
        { 
            Student student = new Student();
            return View(student);
        }

        public IActionResult Edit(int Id)
        {
            Student student = new Student()
            {
                Id = Id,
                FirstName = "Anas",
                LastName = "Alrantisi",
                Age = 27
            };
            return View(student);
        }

        [HttpPost]
        public IActionResult Add(Student student) 
        {
            if (!ModelState.IsValid) 
            {
                return View(student);
            }

            return Content("The student is added");
            
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            return Content("The student is updated");

        }
    }
}
