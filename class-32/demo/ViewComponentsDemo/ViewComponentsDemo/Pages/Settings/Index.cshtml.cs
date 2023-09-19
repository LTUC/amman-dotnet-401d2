using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ViewComponentsDemo.Pages.Settings
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public SettingsVM Settings { get; set; }
        public void OnGet()
        {
            string username 
                = HttpContext.Request.Cookies["username"] != null ? 
                HttpContext.Request.Cookies["username"] : String.Empty;

            Settings = new SettingsVM()
            {
                Name = username
            };
        }

        public void OnPost() 
        { 
            // Cookies We can use it fto track or remember
            // user prefernces and store authentcate token 

            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.UtcNow.AddDays(7);

            HttpContext.Response.Cookies.Append("username", Settings.Name, cookieOptions);  

        }

        public class SettingsVM
        {
            public string Name { get; set; }    
        }
    }
}
