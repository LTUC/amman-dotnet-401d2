# Class 13: Intro to Entity Framework Core

## How do I prep for today?
Resources:

1. Entity Framework Core
   - Code First Migrations
3. DbContext
2. Dependency Injection


1. Create a new empty MVC application with a Home Controller
2. Create a "data" folder
3. Create and setup a DB Context
4. Add a new appsettings.json file
5. Register the DBContext in the startup file
6. Create an initial migration
7. Update the Database

(See that the db has been created)

8. Look at Schema, convert entities to models
9. Data Annotations
9. Create DbSets for tables
10. Setup composite keys in OnModelCreating

(Add another migration and update the database)

11. see updated database. 
12. "scaffold" out the different controllers with CRUD operations
13. Show how to convert Enums to dropdown lists


## What changed from yesterday? 
Building off of the same MVC concepts

## What might students struggle with today?  
Dependency Injection. They don't understand it at first, and it takes a long
time for them to really understand all of it's uses. 

It never hurts to keep repeating the concepts of DI over and over again
until it "clicks"

They also struggle with the steup of MVC and all the steps required. I encourage students
to reference the steps provided, and the demos. It comes down to memorization and they
just need to keep doing it until they remember. 

## What bugs, issues, or surprises have come up in the past for this class?
When it comes to the lab, the studetns have expressed that they would prefer the 
tutorial of Class 12 before being assigned the "Person of the Year" lab.

The reason i do not have them switched is because of a few different reasons:
1. The tutorial shows a non-empty template introduction to creating an MVC app. 
2. The tutorial does not go into as much detail as it should for an introductory lab
3. The tutorial, depending on when it was last updated, can be unpredicable. 

The current format is designed to teach studetns how to work with an empty template ("start light")
and really see the connection between MVC by hand without all the background files the MVC template
provides. It also helps uncover some of the "MVC Magic" that students ask about when building out apps.

Generally, this is the only time we should let students use a tempate MVC from Visual Studio, solely
for the purpose of them knowing and understanding what the template provides for them.

## General comments

On this day, jsut get as far as you can about Entity Framework, you also have Class 13 to finish up on
anything you didn't cover that day. The tutorial does a great job at linking class 11 and 13 together, so
spend class 12 diving slowly into Entity Framework and Dependency Injection. 