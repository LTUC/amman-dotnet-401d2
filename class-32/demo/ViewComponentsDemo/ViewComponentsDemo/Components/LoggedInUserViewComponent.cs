using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsDemo.Components
{
    public class LoggedInUserViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string username
              = HttpContext.Request.Cookies["username"] != null ?
              HttpContext.Request.Cookies["username"] : String.Empty;

            ViewModel user = new ViewModel()
            {
                Username = username
            };

            return View(user);
        }

        public class ViewModel
        {
            public string Username { get; set; }
        }
    }
}
