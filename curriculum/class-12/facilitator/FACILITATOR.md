# Facilitators Guide: Intro to Entity Framework

## Overview

Today we introduce the concept of relational databases and ERD's. We review with the students what a database is and have the students create their own ERD based off of a demo problem domain.

### How does this topic fit?

**Where we've been**:
In the previous class we introduced MVC as a whole. We reviewed all the different components...what each part of the pattern did, and made an application that utulized all three components.

**What are we focusing on today**:
Today, we'll be diving into a brand new project that will eventually turn into an MVC API server. Today, we get to focus on the planning part of a web app and let students understand the importance of understanding the data of an app and how to create an ERD before starting the coding process.

**Where we're headed**:
Next class will focus on building off of this application and turning it into an API server with a SQL Server database.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to teach the students how to read a problem domain and come up with an initial plan of how to store data in an ERD. Use today to enforce the students to analytically think instead of just "jumping into code".

## Preparation

- Read up on ...
- Get ready for questions about
- Look at previous course student submissions for insight as to what you might see in code review.
- Practice [the demo](../demo/demo-name) on whatever.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../resources/databases.md) notes.

### Code Review

- Review the solution for the ERD of Async Inn. Spend about 30 minutes on this, and then move into lecture.

### Intro to Entity Framework

- **Why** (5 min)
	We need a way to manage our DB safely and effectively. We can offload the performance and overall management of the db to EF Core
- **What** (10 min)
	EF Core is our ORM that is used to connect and manage our databases. EFCore can take care of our migrations, relationships, and just about anything within the DB.
- **How** (30 min)
	- You will need the following:
		- DbContext class with a constructor that brings in the DbContextOptions
		- Connection string to where the db lives
		- Register the dbcontext in the `Startup.cs` file
		- create a migration script
		- update the database.
- **Experimentation and Discovery Ideas**
  - Thing

### Simple Models

- **Why** (5 min)
  - Thing
- **What** (10 min)
  - Simple models are the entities that we will ahve stored in our database. These entities will represent what our tables in our database will look like with it's shape.
- **How** (30 min)
  - Thing
- **Experimentation and Discovery Ideas**
  - Thing

### Migration Scripts

Migration scripts are used to generate the changes that need to occur when a change is ready to be applied to the database.

Format: `add-migration [name of migration]`

### Api Scaffold

To add a new scaffolded API controller, pick the following options:

1. Create a new `Controllers` folder
2. Select Add >> Controller
3. Select API Controller with actions, using Entity Framework.
4. Select one of the entities for your model class
5. Select the DbContext you just created
6. Keep the default name the same
7. See the new controller get made and review what was scaffolded.
8. Confirm functionality through Postman

## Lab Notes

- This is the initial implementation of Async Inn project. Today, they will start the code application and start building out the models with a very basic database.

## What might students struggle with today?

- Words

## Past bugs, issues or surprises...

## General Comments and Notes
