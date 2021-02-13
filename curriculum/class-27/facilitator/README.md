# Facilitators Guide:  Authentication, Authorization, Cookies

# Class 27: Razor Pages

## Overview
Today is the day that we integrate authentication into our CMS app.

By the end of lecture, students should have seen how to:
1. Incorporate Razor Pages into the existing application
2. Add Register and Login functionality with RazorPages
3. See the new user's information in the identity database
4. Shown how to create user stories in Azure Dev Ops


## Preparation

1. Become familar and comfortable with [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-2.2&tabs=visual-studio)
    - You will be introducing and teaching Razor Pages this day. It is reccomended that the instructor is comfortable with the new file structure and flow of Razor Pages, as it is very different than MVC.
    - If this is a brand new concept for the instructor, complete the [Tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-2.2) as a intial dive into the pattern.
1. Become familiar with the Register and Login code to add to your existing code base
   - [Scaffold Register, Login, and LogOut](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-2.2&tabs=visual-studio#examine-register)
   - Review the Demo code provided

## Lecture
1. Code Review (60-90 min)
   - Review Azure Dev Ops process from Class 26
   - Review the Repository Design Pattern data flow
     - Whiteboard/draw out the flow of both MVC and the repo design pattern. It's good for the students to visually see it again.
   - Review the code that you added in your prep (or add it within that hour) with the services and Dependency Injection
1. [Razor Pages](./RazorPages.md) (90 min)
   - Introduce Razor Pages
   - Create a register page
   - Login Page (Can be pushed to Class 28 if needed)
   - Test that it works!
     - This can be done by looking in the new AuthDB for the new entry in the ASPNETUSERS table!

## What changed from yesterday?
Building off of yesterday's demo. We will be adding Authentication and Authorization
to our application

## What might students struggle with today?
Razor pages are new and a little different than what they are used to. Ideally, after creating a Register and Login page, they should get the idea of what a Razor Page is.

## What bugs, issues, or surprises have come up in the past for this class?

If taghelpers are not working, make sure you have the `_ViewImports` file with the tag helper declaration in it within that folder. Be sure to use the wizard/generator to create the `_ViewImports` and not manually create it.
