# Class 12: Relational Database and ERDs

## Overview
This is the first day that the students will dive into the "Async Inn Inventory Management" website. Do not show the students the wire frames or resources for the site just yet. Make sure they complete the ERD for this lab assignment before showing them what they will be building. 

Today primarily focuses on an introduction to databases. This should be a combination of review from 301, as well as some new content such as composite keys and join tables.

## How do I prep for today?
1. If you are unfamiliar with Databases and their relationships, a good place to start is [Here](https://www.tutorialspoint.com/dbms/index.htm)
1. Review the MSFT docs for complex data models [Here](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-2.0) 
    - Start from the Overview and work your way through the whole tutorial if you can. 
1. Review what an ERD is. The "Databases.md" located in the `Resources` folder is an outline of the lecture for that day. 
1. I recommend also reviewing the Microsoft docs of the "Complex" data model. This doc provides a good background of what the ERD should consist of. 
1. Adjust the lab assignment for the day in Canvas. This is a timed assignment. Make it open up at the beginning of lab time, and due/closed at the end of lab time (total time approx. 5 hours). You will review the solution with the students at the very beginning of Class 13. 

## Lecture

1. Code Review
   - Review the MVC lab 
   - Show the students the solution to reading in a csv file and converting it to an object
   - Review turnery operators (this may be what they needed to use in their for lab 11 when reading in data from the csv file)
1. Review data persistence
   - What is data persistence? 
   - What are databases? Why do we need them?
1. Introduce DB Context and setup in an MVC project
   - start with an empty web app and add the MVC service. No need to do an MVC route right away.
   - Create a Data folder
   - Create a class for the DbContext
   - Derive the class from `DbContext`
   - Add the constructor
   - Register the DBContext in the Startup Class
   - Add the connection string to the appsettings.json file
   - Add the migration
   - update the database
   - verify the database was created with a "Migration History" table.
1. Introduce ERDs
   - What are they?
   - Why do we need them?
   - What do relationships look like?
1. In-Class exercise to build out ERD for student enrollment demo
   - Dedicate about 20 minutes for the students to come up with their own sol

## Lab Notes

This lab will require that the students create an ERD and also create a scaffold template of their Hotel API application with an empty database. 

This ERD portion of this lab is timed and is attempt based. They should be able to read through the problem domain and come up with an ERD for the database as well as provide an explanation. You will provide and review the solution with them at the start of the next class.

## What might students struggle with today?  
Nothing major. Overall ERDs are straight forward to break down.
Adding in a DbContext to your application is mostly convention. 

## What bugs, issues, or surprises have come up in the past for this class?
Database key relationships for composite keys are brand new. Foreign and primary keys are review. 

## General comments
Spend the last 45 minutes to an hour of lecture time having the students attempt to make an ERD based off of the problem domain (located in the bottom of the `Database.md` file) and review the results.

Spend a few minutes  reviewing the requirement. Have the students group off
and attempt the ERD (20 minutes or so), and spend the last 15 having the students present their
ideas and reviewing the solution. 

Be sure to share this solution with the students, as that is what our demo for the next
few days will be tied to.

Stress to them that there is more than "one right answer", this is just one possible way.