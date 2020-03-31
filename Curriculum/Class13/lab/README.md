# Lab 13: Async Inn Management System

## The Problem Domain

Now that you have a solid understanding of your database schema for your hotel management system, today you will build off of your initial web application from lab 12 and integrate in our API Controllers and Models for our database. 

## Application Specifications

Your application should include the following upon completion:

1. Startup File
	- Explicit routing of MVC 
	- MVC dependency in ConfigureServices
	- DBContext registered in ConfigureServices
1. Controller
	- Home Controller
1. Data
	- DBContext present and properly configured
	- DB Tables for each entity model (`DbSet<T>`)
	- Composite key association present in `OnModelCreating` override.
	- `appsettings.json` file present with name of database updated
1. Models
	- Each Entity from the DB Table converted into a Model
	- Proper naming conventions of Primary keys
	- Navigation properties present in each Model where required
	- Enum present in appropriate model

1. Test out your application by calling it into postman and make sure that the following data transfer objects get returned:

```
Hotel

```

```
Rooms
```

```
HotelRooms
```

```
Amentities
```

```
RoomAmenities
```

## Guidance

Create a basic MVC web application using the steps provided from class 11 & 12. Include a Home Controller with a basic Index action. No need to add any content to the Index view, just have it load a greeting for now. You will work more on the Home Controller a little further down.
Using your ERD Diagram, convert each entity into a model within your newly created MVC web application.

Following the steps provided, in addition to what we did in class, create a new `DbContext` named `AsyncInnDbContext`. 
Within this DbContext, declare your Database tables and set your composite keys. 
 
##### README

Your README should be in introduction to your web app. Provide in your README, your ERD Diagram and an overview of the relationships and how each entity is related to another. 

## Tests

- No tests required for today. We will start testing in lab 16. 

## Stretch Goals

- There are no Stretch Goals for this assignment.

## Additional Resources

- Setup default MVC [simple steps](https://codefellows.github.io/code-401-dotnet-guide/Resources/MVCSetup){:target="_blank"}


## README

Update your ERD image in your README

## Rubric

The lab rubric can be found [Here](../../Resources/rubric){:target="_blank"} 


## To Submit this Assignment

- Create a new repository on your personal GitHub account
- Name your repo `Async-Inn`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)



