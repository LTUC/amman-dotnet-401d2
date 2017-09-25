# ![cf](http://i.imgur.com/7v5ASc8.png) Lecture 13 : Models

## Review
1. What is a controller
2. What is a View

### Tag-Helpers
1. What do we know about tag helpers?
2. How do we "enable" tag helpers?

3. _Viewimports.cshtml page

```csharp
@using TestApp
@using TestApp.Models
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```

- **After we complerte the scaffolding, we will see tag helpers in the .cshtmnl pages**
- **TagHelpers are a large topic, that we don't really have time to cover it in detail. Leave this to the students to research and look how it is used in the scaffolded Views**


## Models

1. What is a Model?
    - The model in an MVC application represents the state of the application and any buisness logic or operations that should be performed by it. 
    - Business logic should be encapsulated in the model, along with any implementation logic for persisting the state of the applicaiton. 
    - strongly typed views will typically use ViewModel types specifically designed to contain data to dispaly on that view. The controller will create and populate these viewmodels from the model. 

2. The model classes you'll create are known as POCO classes (from "plain-old CLR objects") because they don't have any dependency on EF Core. They just define the properties of the data that will be stored in the database.


#### Goals;
1. Write your first Model Class
2. Use EF Core to create the database using Scaffolding

### Setup
1. Add a new Model named "Movies"
1. Add new Controller >> Minimal Dependencies
1. Add Controller again with MVC Controller with Views, using EF
1. Fill out the wizard with the Movies Model and Applcaiton name context class

#### Visual Studio creates:
 - An Entity Framework Core database context class (Data/MvcMovieContext.cs)
 - A movies controller (Controllers/MoviesController.cs)
  - Razor view files for Create, Delete, Details, Edit and Index pages (Views/Movies/*.cshtml)
  - The automatic creation of the database context and CRUD (create, read, update, and delete) action methods and views is known as scaffolding. You'll soon have a fully functional web application that lets you manage a movie database.

1. Run the app - you will get an error from SQL database

1. We need to create the Database - we will do this through EF Core Migrations
1. Migrations let you create a database that matches your data model and update the database schema when your data model changes.

### Migrations

1. We will use Package Manager Console to:
   - Add the entity Framework Core Tools Package (req to add migrationsand update the database)
   - Add the initial migration
   - update the database with the initial migration
2. Open up NuGet Package Manager console and run the following Command:

` Install-Package Microsoft.EntityFrameworkCore.Tools` <br />
`Add-Migration Initial` <br />
`Update-Database`

1. Notice the new Migrations folder.  


1.The Add-Migration command creates code to create the initial database schema. The schema is based on the model specified in the DbContext(In the Data/MvcMovieContext.cs file). The Initial argument is used to name the migrations. You can use any name, but by convention you choose a name that describes the migration. See Introduction to migrations for more information.2
1. The Update-Database command runs the Up method in the Migrations/<\time-stamp>_InitialCreate.cs file, which creates the database.

Run/Test the app. see the changes in the Database