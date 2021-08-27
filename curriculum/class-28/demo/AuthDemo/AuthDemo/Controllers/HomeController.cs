using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Controllers
{
  public class HomeController : Controller
  {

    // [Authorize]
    [Authorize(Roles="Guest")]
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Remember(string name)
    {
      if (name != null)
      {
        CookieOptions cookieOptions = new CookieOptions();
        cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
        HttpContext.Response.Cookies.Append("name", name, cookieOptions);
      }

      return Content("Ok, I saved it!");
    }

    public IActionResult Iam()
    {
      string name = HttpContext.Request.Cookies["name"];

      ViewData["name"] = name;

      return View();
    }

  }
}
