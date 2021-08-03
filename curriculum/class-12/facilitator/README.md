# Facilitators Guide: Intro to Entity Framework

## Overview

Today we introduce the concept of relational databases and ERD's. We review with the students what a database is and have the students create their own ERD based off of a demo problem domain.

### How does this topic fit?

**Where we've been**:
We previously covered the basics of MVC and specifically the role of models and databases. Students constructed the ERD for the Async Inn web app

**What are we focusing on today**:
We will be creating our first .NET Web App, using Entity framework to map our models to a SQL Server Database and create a few REST routes for our models.

**Where we're headed**:
In the next class, we'll be using Dependency Injection to clean up our Controllers and introduce the Repository Pattern.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to teach the students how to read a problem domain and come up with an initial plan of how to store data in an ERD. Use today to enforce the students to analytically think instead of just "jumping into code".

## Preparation

- Practice [the demo](./DEMO.md) which is a complete step by step creation of a core API server using Entity Framework.
  - There's a lot of steps involved, each of which will be **magic** for the students.
  - Be sure to understand the inner workings and be ready for questions

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../resources/databases.md) notes.

### Code Review

- Review the solution for the ERD of Async Inn. Spend about 30 minutes on this, and then move into lecture.

### Intro to Entity Framework

- **Why** (5 min)
- We need a way to manage our DB safely and effectively.
- We can offload the performance and overall management of the db to EF Core
  - In other words, we let the framework handle the dirty work for us
- **What** (10 min)
  - EF Core serves as an object-relational mapper (O/RM)
  - Enables .NET developers to work with a database using .NET objects
  - Eliminates the need for most of the data-access code they usually need to write.
  - EFCore allows us to make calls and queries to our database through this ORM allowing for efficiency and ease of use.
    - Connect to a database
    - Manage our databases.
    - Handle Migrations
    - Handle Table Relationships
- **How** (30 min)
  - Interactive [DEMO](./DEMO.md)

### Simple Models

- **Why** (5 min)
  - Use your ERD to run theory into data
- **What** (10 min)
  - Simple models are the entities that we will have stored in our database.
    - These entities will represent what our tables in our database will look like (data types/columns)
  - Each entity in your ERD becomes a Model Class
  - Each Model Class will map directly to a database table
- **How** (30 min)
  - Interactive [DEMO](./DEMO.md)

### Migration Scripts

- **Why** (5 min)
  - Each time we make a change to our model, our DB will likely have to change
  - We frequently update the table structure (New/Changed Columns) or add Constraints
  - When these changes get made, they need to safely be applied to the database so we don't destroy currently stored data
- **What** (10 min)
  - Migration scripts are used to generate the changes that need to occur when a change is ready to be applied to the database.
  - Code First Migration
    - Our code (Model classes) might be the impetus for a DB Change
    - We will generate more code to alter the database and apply those changes
  - Add a new migration:
    - Terminal: `dotnet ef migrations add NameOfMigration`
    - Package Manager Console: `Add-Migration NameOfMigration`
  - Update the database:
    - Terminal: `dotnet ef database update`
    - Package Manager Console `Update-Database`
- **How** (30 min)
  - These are created and run as a part of your interactive [DEMO](./DEMO.md)

## Lab Notes

- This is the initial implementation of Async Inn project. Today, they will start the code application and start building out the models with a very basic database.

## What might students struggle with today?

- There is a lot of **boilerplate** code today. Much more wiring than actual code. This is traditionally a blocker for the students.

## Past bugs, issues or surprises...

## General Comments and Notes
