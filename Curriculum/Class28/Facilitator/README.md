# Class 28 Claims

## Overview
Today we will break down the individual components of identity and 
add individual claims into the ongoing project. 

By the end of lecture, students should:
1. Discussed the difference between a Claim/Identity/Principle
1. What an individual claim is and why we use them
1. How to create and add claims to a user
1. Inject specific claims into a view


## Preparation?

Here is a checklist of items that you should complete before starting today's lecture:
1. Complete the day's readings. These are great resources to help understand the content for today's lecture.
1. Confirm that the demo code from class 27 is complete and error free

## Lecture: 
1. Code Review (1 hour)
   - If you did not get to Login capabilites on Class 27, do that during
   code review
   - Show how to add Logout capabilities
     - Provided Demo code in `Pages/Logout.cshtml` 
   - Show what `Authorize` and `AllowAnonymous` tags do
     - [Authorization Tags](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-2.2)
     - We are not doing Roles "yet", so just focus on the [Authorize] and [AllowAnonymous] tags. The demo code only has [Allow Anonymous] but play with the two tags to show the difference. We will add more [Authorize] tags as the project evolves. 
     - You will need to add `app.UseAuthorization();` To the `Configure()` method in the `Startup.cs`. Place this bit of code under the `app.UseAuthorization()`. This bit of code will allow you to be authorized on specfic pages.

1. [Claims](./claims.md) (60-90 minutes)
   - What are claims? 
   - 
1. Injecting claims into views (30-45 minutes)
   - We need the ability to inject our claims into our views for 
 personalization purposes. You can inject claims in either view specific pages or in _layout pages. Here is an example of what that may look like in our code for our view in a shared layout view: (This code is present in the provided demo code)

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

## What changed from yesterday? 
Building off of yesterday's lab

## What might students struggle with today?  
Claims//Identities//Principles is a lot of concept that isn't really seen. They may struggle with what role each of these play with. The students are not required to write their own identity or principle,  but they should know and understand what is happening under the hood. 
