# Facilitators Guide: Data Transfer Objects (DTOs)

## Overview

Today, we will clean up the output from the API server, and make them a bit more client friendly. We will introduce the concept of DTOs to have more control over what data gets sent out and is accepted into the server.

### How does this topic fit?

**Where we've been**:
In the previous classes we've built out a full API server using the repository pattern for DB Services, Dependency Injection, Customized Routing, Navigation Properties and LINQ Queries.

**What are we focusing on today**:
Today, we'll be customizing the data that comes in and out of the server through DTOs, enforcing the idea of 2-way data contracts

**Where we're headed**:
In our next class, we'll be leveling up our API server with Tests, Swagger Documentation, and deploying it to Azure, before we dig into user authentication

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to have the students refactor their current codebase to customize and create DTOs

## Preparation

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Review lab 14's routing and Dependency Injection
  - DI Lifecycle
  - Route Handling Lifecycle
  - The role of services
  - Models & Navigation Properties
  - Database Migrations

### DTOs

- **Why** (5 min)
  - For Security, we don't want to expose our database entities (names, fields) to the outside world.
  - The data coming into the server will not always match 1:1 with the entities we created.
  - We want the ability to customize the incoming and outgoing data.
  - We call this "Adaptation"
- **What** (10 min)
  - DTO = Data Transfer Objects.
  - These are custom objects that contain data that are sent and received from the server.
  - This helps us control what routes get what data with minimal restrictions.
- **How** (30 min)
  - Build out a class and have it hold all of hte properties for the DTO.
  - Make the return type, and the parameter of the action/route be the designated DTO.
- **Experimentation and Discovery Ideas**
  - Create different DTOs
  - Customize the data that is shown on an API response and make them more readable for the client.

## Lab Notes
- A lot of refactoring

## What might students struggle with today?
- Concept of what a DTO is
- Wiring and re-wiring

## Past bugs, issues or surprises...


## General Comments and Notes

Remind students that the more they re-wire things, the more they'll start to recognize where things belong, and how to find the things they need.
