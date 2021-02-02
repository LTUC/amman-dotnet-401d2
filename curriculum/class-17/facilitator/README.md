# Facilitators Guide: Testing, Swagger, Deployment

## Overview

Today, we will clean up the output from the API server, and make them a bit more client friendly. We will introduce the concept of DTOs to have more control over what data gets sent out and is accepted into the server.

### How does this topic fit?

**Where we've been**:
In the previous classes we've build out the API server and customized the routing

**What are we focusing on today**:
Today, we'll be customizing the data that comes in and out of the server through DTOs

**Where we're headed**:
We will be soon adding authentication and authorization to our app to finalize the api server.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to have the students refactor their current codebase to customize and create DTOs

## Preparation

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Review lab 14's routing and Dependency Injection

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
  - Make the return type and the parameter of the action/route be the designated DTO.
- **Experimentation and Discovery Ideas**
  - Create different DTOs
  - Customize the data that is shown on an API rseponse and make them more readable for the client.

### TESTING
- **Why** (5 minutes)
  - We need to make sure our code is reliable and behaves as we expect.
- **What** (10 minutes)
  - Testing allows us to make sure that our methods within our service work exactly as we expect.
- **How** (30 minutes)
  - Create a new Xunit project, similar to how you did it before with your console apps. Show how to explicietly test the service for the CRUD calls.

3. **Deployment to Azure**
- **Why**
  - we need our app to be globally accessible. to do this, we use Azure to host our database, and our server side application.
- **What**
  -
- **How**
  - In addition to "right click publish", we also need to deploy our database. Refer to the "deploy cheat sheet" doc on directions. (Resources/deployment), share this doc with the students

## Lab Notes
- A lot of refactoring

## What might students struggle with today?
- Concept of what a DTO is

## Past bugs, issues or surprises...


## General Comments and Notes

N/A
