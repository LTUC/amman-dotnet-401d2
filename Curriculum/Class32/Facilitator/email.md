# Email

Review and follow the instructions located in the SendGrid documentation here:
[SendGrid Tutorial](https://docs.microsoft.com/en-us/azure/sendgrid-dotnet-how-to-send-email)

Once you get SendGrid service created and the API Keys saved in your user secrets, start building out
the email service:

## Demo

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


### Demo

Install the SendGrid NuGet package:
`Install-Package SendGrid -Version 9.11.0`
[Most Recent](https://www.nuget.org/packages/Sendgrid)

1.  Create a new class model named `EmailSender.cs`
1.  Have this class implement the `IEmailSender` interface. 
1.  Implement the required method signature (`public async Task SendEmailAsync(string email, string subject, string htmlMessage)`)

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

1. First we need to create a SendGridClient reference. This should connect to your 
user secrets key from SendGrid. This is going to tell your program to use your SendGrid account
when sending emails. You will need to inject `IConfiguration` into your EmailSender Class

1. Set the values of the Values within the SendGridMessage. 
1. The SendFrom method sets who the email is being sending from. 
1. When we add the content of the msg, we need to specify specifically what type of 
text we will be sending through the email. 
1. To wrap up the code, initiate a send off of the client with the actual message itself.
1. Finally, we need to register the EmailSender with our Dependency Injection in 
 our Startup file.

```
services.AddScoped<IEmailSender, EmailSender>();
``` 

Now, you can inject the IEmailSender into anything that accepts dependency injection and call the SendEmailAsync
method to initiate an email send. Take a look at the Register `OnPost` and see where we are adding
the code to send an email:

```csharp
await _emailSender.SendEmailAsync(user.Email, "Thank you for logging in", 	"<p>Thank you for logging in </p>");
```


