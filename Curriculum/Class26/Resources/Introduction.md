# Introduction to Identity


## What is Identity
Identity is the ability to add Authentication and Authorization to your web application. This includes registrations, logins, restricted access to specific members, and 
authentication through Facebook, Google, Twitter, etc...

## Demo


1. Under `Configure()` in your Startup class, add `app.UseAuthentication();` 
- This is what actually allows us to authenticate users within identity.

1. Create an `ApplicationUser` Class that derives from `IdentityUser`.

1. Create an `ApplicationDbContext` that derives from `:IdentityDbContext<ApplicationUser>`

1. Go to your `Startup.cs` Class and add in Identity

```csharp

 services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

```

1. Create an AccountController and add a Register and Login actions

### Sources:
[Intro to Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-2.1&tabs=visual-studio%2Caspnetcore2x)