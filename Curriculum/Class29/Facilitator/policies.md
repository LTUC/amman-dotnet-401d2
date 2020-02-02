# Policies

Policies are important for us to be able to manage who accesses what parts of our site through certain "Rules" that we
have in place. 



### Demo
Our Demo today will be enforcing the policy of "Admin's only" on our Admin dashboard that we will create. 
First thing we want to do is to enable this in our web application. Let's add the following code to `ConfigureServices` method in
our `Startup.cs` file:

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

### Custom Claim Policies
#### Authorization Handlers & Requirements
To make a custom claims based policy, there are two main
components that make up a custom policy, 

The first class that we create is just the `IAuthorizationRequirement`. This interface allows us to
label our requirement as an actual authorization requirement. Within this requirement we have the ability to set 
parameters and information required if needed for the policy. Much like the Microsoft docs, here is an example
of what a custom policy would look like for a minimum age:

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

A requirement does not need to have to have data properties. 

The next part of the custom policy is the Authorization Handler. 
An authorization handler is responsible for the evaluation of a requirement's properties. 
The authorization handler evaluates the requirements against a provided AuthorizationHandlerContext to 
determine if access is allowed.

A requirement can have multiple handlers, all you do is when creating a new handler, have it be on the same type
of the requirement specified above. 

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
to create the policy, in addition to register it with the DI. Reviewing the Dependency Injection
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