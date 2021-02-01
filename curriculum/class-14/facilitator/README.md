# Facilitators Guide: Navigation Properties and Routing

## Overview

Having standalone core tables is a good start to an application, but the real depth comes when we can join tables together and combine their information using foreign keys. Entity Framework has some excellent tooling that allows us to do this.

Today, we'll be using "Navigation" properties along with some custom routing and secondary lookups to "hook" related tables together in our ERD

### How does this topic fit?

**Where we've been**:
Studends will have build and then subsequently refactored a REST API with basic models using the Repository Pattern, along with Dependency Injection

**What are we focusing on today**:
Today, we will be making connections between the Tables (Models) using Navigation properties, creating the "Join" tables that connect the entities in our ERD

**Where we're headed**:
In future classes, we will be looking at DTOs and adding fine tuning to our API output.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are ... (use this pull quote to call out any instructor facing notes/outcomes that need toe highlighted)

## Preparation

- Make sure your Demo is a fully working API, with Models, Controllers, and uses the Repository Pattern to implement the model interfaces.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Ensure that everyone has their routes refactored, wired, and properly working

### Navigation Properties and Routing

- **Why** (5 min)
  - We have an amazing ERD with perfectly described relationships
  - We have classes, and repositories and controllers
  - But we don't have the connections between made yet
    - (the "lines" between the entities in the ERD)
- **What** (10 min)
  - We'll need to do some wiring in our Services and controllers to connect the tables
  - Navigation Properties
    - Live on the model
    - References to the tables we are joined to
  - Additional queries on gets
    - When we get a student, we can also look into the enrollments and then do a subsequent query on the courses table to get that data as well.
  - We may need special routing params to make our routes actionable
    - i.e. GET `/api/students/{id}/{course}`
- **How** (30 min)
- **Experimentation and Discovery Ideas**

## Lab Notes

## What might students struggle with today?

## Past bugs, issues or surprises...

## General Comments and Notes
