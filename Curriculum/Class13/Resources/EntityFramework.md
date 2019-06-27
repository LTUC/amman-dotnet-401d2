# Lecture 13: Intro to Entity Framework


### Three Take-a-ways
1. What is the purpose of Entity Framework
3. What is a Code First Migration
4. How do you show composite key relationships in MVC Core.


## Review MVC Lifecycle
Talk about what each of the MVC components look like. do the drawing from 
class 11 again if needed.

Scaffold out, from an empty web app, an MVC web app. Don't add the models yet though,
as those will tie directly into today's lecture. 

#### Demo
1. Scaffold out an empty MVC Site with a Home controller (like on day 11)
2. Look at the ERD of the DB Schema.
3. Convert each entity of the ERD to a Model class in your code.
   - "accidentally" forget 
4. Add Navigation properties (talk about the connection of the two)

## Entity Framework
1. What is Entity Framework?
2. Why do we use it? 

EF Core can serve as an object-relational mapper (O/RM), enabling .NET developers 
to work with a database using .NET objects, and eliminating the need for most of the 
data-access code they usually need to write.

EFCore allows us to make calls and queries to our database through this ORM allowing for efficiency
and ease of use. 

[EF Core](https://docs.microsoft.com/en-us/ef/core/)

### Adding a Database Connection
1. Create a DbContext
2. Add the contructor
3. Create the DBSets for the tables

Be sure to talk about what the constructor is doing (the base class also has a constructor, which is why we have
base(options)).

Now try and script out the models to build the database. **Your are going to get an error....**

At this point, run the `Add-Migration initial` script.  the error you get is:

```

```

This means that you haven't registered the DB Context yet...so let's do that...

1. Register the DBContext in Startup
2. Add the connectionstring logic into the appsettings.json file

During the registration of your DBContext, you will
have to set you app up for Dependency Injection, meaning you need to add a constructor to the startup file
and bring in `IConfiguration`. You can explain to them at a high level what this is doing (The service provider
is bringing in the default congfigurations into the app), but we will talk more about it on Day 16 with DI.


### Implementation
1. Review the Schema and it's relationships & Keys
2. Note that there is at least one composite key. how do we show that? 
3. Add the `OnModelCreating` override in the dbcontext and show how to add the composite key through the fluentAPI


### Code First Migrations
1. Migrations
2. Package Manager console commands to add new migrations and update databases.
3. Add DbContext to Startup.cs
	- Run Migrations and View Database tables in local dev db server


### Shadow Properties
Shadow properties are properties that are not in the .NET entity class, but are in the EFCore model. 
This is useful when the properties need not be exposed, but only for mapping purposes. Most ofen
are used as foreign keys. 

[Shadow Properties](https://docs.microsoft.com/en-us/ef/core/modeling/shadow-properties)

### Fluent API
You use FluentAPI to configure shadow properties. The Fluent API allows us to make changes to the EFCore model
directly. There are some changes that can only be made through the FluentAPI and not through Data Annotations. 
[Fluent API](https://docs.microsoft.com/en-us/ef/core/modeling/shadow-properties#fluent-api)



## Demo

1. Create a new empty MVC application with a Home Controller
2. Create a "data" folder
3. Create and setup a DB Context
4. Add a new appsettings.json file
5. Register the DBContext in the startup file
6. Create an initial migration
7. Update the Database

(See that the db has been created)

8. Look at Schema, convert entities to models
9. Create DbSets for tables
10. Setup composite keys in OnModelCreating

(Add another migration and update the database)

11. see updated database. 
12. "scaffold" out the different controllers with CRUD operations