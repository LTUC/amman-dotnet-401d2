![cf](http://i.imgur.com/7v5ASc8.png) Lab 27 : Sprint 1 - Milestone #2
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


## Directions:

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 

## User Stories & Guidance:

### User Stories

1. (Developer 1 & 2) As a developer, I would like to utilize and enable ASP.NET Core identity API so that my site can be secure for our users. 
2. (Developer 1 & 3) As a user, I would like to register for an account on the site, so that I can have a personalized experience 
3. (Developer 2 & 3 ) As a Developer, I would like to utilize the repository design pattern so that I can easily switch between production and development environments.
4. (Developer 2) As a Developer, I would like to have 10 products in my database on initial launch of my site

### Guidance

**User Story 1:** Add identity to your empty MVC project. This is done in the Startup.cs class in the ConfigureServices() method. This is a big user story because the following must also be completed to accomplish this story:
1. Create an ApplicationUser (that derives from Identity User)
2. Create a new DBContext for Identity (ApplicationDbContext)
3. Include app.UseAuthentication in your Configure() method within Startup.cs
	
**User Story 2:** Create an AccountController and add into it a Register() action(both a POST and a GET). This is the actual act of creating a new ApplicationUser and adding them into the database. You will need to create a view to hold the registration form, you will then need to send that data to the server and save the data into the identity database. Using a ViewModel may be a good idea to create so that you can capture the Email, Password, and Confirm Password fields that you may have in your Register() action.

**User story 3:** is bringing interfaces and dependency injection together.
1. Create a new interface, maybe named IInventory  
2. Populate the interface with signatures that will represent basic CRUD operations within the inventory such as `Create`, `GetAll`, `GetByID`, `Update`, `Delete`.
	- The actual method signatures within your interface will vary and may not be those exact 5 methods. 
3. Be sure to add the DbContext reference to your interface so that you have access to the db.
4. Register your interface in your startup class
5. Bring your interface into your Controller when you need to reference it instead of your DBContext
	
**User story 4:** is seeding your database to hold default products.
1. Do this in the DBContext file
1. You will need a `Product` model. Your Model should at the minimum hold a Product class. The properties for this class can hold basic information about a Product such as: ID(int), Sku(string), Name(string), Price(decimal), Description(string), Image(string).
2. Use [this resource](https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding){:target="_blank"} to assist in syntax and population
 

## Tests

Test the getter/setters of your models.

## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements descibed above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |
