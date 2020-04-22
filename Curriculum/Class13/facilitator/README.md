# Facilitators Guide: Intro to Entity Framework Core

## Overview

Today, we will learn and implement Entity Framework Code First migrations. The students will convert their ERDs that they created into entity models, and seed dummy data into their DB. 

### How does this topic fit?

**Where we've been**:
In the previous class we learned about what database relationships and what an ERD was. The students have already created a basic DBContext in their app, and now they are ready for a code first migration!

**What are we focusing on today**:
Today, we'll be doing a code first migration with the entities from our ERD. We will conduct a code first migration, and then seed default data into our database.

**Where we're headed**:
Next class will focus on apis and using our database with incoming routes with controllers.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to showcase the power of Entity Framework and Code First Migrations. Really use today to get the students comfortable with EFCore. Try and defuse some of the "magic" that is happening.

## Preparation

- Read up on ...
- Get ready for questions about
- Look at previous course student submissions for insight as to what you might see in code review.
- Practice [the demo](../demo/demo-name) on whatever.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Code Review for today should consist of reviewing the solution to the AsyncInn ERD. Review the components of an ERD, why they are important, and what the Async Inn consists of. 
- Code Review should also consist of a review of how to create and register the DBContext. 

### Code First Migrations

- **Why** (5 min)
  - If we are building an app that is brand new, we want the data in the db to match our entity models. Code First migrations allows us to set our shape through our code. 
- **What** (10 min)
  - Code first migration is the ability to take the entity models and convert them to database entities. The code first migration will read the models first, and then take those models as the shape of the database.
- **How** (30 min)
  - Create your models from your ERD, set your tables in your db context. add migration, and then update your database. 
- **Experimentation and Discovery Ideas**
  - Showcase the different errors that you can get withn the build process.

### Set Key Relationships

- **Why** (5 min)
  - We defined composite keys in our ERD. every table requires a primary key or some sort of unique identifier. We need to set that for the migration to be successful. 
- **What** (10 min)
  - The composite key is a combination of keys that tell us a certain set of fields are unique
- **How** (30 min)
  - Through the DBContext on the `OnModelCreating` override method. 

### Seeding the Database

- **Why** (5 min)
  - It's hard to test our data if we don't have any data to start with. 
- **What** (10 min)
  - Seeding the database simply means to add default data upon database creation. 
- **How** (30 min)
  - In the DB Contxt, add some logic to our onModelCreating method to add data if there isn't anything that exists. 


## Lab Notes

- The lab today follows lecture demo code very closely. Make sure the students have the Async Inn ERD so that they can create the models in their lab.

## What might students struggle with today?

- The composite keys are always a challenge.

## Past bugs, issues or surprises...

EFCore likes to update. make sure you are up to date with the latest version.


## General Comments and Notes
