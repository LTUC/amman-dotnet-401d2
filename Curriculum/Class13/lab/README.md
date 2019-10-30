# Lab 13: Async Inn Management System

## The Problem Domain
Now that you have a solid understanding of your database schema for your hotel management system, today you will build from scratch the initial .NET Core MVC structure and application.

## Application Specifications
Your application should include the following:
1. Startup File
	- Explicit routing of MVC 
	- MVC dependency in ConfigureServices
	- DBContext registered in ConfigureServices
	- Use of static files accepted
2. Controller
	- Home Controller
3. Data
	- DBContext present and properly configured
	- DB Tables for each entity model (`DbSet<T>`)
	- Composite key association present in `OnModelCreating` override.
	- `appsettings.json` file present with name of database updated

4. Models
	- Each Entity from the DB Table converted into a Model
	- Proper naming conventions of Primary keys
	- Navigation properties present in each Model where required
	- Enum present in appropriate model

5. Views
	- View for home page that matches default routing

5. Home Page
	- stylesheet present in web application
	- stylesheet referenced on home page.

6. Web application should build, compile, and redirect us to the home page upon launch. 


## Guidance
Create a basic MVC web application using the steps provided from class 11 & 12. Include a Home Controller with a basic Index action. No need to add any content to the Index view, just have it load a greeting for now. You will work more on the Home Controller a little further down.
Using your ERD Diagram, convert each entity into a model within your newly created MVC web application.

Following the steps provided, in addition to what we did in class, create a new `DbContext` named `AsyncInnDbContext`. 
Within this DbContext, declare your Database tables and set your composite keys. 
 
##### README
Your README should be in introduction to your web app. Provide in your README, your ERD Diagram and an overview of the relationships and how each entity is related to another. 


## Tests
- There are no Unit Tests required for this assignment.

I **strongly** encourage you to research how to write tests for a .NET Core MVC application. Attempt to write some tests, as they will eventually be required.  Research, start here: [Testing a Controller](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing){:target="_blank"}. 

## Stretch Goals
- There are no Stretch Goals for this assignment.

## Additional Resources
- Setup default MVC [simple steps](https://codefellows.github.io/code-401-dotnet-guide/Resources/MVCSetup){:target="_blank"}


## README
**A Readme is a requirement. No Readme == No Grade.** 
Here are the requirements for a valid readme:

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.

Your job is to

1. tell them what it is (with context, provide a summary)
2. show them what it looks like in action (Visuals)
3. show them how they use it (Step by step directions, "Happy Path" walk through)
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

Refer to the README templates in the class repo `Resources` folder for an example. 
- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"} 


## Rubric

The lab rubric can be found [HERE](../../Resources/rubric){:target="_blank"} 


## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Async-Inn`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)



