# SQL

SQL 

### Relational Databases
relational databases consist of one or more tables where 
each table consists of 0 or records/rows. 

The data for each row is organized into discrete units of information, known 
as fields or columns. 

Many of the tables in a database will have relationships between them. 
The different types of relationships we can have are

1. one to one
2. one to many
3. many to one
4. many to many

the connection between tables is made by Primary Keys and Foreign Keys.

1. Foreign Key: this is a primary key from another table. 

#### Example of a one-to-many

Customers to Orders can be a great one-to-many example. 
both tables of Customers and Orders could potentially have a `CustID` field. 
this is a primary key of the Customers table and a FK of the Orders table. 

