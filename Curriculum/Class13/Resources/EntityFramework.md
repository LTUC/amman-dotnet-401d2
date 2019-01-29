# Lecture 13: Intro to Entity Framework


### Three Take-a-ways
1. What is the purpose of Entity Framework
2. What is the purpose of DbContext
3. What is a Code First Migration


## Review MVC Lifecycle


![Image of MVC Lifecycle]()

// Explanation

// Scaffold out MVC app from empty.

// Hold off on adding Models. 

#### Demo
1. Scaffold out an empty MVC Site with a Home controller (like on day 11)
2. Look at the Schema
3. Convert the entity of each table to Model classes
4. Add Navigation properties (talk about the connection of the two)

## Entity Framework
1. What is Entity Framework?
2. Why do we use it? 

### Adding a Database
1. Create a DbContext


### Implementation
1. Review the Schema and it's relationships
1. Introduce the concept of making those models the database tables. 
	- "Imaging the ability to have the entity model convert itself to a database table?"
2. Create the Models in the MVC App that match the DBSchema
2. Add DbSets/Tables from models in DbContext


### Code First Migrations
1. Migrations
2. Package Manager console commands to add new migrations and update databases.
3. Add DbContext to Startup.cs
	- Run Migrations and View Database tables in local dev db server

### Database Keys
4. Update the models to add the navigation properties that reflected in the schema 
	- "Composite Keys"
	- "Force" a Primary Key


### Composite Keys in database
- Add the composite key requirements to the `OnModelCreating` method in the DbContext


### Shadow Properties