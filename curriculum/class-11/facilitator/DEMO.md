# Demos: Introduction to Databases and ERDs

Note: Demos as they exist in the `/demo` folder are provided in their **completed** state.

This demo feels like a lecture and is a lot of the "Resource" material repeated. It's important to use this sequence to solidify the core Database and ERD concepts in an organized fashion, by building it out as an active and interactive part of lecture.

Here's an example (the solution for the in-class exercise) that you can use as inspiration for your live demo

![ERD Demo Image](../demo/erd.png)

## ERD Demo

Lead the students in an exercise that will result in a simplistic ERD that describes a problem domain of something they can easily understand, such as a blog with comments or twitter.

### Create The Database ERD

Use a tool such as https://app.diagrams.net/

#### Tables
Each "box" in an ERD represents a table in the database. With each table you want to identify it's individual properties, and it's relationship to other tables in the ERD.

#### Properties
Within each individual table, properties exist. The properties represent the characteristics of the entity you are modeling within the table. Each property traditionally is a column header. Some properties of a table may be a key that exists in another table, such as a Foreign Key, or Composite Key. Each table may also have a unique identifier called a Primary key, usually just named `Id`.

#### Keys
1. Primary Keys
  - Unique identifier for a specific table. Usually named `Id`.
  - Each row of the table will have it's own unique primary key.
1. Foreign Key
  - Unique identifier from another table.
  - Often used to join tables within a query and associate table data.
  - Naming convention is the name of the table plus the word Id. Example: BookId is a foreign key in the Library Table. In the Book table, it is simply `Id`.
1. Composite Key
  - A combination of columns that make up a unique identifier for a table
  - Composite keys usually consist of multiple foreign keys combined together.  - No Primary key needs to be included in the combination.
  - You do not necessarily need to include a primary key in a table that utilizes a composite key.


### Many-to-Many in an ERD

1. Join Tables
  - With Payload
    - Has a primary key, and additional properties
  - Pure Join Tables (w/o Payload)
    - Composite keys. No additional properties.

1. Navigation Properties
  - Link to other entities that are related to the current entity.
  - Mostly seen in 1:Many and Many:1 relationships

Together, In class, create a database ERD given a problem
domain



