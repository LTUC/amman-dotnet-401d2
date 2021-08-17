using FormsDemo.Models;
using FormsDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsDemo.Controllers
{
  public class HomeControllerV1 : Controller
  {

    public IActionResult Index()
    { 
      return View();
    }
    public IActionResult Add()
    {
      if(!ModelState.IsValid) { return View();  }
      return Content("Pet Added");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {

      Pet rosie = new Pet()
      {
        Name = "Rosie",
        Type = PetType.Dog,
        Age = 6,
        Owner = "John"
      };

      return View(rosie);
    }

    [HttpPost]
    public IActionResult Update( Pet pet )
    {
      if (!ModelState.IsValid) { return View(pet); }
      return Content("Pet Updated");
    }

  }
}
