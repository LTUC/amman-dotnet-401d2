# Class 28

## How do I prep for today?

Lecture for this day consists of:
Code Review:

  1. Login capability (if you didn't get to it on Class 27)

Lecture: 
1. [Claims](./Resources/claims.md)
2. Injecting claims into views
   - We need the ability to inject our claims into our views for personalization purposes. Here is an example of what that may look like 
   in our code for our view (shared "_layout" view):

```csharp
@using Microsoft.AspNetCore.Identity
@using CMSDemo.Models
@inject UserManager<ApplicationUser> UserManager
@inject SignInManager<ApplicationUser> SignInManager

    @if (SignInManager.IsSignedIn(User))
    {
        <span style="float: right"> Welcome  @User.Claims.First(c => c.Type == "FullName").Value! </span>
                <form  class="form-inline" asp-page="/Account/Logout" asp-route-returnUrl="@Url.Action("Index", "Home")">
            <button  type="submit" class="nav-link btn btn-link text-dark">Logout</button>
        </form>

    }
    else
    {
        <span style="float: right"> <a asp-page="/Account/Login">Login</a> </span>
        <span style="float: right"> <a asp-page="/Account/Register">Register</a> </span>
    }

``` 
4. Logout
   - Follow the Demo code structure of creating a logout button. Create a logout Razor page. the above view injection shows the code to 
   allow for a logout button
5. Allow Anonymous and Authorized tags
   - [Authorization Tags](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-2.2)
     - We are not doing Roles "yet", so just focus on the [Authorize] and [AllowAnonymous] tags. The demo code only has [Allow Anonymous] but play with
     the two tags to show the difference. We will add more [Authorize] tags as the project evolves.

## What changed from yesterday? 
Building off of yesterday's lab

## What might students struggle with today?  
Claims//Identities//Principles is a lot of concept that isn't really seen. They may struggle with what role each of these play with.

## What bugs, issues, or surprises have come up in the past for this class?

## General comments
