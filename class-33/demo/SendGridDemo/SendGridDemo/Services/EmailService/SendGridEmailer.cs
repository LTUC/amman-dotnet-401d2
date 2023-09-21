using SendGrid;
using SendGrid.Helpers.Mail;
using SendGridDemo.Services.EmailService.Interfaces;
using System.Net.Mail;

namespace SendGridDemo.Services.EmailService
{
    public class SendGridEmailer : IEmailSender
    {
        private readonly IConfiguration _configuration;
        public SendGridEmailer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            string apiKey = _configuration["SendGrid:Key"];
            var client = new SendGridClient(apiKey);
            SendGridMessage msg = new SendGridMessage();

            //DefaultFromEmailAddress
            string fromEmailAddress = _configuration["SendGrid:DefaultFromEmailAddress"];
            string fromName = _configuration["SendGrid:DefaultFromName"];
            msg.SetFrom(fromEmailAddress, fromName);

            msg.AddTo(email);
            msg.SetSubject(subject);
            msg.AddContent(MimeType.Html, htmlMessage);

            await client.SendEmailAsync(msg);


            //var from = new EmailAddress("test@example.com", "Example User");
            //var subject = "Sending with SendGrid is Fun";
            //var to = new EmailAddress("test@example.com", "Example User");
            //var plainTextContent = "and easy to do anywhere with C#.";
            //var htmlContent = "<strong>and easy to do anywhere with C#.</strong>";
            //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            //var response = await client.SendEmailAsync(msg);
        }
    }
}
