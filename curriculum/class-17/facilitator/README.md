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

Todays demo will be done workshop style, so ensure that the students have access to the starter code in the class repository

You'll find this in the `demo` folder under `workshop-starter-code`

As you will do, have the students create a new repository and copy the demo files there, as you'll be deploying from this repo to Azure

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Review lab 14's routing and Dependency Injection

### TESTING
- **Why** (5 minutes)
  - We need to make sure our code is reliable and behaves as we expect.
- **What** (10 minutes)
  - Testing allows us to make sure that our methods within our service work exactly as we expect.
- **How** (30 minutes)
  - Create a new Xunit project, similar to how you did it before with your console apps.
  - Show how to explicitly test the service for the CRUD calls.

### SWAGGER
- **Why** (5 minutes)
  - Documentation is an imperative
  - Living Documentation is actually useful
  - Not having to write it? Amazing
- **What** (10 minutes)
  - Demonstrate what "Swagger" is by touring the swagger website and ecosystem
- **How** (30 minutes)
  - Add Swagger to the school application, per the demo

### DEPLOYMENT (AZURE)
- **Why**
  - we need our app to be globally accessible. to do this, we use Azure to host our database, and our server side application.
- **What**
  - What is the cloud and how does it really work?
  - Great time to talk scale, huge networking, etc
- **How**
  - In addition to "right click publish", we also need to deploy our database.

## Lab Notes
- A lot of refactoring

## What might students struggle with today?
- Concept of what a DTO is

## Past bugs, issues or surprises...


## General Comments and Notes

N/A
