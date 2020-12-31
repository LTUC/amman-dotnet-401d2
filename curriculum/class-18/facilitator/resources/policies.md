# Policies


## What

Policies are important for us to be able to manage who accesses what parts of our site through certain "Rules" that we have in place. Much like a policy being a specific rule that must be followed within a business, a policy within a .NET Core Web App can be implemented on specific pages to restrict access to specific users given some claim or defining feature (for example: email address or age of user).

## Why

It is not uncommon for pages to be restricted to specific types of users outside of the user holding a specific role. For example, an e-commerce site may have a special page with exclusive products that is dedicated just to users with a specific email domain. Instead of attaching a claim to the user that they are in this special group, the policy can simply check their email address and determine if they are allowed access. 

The ability to base access off of more than just user role allows us to modify and customize our site to better personalize the experience of our users. 


## How

Custom policies are implemented through the creation of Handlers and Requirement. You register both the polilcy requirement and the handler with the service provider for the use with Dependency Injection in the Startup file. Below is a walkthrough of what a demo could look like with this lecture:

### Demo

#### Registering a role based policy

Our Demo today will be enforcing the policy of "Admin's only" on our Admin dashboard that we will create. 
First thing we want to do is to enable this in our web application. Let's add the following code to `ConfigureServices` method in our `Startup.cs` file:

```csharp
services.AddAuthorization(options =>
{
	options.AddPolicy("AdminOnly", policy => policy.RequireRole(ApplicationRoles.Admin));
});
```

Next, we want to Enforce the policy....
Go to the page/controller that we want this policy to be enforced and add the flag above the name of the class or action

```csharp
[Authorize(Policy = "AdminOnly")]
public class MyAdminModel : PageModel
{
}

```

### Custom Claim Policies (optional)

#### Authorization Handlers & Requirements
To make a custom claims based policy, there are two main
components that make up a custom policy, 

The first class that we create is just the `IAuthorizationRequirement`. This interface allows us to
label our requirement as an actual authorization requirement. Within this requirement we have the ability to set paramaters and information required if needed for the policy. Much like the Microsoft docs, here is an example of what a custom policy would look like for a minimum age:

```csharp

public class MinimumAgeRequirement : IAuthorizationRequirement
{
    public int MinimumAge { get; }

    public MinimumAgeRequirement(int minimumAge)
    {
        MinimumAge = minimumAge;
    }
}

```

A requirment does not need to have to have data properties. 

The next part of the custom policy is the Authorization Handler. 
An authorization handler is responsible for the evaluation of a requirement's properties. 
The authorization handler evaluates the requirements against a provided AuthorizationHandlerContext to 
determine if access is allowed.

A requirement can have multiple handlers, all you do is when creating a new handler, have it be on the same type of the requirement specified above. 

Here is an example of what an Authorization Handler may look like that uses the minimum age requirement:

```csharp
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PoliciesAuthApp1.Services.Requirements;

public class MinimumAgeHandler : AuthorizationHandler<MinimumAgeRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                   MinimumAgeRequirement requirement)
    {
        if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth &&
                                        c.Issuer == "http://contoso.com"))
        {
            return Task.CompletedTask;
        }

        var dateOfBirth = Convert.ToDateTime(
            context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth && 
                                        c.Issuer == "http://contoso.com").Value);

        int calculatedAge = DateTime.Today.Year - dateOfBirth.Year;
        if (dateOfBirth > DateTime.Today.AddYears(-calculatedAge))
        {
            calculatedAge--;
        }

        if (calculatedAge >= requirement.MinimumAge)
        {
            context.Succeed(requirement);
        }

        return Task.CompletedTask;
    }
}
```

After creating the handler, we will need to register it within the Startup file.  We need 
to create the policy, in addition to register it wtih the DI. Reviewing the Dependency Injection
lifecycles, that is how we want to do the registration:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

    services.AddAuthorization(options =>
    {
        options.AddPolicy("AtLeast21", policy =>
            policy.Requirements.Add(new MinimumAgeRequirement(21)));
    });

    services.AddSingleton<IAuthorizationHandler, MinimumAgeHandler>();
}
```


Reviewing the rest of the policies doc in the sources, review with the students how to create different policies and 
how to enforce them with the Authorize Tags. 

#### Sources
1. [Policies](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/policies?view=aspnetcore-2.2)