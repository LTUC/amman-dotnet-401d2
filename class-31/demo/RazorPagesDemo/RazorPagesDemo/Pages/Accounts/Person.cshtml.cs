using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages.Accounts
{
    public class PersonModel : PageModel
    {
        public int Id { get; set; }
        public void OnGet(int id)
        {
            Id = id;
        }
    }
}
