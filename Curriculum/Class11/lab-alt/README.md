Lab 11 : MVC
=====================================


## The Problem Domain
You have been hired by the "Don't Wine About It" company to create a website that assists customers in finding the perfect wine. 
The company has provided for you a dataset of their current inventory. 

Create a website using the MVC architectural pattern that asks the customer to input the price, and point rating
they are searching for. The customer should then be redirected to another page that will show the filtered results from the inventory. 


## Application Specifications
 - Your application should include the following:
1. Start with an empty Web App template, with all controllers and views manually created, do not scaffold. If you are having trouble remembering the process to create a basic MVC app, refer to the **Additional Resources** section below for assistance.
1. Add the MVC Middleware and include template routing (the route must be explicitly defined)
1. Only 1 controller. The home controller, with 3 actions (2 Index, and 1 Results)
    - Remember the difference between HTTPGET and HTTPPOST
    - Upon posting back to the server, call the `Results` action to redirect to the results view.
1. Views to generate the home page and search results
    - Use a form tag to accept user input
    - Use Tag Helpers to help redirect you from results page to the Home page. (HINT: the `_ViewImports.cshml` file may be required)
1. Include HTML/CSS in your final product. **This is required.** 
    - It doesn't have to be fancy, just make it look nice.
1. Enable use of Static Files in your website and create a style sheet and incorporate some creativity into your application. 
1. A model class named `Wine.cs` that contains the following properties(these are the headers of the csv file):
```csharp
   public int ID { get; set; }
   public string Country { get; set; }
   public string Description { get; set; }
   public string Designation { get; set; }
   public int Points { get; set; }
   public decimal Price { get; set; }
   public string Region_1 { get; set; }
   public string Region_2 { get; set; }
   public string Variety { get; set; }
   public string Winery { get; set; }
```

1. Create a static method within this model named `GetWineList` that brings in the range of years, and returns `List<Wine>`.
1. Create the internal logic to read in the file, filter the data from the given inputted range using LINQ queries and return the final filtered list of wines.
1. We will publish this website by the end of the week. Good Luck!


## Guidance
1. Using what you know about reading in external files, and the `System.File` library, convert the CSV file provided into readable data that can be used within the program. CSV files are delimited using commas. Use what you know from Class 03, and read in the data using the proper delimiter. 

1. Traversing through the file, line by line, convert each line item of the CSV to a `Wine` object and add it to the collection.

1. Using LINQ queries, filter out list given the range inputted. You code should take into account a few edge cases of inputting an invalid range (e.g. $2,000,000; or *string* instead of *int*), as well as any other reasonable edge cases.

1. Return the collection with the data that matches the price and point values.

1. Use the debugger to get a visible look at what is being imported and confirm the format. This will help you visualize what you need to do. 

Remember - This could go on your portfolio, employers may be viewing it, make it something you are proud of. We will be deploying
this site to Azure by the end of the week. 


## Unit Tests
- There are no unit tests required for this assignment


## Stretch Goals
- Filter off of more than just the wine points and price. Make some of the filters optional. <br />


## Additional Resources
- Setup default MVC [20 simple steps](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/Class11/facilitator/Resources/MVCSetup){:target="_blank"}
- [MVC Tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.1&tabs=aspnetcore2x){:target="_blank"}
	- You are *NOT* allowed to scaffold controllers or use a pre-created template that the tutorial utilizes. Please use this tutorial to dive deeper into the MVC components that you still have questions on


## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. Tell them what it is (with context)
1. Show them what it looks like in action
1. Show them how they use it
1. Tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.
 <br />
 Refer to the sample-README in the class repo for an example. 

- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"}

## Rubric

The lab rubric can be found [Here](../Resources/rubric){:target="_blank"} 

## To Submit this Assignment

- Create a new repository on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)