# Lecture 12: Relational Databases & Schema

### Three Take-a-ways
1. What is the purpose of a schema
2. What types of relationships are there?
3. Three different types of keys that exist in a relational database...

## What is a Database

### Different Kinds of Databases
	1. Relational
		- SQL Server
	2. Non-Relational
		- SQLLite

### Relational vs Non-Relational

1. Relational
	- Relational databases are databases where each table can hold a relationship with another. This is usually done through some sort of unique identifier that can require a row of each table to stay unique even after the many different transactions that process through. This allows for separation of concerns within a database and ability to manipulate individual parts of a grouped together information

2. Non-Relational
	- Non Realtional databases don't depend on relationships or keys between tables. NoSQL is an example, and all the information is stored in one "document" that makes it potentially easier to group together information without having to join tables. 
	Examples: Big Data, and Real Time Applications

## Representation
We can represent a relational database through a database schema. 
	
### Database Schema

It may be helpful to pull up this article and show the example DB Schema [HERE](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-2.0)

### Relations
	1. 1:1
	2. Many:Many
	3. 1:Many
	4. Many:1

### Keys
	1. Primary Keys
	2. Foreign Keys
	3. Composite Keys (New!)


### Dissect a Schema

### Many-to-Many in a Schema

1. Join Tables
	- With Payload
	- Pure Join Tables (w/o Payload)
2. Composite keys

## Demo

This week, we will be building out a student enrollment system in class. 
Here is our problem domain:

You have been tasked to create a system for a new coding school in your neighborhood. While gathering requirements, you were able to learn how the school plans on managing their enrollment. Here is what you gathered

#### Student
The coding school will gather information from each student. Their system requires the student's first name, last name and age. 

#### Course
Each course that the coding school will offer has a Name, specific course code, and the price that the course will cost. 
You learned that each course **must** have a course code, and that course code must be unique to each course. 

#### Misc information
Once a student has completed a course, their final grade and if they passed is captured in a single transcript. It is possible for a student to take multiple course and therefore have multiple transcripts. It is also safe to say that once a course is completed, the system will generate a transcript for every student that was present in the course. 

### Prompt
Using the information you received above, create a database schema that will accurately represent the data that will be held and accessed for this student enrollment system for the school. 

### Create a Database Schema

Together, In class, create a database schema given a problem domain


## Resources:
- [Relational vs NonRelational](https://www.jamesserra.com/archive/2015/08/relational-databases-vs-non-relational-databases/)
