using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SendGridDemo.Services.EmailService.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SendGridDemo.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public Player Player { get; set; }

        [BindProperty]
        public string? Message { get; set; }

        private readonly IEmailSender _emailSender;
        public IndexModel(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void OnGet()
        {
        }

        public async Task OnPost()
        {
            if (ModelState.IsValid)
            {
                string email = Player.Email;
                string subject = $"Welcome to the team, {Player.Name}";
                string htmlContent = $"<p>We can't wait to see you wearing" +
                    $" {Player.Number} while playing on {Player.Position}</p>";

                await _emailSender.SendEmailAsync(email, subject, htmlContent);

                Message = "Player added and the email is sended";
            }
        }

        
    }
    public class Player
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Position { get; set; }


        public int? Number { get; set; }
    }

}
