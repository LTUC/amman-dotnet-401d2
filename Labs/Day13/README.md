![cf](http://i.imgur.com/7v5ASc8.png) Lab 13 : Entity Framework
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a branch named `lab-#`; + `<your name>` **e.g.** `lab12-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas

## Directions
Create a website for a school of your choice (i.e. Hogwarts, Code Fellows, Brakebills College for Magical Pedagogy, etc... ).
Specifically, create a student enrollment system.  Your enrollment system should include the following:

1. A Student Entry form that includes at minimum:
	- First Name
	- Last Name
	- Phone number
	- Class Selection (as a SelectList)
**We can safely assume that a student will only be enrolled in one class at a time.**

2. A database with a `Student` table that saves the student information. 
3. A sepearate page to View all the students currently enrolled. 
4. CSS stylesheet. Add color and styling to your website. 
	- Nothing elaborate or fancy is required, just something more than black text on a white background. 
	- Attempt to make it 'client ready'. 

## Stretch (up to 5pts)
1. Include functionality on the "View All Students" page to search for specific students by Name, or class choice.
2. Include functionality on the "View All Students" page to sort students by ASC or DESC order or First Name or Last Name. 

## Requirements
Your MVC website should contain the following at minimum once completed:
1. Proper Documentation (Comments, Readme etc...)
2. *Two* Controllers (Home, and Enrollment) (Dont forget to use Dependency Injection on these Controllers)
3. *One* Model for `Student.cs`
4. View pages for each of the Controller Actions
5. Data Folder with *One* DbContext file
6. style.css file located in the `wwwroot` folder
7. _ViewImports file to enable TagHelpers 
8. `Startup.cs` should allow the following:
	1. Routing Template 
	2. Static Files, and MVC Middleware
	3. Configured to use the DBContext service
	4. Setup for Dependency Injection
9. appsettings.json file for Database Connection string
10. Tests. Research. Start Here: [Testing a Controller](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing). 
11. We will continue to build off of this webiste for lab 14. Good Luck...


## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> <br /> Refer to the sample-README in the class repo for an example. 
- [Reference](https://github.com/noffle/art-of-readme)

## Rubric
- 7pts: Program meets all requirements described in Lab directions
- 3pts: Code meets industry standards

- **Readme.md required for submission. Missing readme document and tests will result in a best score of 2/10**
