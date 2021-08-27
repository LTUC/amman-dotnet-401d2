# Demos: IEmailSender/Sendgrid

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Demo

Review and follow the instructions located in the SendGrid documentation here:
[SendGrid Tutorial](https://docs.microsoft.com/en-us/azure/sendgrid-dotnet-how-to-send-email)

Once you get SendGrid service created and the API Keys saved in your user secrets, start building out the email service:

### Summary of Files

Summary of files being changed.

1. new EmailSender Class

- This will contain our new email.

1. Register Page

- we will add `IEmailSender` to our DI and then send the Welcome email in our `OnPost`

1. Secrets File

- Add SendGrid user secrets to our file

1. Startup File

- Register the DI for the EmailSender

### Service

Install the SendGrid NuGet package:
`Install-Package SendGrid -Version 9.11.0`
[Most Recent](https://www.nuget.org/packages/Sendgrid)

1. Create a new interface called `IEmailSender`

   ```csharp
   public async Task SendEmailAsync(string email, string subject, string htmlMessage)
   ```

1. Create a new class model named `SendGrid.cs`
1. Have this class implement the `IEmailSender` interface.
1. Implement the required method signature

The logic for your Method should be as follows:

```csharp
SendGridClient client = new SendGridClient(Configuration["SendGridKey"]);
SendGridMessage msg = new SendGridMessage();
msg.SetFrom("admin@cfblogposts.com", "Blog Admin");
msg.AddTo(email);
msg.SetSubject(subject);
msg.AddContent(MimeType.Html, htmlMessage);
await client.SendEmailAsync(msg);
```

Let's break down this code:

1. First we need to create a SendGridClient reference. This should connect to your user secrets key from SendGrid. This is going to tell your program to use your SendGrid account
   when sending emails. You will need to inject `IConfiguration` into your EmailSender Class

1. Set the values of the Values within the SendGridMessage.
1. The SendFrom method sets who the email is being sending from.
1. When we add the content of the msg, we need to specify specifically what type of
   text we will be sending through the email.
1. To wrap up the code, initiate a send off of the client with the actual message itself.
1. Finally, we need to register the EmailSender with our Dependency Injection in
   our Startup file.

```csharp
services.AddScoped<IEmailSender, EmailSender>();
```

Now, you can inject the IEmailSender into anything that accepts dependency injection and call the SendEmailAsync method to initiate an email send. Take a look at the Register `OnPost` and see where we are adding the code to send an email:

```csharp
await _emailSender.SendEmailAsync(user.Email, "Thank you for logging in",  "<p>Thank you for logging in </p>");
```

## Create a Razor Pages form and send some emails!

Index.cshtml

```html
@page
@model EmailDemo.Pages.IndexModel
@{
}

<h2>Emailing 101</h2>

<h3>Add a Player</h3>
<form method="post">
  <div>
    <label asp-for="@Model.player.Name">Name:</label>
    <input asp-for="@Model.player.Name" />
  </div>
  <div>
    <label asp-for="@Model.player.Email">Email:</label>
    <input asp-for="@Model.player.Email" />
  </div>
  <div>
    <label asp-for="@Model.player.Position">Position:</label>
    <input asp-for="@Model.player.Position" />
  </div>
  <div>
    <label asp-for="@Model.player.Number">Number:</label>
    <input asp-for="@Model.player.Number" />
  </div>
  <div><button>Save Player</button></div>
</form>

<div asp-validation-summary="All"></div>

@if (Model.Message != null)
{
  <h2>@Model.Message</h2>
}
```

Index.cshtml.cs

```csharp
namespace EmailDemo.Pages
{
  public class IndexModel : PageModel
  {
    [BindProperty]
    public Player player { get; set; }

    [BindProperty]
    public string Message { get; set; }

    public IEmailSender emailService { get; set; }

    public IndexModel(IEmailSender service)
    {
      emailService = service;
    }

    public void OnGet()
    {
    }

    public async Task OnPost()
    {

      if (ModelState.IsValid)
      {

        await emailService.SendEmailAsync(player.Email, $"Welcome to the team, {player.Name}!", $"<p>We can't wait to see you wearing {player.Number} while playing {player.Position} </p>");

        Message = "Email Sent!";

        player.Name = string.Empty;
        player.Email = string.Empty;
        player.Position = string.Empty;
        player.Number = null;

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
      [Required]
      public int? Number { get; set; }
    }
  }
}
```
