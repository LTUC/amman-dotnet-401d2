# Class 09: LINQ & Delegates

## Overview

### How does this topic fit?

**Where we've been**:

**What are we focusing on today**:
Building off of collections from yesterday. We will/can use `IEnumerable<T>` today for our result of our queries. May not hurt to re-review.

**Where we're headed**:

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

## Preparation

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](./LECTURE-EXAMPLE.md) notes.

### Warm Up

### Code Review

Time Box to ~ :30 minutes

### TOPIC 1: Delegates

- **Why** (5 min)
  - Send methods as params to other methods
  - Allows us to pass functionality around
    - Here ... you do your work, and call my function when you're done
- **What** (10 min)
  - These are very much like JS' ability to send function references as params
- **How** (30 min)
  - We declare them outside of classes
  - Make a function that matches the delegate's signature exactly
    - Return Type, Args

- **Experimentation and Discovery Ideas**

  -

### TOPIC 2: LINQ

- **Why** (5 min)
  - Not all data comes directly from a database
  - LINQ allows us to query in-memory data, json, xml, arrays, collections
- **What** (10 min)
  - **L**anguage **In**tegrated **Q**uery
  - Imperative
    - It's like a recipe (follow the instructions, paint by number)
    - "Go to the store. Aisle 3. 3rd Shelf. 8oz can of sauce"
  - Declarative
    - General Instruction
      - "Go and get me some sauce"
    - LINQ Statements
  - Queries
    - Request that returns data
    - Question we ask of a data source
    - Filter
    - Expression
    - Transforms data into something usable
    - Not telling anything HOW to get data, just what data you want
- **How** (30 min)
  - LINQ Query has 3 steps
    - Obtain the data source
    - Create the query
    - Execute the query
    - (use the resulting data)
  - Direct query
    - SQL Like Syntax
  - Method based queries, which can be chained
    - Using Lambdas
      - `persons.Select( item => { item.name, item.addr } )`
  - Lazy Loading
    - "Deferred Execution"
    - Items that you're querying against are not loaded until they are needed
    - Distributed performance
    - No wasted networking, etc
    - Example: `foreach()` will fetch data as needed for the query
  - Eager Loading
    - Front-Load your data
    - Query Methods like `.Take()` do this, so that they can create the dataset

- **Experimentation and Discovery Ideas**

  -

## Lab Notes

## What might students struggle with today?

Delegates. It can be a lot. Delegates make more sense when we start using LINQ method calls.

## Past bugs, issues or surprises...

## General Comments and Notes

Delegates really jump our complexity level. Students will understand what they are for right away...
