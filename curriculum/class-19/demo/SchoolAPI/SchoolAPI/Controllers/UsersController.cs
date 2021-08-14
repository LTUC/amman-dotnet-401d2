using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models.DTO;
using SchoolAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {

    private IUser userService;

    public UsersController(IUser service)
    {
      userService = service;
    }

    // ROUTES

    [HttpPost("Register")]
    public async Task<ActionResult<UserDto>> Register(RegisterUserDto data)
    {
      // Note: data (RegisterUser) comes from an inbound DTO/Model created for this purpose
      // this.ModelState?  This comes from MVC Binding and shares an interface with the Model
      var user = await userService.Register(data, this.ModelState);
      if (ModelState.IsValid)
      {
        return user;
      }

      return BadRequest(new ValidationProblemDetails(ModelState));
    }

    [HttpPost("Login")]
    public async Task<ActionResult<UserDto>> Login(LoginDto data)
    {
      var user = await userService.Authenticate(data.Username, data.Password);

      if (user == null)
      {
        return Unauthorized();
      }

      return user;
    }

    // Whoa! New annotation that will be able to Read the bearer token
    // and return a user based on the claim/principal within...
    // [Authorize(Roles = "Administrator")]
    [Authorize(Policy = "create")]
    [HttpGet("me")]
    public async Task<ActionResult<UserDto>> Me()
    {
      // Following the [Authorize] phase, this.User will be ... you.
      // Put a breakpoint here and inspect to see what's passed to our getUser method
      return await userService.GetUser(this.User);
    }

  }
}
