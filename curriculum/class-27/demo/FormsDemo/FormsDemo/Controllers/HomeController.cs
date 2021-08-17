using FormsDemo.Models;
using FormsDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsDemo.Controllers
{
  public class HomeController : Controller
  {

    private readonly IPets _pets;

    public HomeController(IPets p)
    {
      _pets = p;
    }

    public async Task<ActionResult<IEnumerable<Pet>>> Index()
    {
      // You should count the list ...
      var list = await _pets.GetAll();
      return View(list);
    }

    [HttpGet]
    public IActionResult Add()
    {
      Pet pet = new Pet();
      return View(pet);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Pet pet)
    {
      await _pets.Create(pet);
      if(!ModelState.IsValid) { return View(pet);  }
      return Content("Pet Added");
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {

      Pet pet = await _pets.GetOne(id);
      return View(pet);
    }

    [HttpPost]
    public async Task<IActionResult> Update( Pet pet )
    {
      await _pets.Update(pet);
      if (!ModelState.IsValid) { return View(pet); }
      return Content("Pet Updated");
    }

  }
}
