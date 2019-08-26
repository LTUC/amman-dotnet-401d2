# Razor Pages

## What are Razor Pages
Razor Pages are new to .NET Core specifically and are an alternative architectural pattern to 
how your site is constructed. It still utulizes MVC and it's routing, but is more of an MVVM approach to 
web developement. 

MVVM stands for Model-View-View Model. This means
that the data flow between the client and the server bypass the 
controller and communicate through the `PageModel` in the 
Razor Page.

Razor Pages are used to help simplify development and seperate individual pages a bit more with MVC.

The advantage of razor pages is there is a lot less "magic" happening. This means that we 
have a bit more control, as developers, of what is happening in the data flow pipeline. 

Razor Pages allow us to really utulize the "Single Responsibility" principle within practice. This means
that we can gaurantee that our Models are really only doing "one" thing and only one thing. 

Razor Pages are great for any form of HTML views that we need within our web app.

MVC and Razor Pages can live in harmony within one web app, it is not an either/or situation. 

We can continue to use controllers for your default routing, or for APIs. Use Razor Pages for other functional pages within
your app that required HTML and views! This separatation keeps our app clean and easy to work with .


### Looking further....
Razor Pages have what's called a "PageModel". This is the model that will be presented to the user
and the data that will be transferred back and forth. 

We will use this PageModel to define our Actions (Get and Post), as well as
define the shape of what data we should expect.

Let's start with a demo: 


### Demo
The final demo code for the day is included in the *Demo* folder. 
Refer to this demo for further reference. 

1. Create a Pages Folder
1. Create an Account Folder
3. Create a new Razor Page for Register
    - Introduce SignInManager
    - Introduce UserManager
    - Create a nested class to hold Register input data
      - Introduce what a "nested class" is
4. Create the HTML for the view with a form
4. Add Code to OnGet
5. Add Code to OnPost
   - Walk/code through what happens during the process of a Register.


### Sources
1. [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-2.2&tabs=visual-studio)