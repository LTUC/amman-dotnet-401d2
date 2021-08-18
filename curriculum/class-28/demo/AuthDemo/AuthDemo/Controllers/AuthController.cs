using AuthDemo.Auth.Models.Dto;
using AuthDemo.Auth.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Controllers
{
  public class AuthController : Controller
  {
    private IUserService userService;

    public AuthController(IUserService service)
    {
      userService = service;
    }

    // ROUTES
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Signup()
    {
      return View();
    }


    // Takes a post to "/register"
    [HttpPost]
    public async Task<ActionResult<UserDto>> Signup(RegisterUser data)
    {
      // Hardcoding FTW
      data.Roles = new List<string>() { "guest" };

      var user = await userService.Register(data, this.ModelState);
      if (ModelState.IsValid)
      {
        return Redirect("/");
      }

      return View();
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> Authenticate(LoginData data)
    {
      var user = await userService.Authenticate(data.Username, data.Password);

      if (user == null)
      {
        this.ModelState.AddModelError(String.Empty, "Invalid Login");
        return RedirectToAction("Index");
      }

      return Redirect("/");
    }

  }
}
