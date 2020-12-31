# Introduction to Model-View-Controller (MVC)

Welcome to the world of MVC! We will learn about the Model-View-Controller (MVC) architectural pattern! 

## Learning Objectives

1. Students will create their own Database Schema given a problem domain.
1. Students will learn and apply the differences between primary keys, foreign key, and composite keys.
1. The students will know the difference between a relational and non-relational database. 
1. The student will be able to successfully define the required components of the web request response cycle with the integration of MVC.
1. The student will be able to successfully describe the separation of concerns concepts through the MVC architectural pattern.

## Today's Outline

### MVC
MVC is an architectural pattern used in web applications. 
MVC is extremely helpful when it comes to separation of concerns. 
This allows us to make changes to the front-end (view) without 
affecting the business logic or the routes. 

#### Model
The model holds the business logic. This is where
we will create new classes and "models" for any objects
we wish to use within our web application

#### View
This is our front-end. HTML and CSS is displayed on 
the views. In addition, on the View, we reference the "Model" that was sent to the view from the controller. 

A really cool feature in Views is that we can display the information
from the model on the .cshtml page by using very basic C# syntax.
This "Razor Syntax" allows us to use foreach loops and if statements
to manipulate how to display the information sent from the controller. 

#### Controller

The controller is the routing part of MVC. A controller contains
Actions, that maps to specific views. Each unique action is it's own 
view page. 


## What is a Database

A database is used to persist and store data across applications. We use databases to save information such as logins, user data, and any other information that is required to persist across the site. 

### Different Kinds of Databases

1. Relational
	- SQL Server
1. Non-Relational
	- SQLLite

### Relational vs Non-Relational

1. Relational
	- Relational databases are databases where each table can hold a relationship with another. This is usually done through some sort of unique identifier that can require a row of each table to stay unique even after the many different transactions that process through. This allows for separation of concerns within a database and ability to manipulate individual parts of a grouped together information

1. Non-Relational
	- Non Relational databases don't depend on relationships or keys between tables. NoSQL is an example, and all the information is stored in one "document" that makes it potentially easier to group together information without having to join tables. 
	Examples: Big Data, and Real Time Applications

## Representation
We can represent a relational database through a database schema. 
	
1. 1:1
1. Many:Many
1. 1:Many
1. Many:1

### Keys
1. Primary Keys
1. Foreign Keys
1. Composite Keys (New!)

	- Primary Keys
	  - Unique identifier for a specific table. Usually named `Id`.
	  - Each row of the table will have it's own unique primary key.
	- Foreign Key
		- Unique identifier from another table.
		- Often used to join tables within a query and associate table data. 
		- Naming convention is the name of the table plus the word Id. Example: BookId is a foreign key in the Library Table. In the Book table, it is simply `Id`. 
	- Composite Key
		- A combination of columns that make up a unique identifier for a table.
		- Composite keys usually consist of multiple foreign keys combined together. No Primary key needs to be included in the combination. 
		- You do not necessarily need to include a primary key in a table that utilizes a composite key.

### Create a Database Schema

Together, in class, create a database schema given a problem domain. 