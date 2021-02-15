using CookiesDemo.Auth.Models.Dto;
using CookiesDemo.Auth.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CookiesDemo.Controllers
{
  public class LoginController : Controller
  {

    private IUserService userService;

    public LoginController(IUserService service)
    {
      userService = service;
    }

    // ROUTES
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Welcome()
    {
      return View();
    }

    public IActionResult Signup()
    {
      return View();
    }




    // Takes a post to "/register"
    [HttpPost]
    public async Task<ActionResult<UserDto>> Register(RegisterUser data)
    {
      // Hardcoding FTW
      data.Roles = new List<string>() { "guest" };

      var user = await userService.Register(data, this.ModelState);
      if (ModelState.IsValid)
      {
        return Redirect("/login/welcome");
      }

      return Redirect("/login");
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> Authenticate(LoginData data)
    {
      var user = await userService.Authenticate(data.Username, data.Password);

      if (user == null)
      {
        return Redirect("/login");
      }

      // If we were to use the JWT Tokens instead of default identity, we'd need to
      // set our own cookie here, so that the startup.cs code can read it on page load
      /*
      CookieOptions cookieOptions = new CookieOptions();
      cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
      HttpContext.Response.Cookies.Append("auth", user.Token, cookieOptions);
      */

      return Redirect("/login/welcome");
    }

    // Whoa! New annotation that will be able to Read the bearer token
    // and return a user based on the claim/principal within...
    // [Authorize]
    // [Authorize(Roles = "Guest")]
    [Authorize(Policy = "create")]
    public async Task<ActionResult<UserDto>> Me()
    {
      // Following the [Authorize] phase, this.User will be ... you.
      // Put a breakpoint here and inspect to see what's passed to our getUser method
      return View(this.User);
    }
  }

}
