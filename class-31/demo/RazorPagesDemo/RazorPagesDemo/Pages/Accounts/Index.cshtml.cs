using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models.Entities;
using RazorPagesDemo.Services.Interfaces;

namespace RazorPagesDemo.Pages.Accounts
{
    //Accounts/Index
    public class IndexModel : PageModel
    {
        private readonly IPersonService personService;

        public IndexModel(IPersonService service)
        {
            personService = service;
        }

        public List<Person> People { get; set; }

        //public string Name { get; set; }


        public async Task OnGet(string name) // ?name=Anas
        {
            People = await personService.GetAll();
        }
    }
}
