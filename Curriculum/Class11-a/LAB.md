![cf](http://i.imgur.com/7v5ASc8.png) Lab 11: My First MVC App
=====================================

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)

## The Problem Domain
Today you will be creating your first ASP.NET Core MVC web application.
Create a web app that will allow a user to put in a span of 2 different years, and a list of all the winners will be returned.

**Read the Application Specifications, in it's entirety, before beginning** <br />

## Application Specifications
- Your application should include the following:
1. Start with an empty Web App template, with all controllers and views manually created, do not scaffold. If you are having trouble remembering the process to create a basic MVC app, refer to the **Additional Resources** section below for assistance.
2. Add the MVC Middleware and include template routing (the route must be explicitly defined)
3. Only 1 controller. The home controller, with 3 actions (2 Index, and 1 Results)
    - Remember the difference between HTTPGET and HTTPPOST
    - Upon posting back to the server, call the `Results` action to redirect to the results view. 
4. Views to generate the home page and search results
    - Use a form tag to accept user input
    - Use Tag Helpers to help redirect you from results page to the Home page. (HINT: the `_ViewImports.cshml` file may be required)
5. Include HTML/CSS in your final product. **This is required.** 
    - It doesn't have to be fancy, just make it look nice.
6. Enable use of Static Files in your website and create a style sheet and incorporate some creativity into your application. 
7. A model class named `TimePerson` that contains the following properties(these are the headers of the csv file):
8. Create a static method within this model named `GetPersons` that brings in the range of years, and returns `List<TimePerson>`.  
9. Create the internal logic to read in the file, filter the data from the given inputted range using LINQ queries and Lambda expressions, and return the final filtered list of persons.

 Provided is a csv file of all the "Time" Persons of the year from 1927 - 2016. 
```csharp
	public int Year { get; set; }
	public string Honor { get; set; }
	public string Name { get; set; }
	public string Country { get; set; }
	public int BirthYear { get; set; }
	public int DeathYear { get; set; }
	public string Title { get; set; }
	public string Category { get; set; }
	public string Context { get; set; }
```

## Guidance
1. Using what you know about reading in external files, and the `System.File` library, convert the CSV file provided into readable data that can be used within the program. CSV files are delimited using commas. Use what you know from Class 03, and read in the data using the proper delimiter. 

2. Traversing through the file, line by line, convert each line item of the CSV to a `TimePerson` object and add it to the collection.

3. Using LINQ queries and Lambda expressions, filter out list given the range inputted. You code should take into account a few edge cases of inputting an invalid range (e.g. 2001 - 1985), as well as any other reasonable edge cases. 

4. Return the collection with the data that matches the year range.

5. Use the debugger to get a visible look at what is being imported and confirm the format. This will help you visualize what you need to do. 

Remember - This could go on your portfolio, employers may be viewing it, make it something you are proud of. We will be deploying
this site to Azure by the end of the week.


## Unit Tests
- There are no unit tests required for this submission.


## Stretch Goals
- Using what you know about system.io, create a .txt file to save your filtered results so they can be called again without referencing the original .csv file.


## Additional Resources
- Setup default MVC [20 simple steps](https://github.com/codefellows/code-401-dotnet-guide/blob/master/Curriculum/Class11/Resources/MVCSetup.md){:target="_blank"}
- [MVC Tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.1&tabs=aspnetcore2x){:target="_blank"}
	- You are *NOT* allowed to scaffold controllers or use a pre-created template that the tutorial utilizes. Please use this tutorial to dive deeper into the MVC components that you still have questions on


## README
**A Readme is a requirement. No Readme == No Grade.** <br /> 
Here are the requirements for a valid readme: <br />

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context, provide a summary)
2. show them what it looks like in action (Visuals)
3. show them how they use it (Step by step directions, "Happy Path" walk through)
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo `Resources` folder for an example. 
- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"} 

## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements described above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements described above // Program runs/compiles |
	2       | Readme Document does not meet minimum standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // method and variable names are appropriate // Selective and iterative statements are used appropriately, Fundamentals are properly executed // Clearly and cleanly commented // Frequent Commits |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments // minimal or no commits |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |



