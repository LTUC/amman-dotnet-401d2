# Class 08: LINQ

## Learning Objectives
1. Students will be able to successfully write LINQ queries against a collection to extract data.
1. Students will understand the use of a Lambda statement and how to join them with LINQ queries.
 
## Lecture Outline
- Review Collections
  - Create a collection
  - Add data to the collection
  - iterate through the collection

1. What is an easier way to iterate through a collection?

### What Is LINQ?
- Language Integrated Query

1. Imperative vs Declarative
   1. What is Imperative
      1. Foreach Loop
   1. What is Declarative
      1. LINQ statement

   1. What is a 'query'?
   - A query is an expression that, when enumerated, transforms sequences with query operators. 
   - The standard query operators are implemented as *extension methods*, so we can call 'Where' directly onto names

ALL Linq query operations consist of three distinct actions:
1. Obtain the data source
2. Create the query
3. Execute the query


### Demo
Follow demo for next part of lecture. Each method in the demo breakds down different ways to use LINQ.


### Deferred Execution
the query variable that holds the query command doesn't actually execute until you iterate over it. An example would be a foreach loop. 

The variable does not hold the result, only the command. So you can keep iterating over it and potentially get different answers. 
