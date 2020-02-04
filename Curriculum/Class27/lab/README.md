# Lab 27 : Sprint 1 - Milestone #2

### User Stories and Tasks

1. (Developer 1 & 3) As a user, I would like to register for an account on the site, so that I can have a personalized experience.
1. (Developer 1 & 2) As a user, I would like to securely login to my account so that I can have a personalized experience on the site.
1. (Developer 2) As a user, I would like to see products available for sale so that customers can browse through the inventory for purchase. 

### Guidance

**User Story 1:** Add identity to your empty MVC project. This is done in the Startup.cs class in the ConfigureServices() method. This is a big user story because the following must also be completed to accomplish this story:
1. Create an ApplicationUser (that derives from Identity User)
1. Create a new DBContext for Identity (ApplicationDbContext) and register it into the startup
1. Setup UserSecrets into your application
1. Include app.UseAuthentication in your Configure() method within Startup.cs. Place this **after** the `app.UseRouting()`.
1. Within the `ConfigureServices()` method, add the Identity service by registering your ApplicationUser with your Identity DbContext 

```
services.AddIdentity<ApplicationUser, IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();
```


Next, You will have to create the actual Register page: 

1. Enable the use of Razor Pages into your application within the `Configure()` method within your `Startup.cs` file
1. Create a new "Pages" directory at the root of your site, followed by an "Account" directory inside "Pages". 
1. Within the "Account" directory, add a new "Razor Page" and name it "Register". By default, you are only given an "OnGet" method. Using the demo code as a reference, complete the rest of the registration logic. A View Model may be a good idea to create so that you can capture the Email, Password, and Confirm Password at minimum.
1. Don't forget your `_ViewImports` file to enable your tag helpers!
1. Ensure that once a user is "created" the entry is successfully added to the database and they are redirected back home. 

**User story 2:** This user story is about creating a page for users to log in. Add a new razor page named `Login` to the "Accounts" folder located in the "Pages" directory. Once your setup is complete, confirm that an already registered user can successfully log into the site.  

**User story 3:** This user story will require the setup of a database. Name this database `StoreDbContext`. Register it in the Startup.cs file. This user story will also require you to implement the repository design pattern
1. Create a new interface, maybe named IInventory  
1. Populate the interface with signatures that will represent basic CRUD operations within the inventory for products such as `Create`, `GetAll`, `GetByID`, `Update`, `Delete`.
	- The actual method signatures within your interface will vary and may not be those exact 5 methods.
	- You won't be using this service right away, but create the interface and service to help prep you for a future sprint.
    - You will create the `ProductsController` in a future sprint. No need to create it now.
1. Be sure to add the DbContext reference to your interface so that you have access to the db.
1. Register your interface in your startup class
1. Bring your interface into your Controller when you need to reference it instead of your DBContext

Finally, seed your database with 10 default products. Within your "Product" Model, have properties to hold basic information about a Product such as: ID(int), Sku(string), Name(string), Price(decimal), Description(string), Image(string).

Use [this resource](https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding){:target="_blank"} to assist in syntax and population of seeding the database.
 

## Tests

Test the getter/setters of your `Product` model

## Rubric

Review the final Sprint 1 submission for rubric/breakdown of all user stories

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of 
the sprint/project. Each day the previous day's milestones build off each other as the project progresses. 
Stay on top of your work, **Communicate**, and work together.
