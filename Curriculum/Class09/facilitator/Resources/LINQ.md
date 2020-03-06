# Class 09: LINQ

## Learning Objectives
1. Students will be able to successfully write LINQ queries against a collection to extract data.
1. Students will understand the use of a Lambda statement and how to join them with LINQ queries.
 
## Lecture Outline
1. Review Collections
  - Create a collection
  - Add data to the collection
  - iterate through the collection
2. What is an easier way to iterate through a collection?

### What Is LINQ?
- Language Integrated Query

- Imperative vs Declarative
   - What is Imperative
      - Foreach Loop
   - What is Declarative
      - LINQ statement

   - What is a 'query'?
   - A query is an expression that, when enumerated, transforms sequences with query operators. 
   - The standard query operators are implemented as *extension methods*, so we can call 'Where' directly onto names

ALL LINQ query operations consist of three distinct actions:
1. Obtain the data source
1. Create the query
1. Execute the query


### Demo
Follow demo for next part of lecture. Each method in the demo breaks down different ways to use LINQ.


### Deferred Execution
The query variable that holds the query command doesn't actually execute until you iterate over it. An example would be a foreach loop. 

The variable does not hold the result, only the command. So you can keep iterating over it and potentially get different answers. 
