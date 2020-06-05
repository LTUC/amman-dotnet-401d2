using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using IdentityDemo.Models;
using IdentityDemo.Models.DTO;
using IdentityDemo.Models.RegisterDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace IdentityDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;

        }

        [HttpPost, Route("register")]
        public async Task<IActionResult> Register(RegisterDTO register)
        {
            ApplicationUser user = new ApplicationUser()
            {
                Email = register.Email,
                UserName = register.Email,
                FirstName = register.FirstName,
                LastName = register.LastName
            };

            var result = await _userManager.CreateAsync(user, register.Password);

            if (result.Succeeded)
            {
                // Create the Token
                var token = await CreateToken(user);

                await _signInManager.SignInAsync(user, false);

                return Ok(new
                {
                    jwt = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }

            return BadRequest("Unsuccesful");
        }

        [HttpPost, Route("Login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                var token = await CreateToken(user);

                return Ok(new
                {
                    jwt = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }

            return BadRequest("Invalid login Credentials");
        }


        private async Task<JwtSecurityToken> CreateToken(ApplicationUser user)
        {
            var authClaims = new[]
                   {
                        new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim("First Name", user.FirstName),
                        new Claim("Last Name", user.LastName),
                        new Claim("UserId", user.Id)

                    };

            var token = AuthenticateToken(authClaims);
            return token;
        }

        public JwtSecurityToken AuthenticateToken(Claim[] claims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTKey"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWTIssuer"],
                audience: _configuration["JWTIssuer"],
                expires: DateTime.UtcNow.AddHours(24),
                claims: claims,
                signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

    }
}
