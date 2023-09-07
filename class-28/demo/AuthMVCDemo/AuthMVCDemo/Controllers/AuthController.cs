using AuthMVCDemo.Models.DTOs;
using AuthMVCDemo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthMVCDemo.Controllers
{
    public class AuthController : Controller
    {
        private IUserService userService;

        public AuthController(IUserService service)
        {
            userService = service; ;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Signup(RegisterUserDto data)
        {


            data.Roles = new List<string>() { "Admin" };
            var user = userService.Register(data, this.ModelState);

            if (!ModelState.IsValid)
            { 
            return View(user);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Authenticate(LoginData loginData)
        {
            
            var user = await userService.Authenticate(loginData.Username, loginData.Password);

            if (user == null)
            {
                this.ModelState.AddModelError("InvalidLogin", "Invalid login attempt");

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
