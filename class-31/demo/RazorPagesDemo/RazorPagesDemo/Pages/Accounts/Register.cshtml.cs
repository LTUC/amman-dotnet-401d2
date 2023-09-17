using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models.Entities;
using RazorPagesDemo.Services.Interfaces;

namespace RazorPagesDemo.Pages.Accounts
{
    public class RegisterModel : PageModel
    {
        private readonly IPersonService personService;

        [BindProperty]
        public RegisterViewModel Input { get; set; }

        public RegisterModel(IPersonService service)
        {
            personService = service;
        }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Person person = new Person()
            {
                Age = Input.Age,
                Name = Input.Name,
            };

             Person record = await personService.Create(person);

            return Redirect("/Accounts/Index");

            /// Check The Modelstate
            /// Return back to the Index page
        }

        public class RegisterViewModel
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
