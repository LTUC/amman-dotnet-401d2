using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CMSDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMSDemo.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;


        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
           )
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [BindProperty]
        public RegisterInput Input { get; set; }

        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { FirstName = Input.FirstName, LastName = Input.LastName, Birthdate = Input.Birthdate, UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    // Create a list to hold all the claims 
                    List<Claim> myclaims = new List<Claim>();

                    // Create individual claims

                    // Claim with a custom name
                    Claim claim = new Claim("FullName", $"{user.FirstName} {user.LastName}");
                    // Claim with a custom format
                    Claim bdClaim = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.Birthdate.Year,
                        user.Birthdate.Month, user.Birthdate.Day).ToString("u"), ClaimValueTypes.DateTime);
                    // Claim using a built in name
                    Claim claimemail = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);

                    // Add each to the list
                    myclaims.Add(claim);
                    myclaims.Add(bdClaim);
                    myclaims.Add(claimemail);

                    // add all of the claims to the user.
                    await _userManager.AddClaimsAsync(user, myclaims);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
        public class RegisterInput
        {
            [Required]
            [Display(Name = "First Name")]

            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]

            public string LastName { get; set; }

            [Required]
            [Display(Name = "Birthdate")]
            [DataType(DataType.Date)]
            public DateTime Birthdate { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }
    }
}