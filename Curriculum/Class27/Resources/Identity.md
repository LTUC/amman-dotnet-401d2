# Identity

## What is Identity
Identity is the ability to add Authentication and Authorization to your web application. This includes registrations, logins, restricted access to specific members, and authentication through Facebook, Google, Twitter, etc...


ASP.NET Core Identity was created to help with the security and management of users.
It provides this abstraction layer between the application and the users/role data. 
We can use the API in it's entirety, or just bits and pieces as we need (such as the salting/hashing by itself) or email services. 
Combines well with EFCore and SQL Server. 

There is a lot of flexibility within ASP.NET Core Identity. We have the ability to take leave whatever we want. 

Let's open up with some very basic definitions:

### Authentication

Authentication is the process of determining **Who you are**

### Authorization

Authorization revolves around **what you are allowed to do**
Example is permissions. 


## Authentication

In ASP.NET Core thre is a proprety named `User`, which is a type of  `ClaimsPrinciple`, which implements `IPrinciple`.


## Demo


1. Under `Configure()` in your Startup class, add `app.UseAuthentication();` 
     - This is what actually allows us to authenticate users within identity.

1. Create an `ApplicationUser` Class that derives from `IdentityUser`.

1. Create an `ApplicationDbContext` that derives from `:IdentityDbContext<ApplicationUser>`
1. Register your new `ApplicationDbContext`

1. Go to your `Startup.cs` Class and add in Identity

```csharp

 services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

```

Commands to run in PMC since you have 2 DbContext:

```
Add-Migration newMigration -Context ApplicationDbContext
```

```
Update-Database -Context ApplicationDbContext
```



1. Create an AccountController
    - Create a Register action (Get and Post)
      - Utulize View Models similar to Login Action.
      - Highlight: UserManager and SignInManager are part of the Identity API. It is what we use to
     manage and access user information
    - Create a login action (Get and Post)
      - Very similar to Register with the View Model


### Sources:
[Intro to Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-2.1&tabs=visual-studio%2Caspnetcore2x)



