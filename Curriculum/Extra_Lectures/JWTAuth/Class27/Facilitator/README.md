# Facilitators Guide: Authentication

## Overview

Today, the students will learn how to create a register and login action to allow for Authentication within Identity.

### How does this topic fit?

**Where we've been**:
Yesterday, we set up our project to allow for Identity by creating a database specifically to hold our user data and registered the Identity API to be used within the app.

**What are we focusing on today**:
Today, we'll be looking at adding the ability to register users as well as log them in. This will introduce the Claims and the usage of JWT tokens.

**Where we're headed**:
Next class will authenticate the JWT Tokens so that we can enable permissions and secuirty in our site.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to show the students how the authorization actually works and to introduce JWT tokens

## Preparation

- Read up on the MSFT docs of identity.

- Practice [the demo](../demo/demo-name) on whatever.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review
- Code review should consist of reviewing the additional database and identity registration. Re-explain and show the students the usage and reasoning behind it. 

### Authorization

- **Why** (5 min)
  - We need to have the ability to tell who a user is safely and securely. Why individuals use the app, they are expecting their information to be secure and only authorized individuals can see their data. We want to enable this security so that the information contained within our site is safe. 
- **What** (10 min)
  - Authorization and Authentication is the act of validating that a person says who they say they are. This can be done through verifying they know the password to the account, or that they have the proper crendentials to access.
- **How** (30 min)
  - Create a new controller called "Account" and setup a post register action. Bring in the required libraries of `UserManager` and `SignInManager`. 
  - Create a new action for logging a user in
- **Experimentation and Discovery Ideas**
  - Keep Iterating on the buildout of the app. Show them as many error message as possible. 

### JWT Tokens

- **Why** (5 min)
  - 
- **What** (10 min)
  - 
- **How** (30 min)
  -  
  - Create a new action for logging a user in
- **Experimentation and Discovery Ideas**
  - Keep Iterating on the buildout of the app. Show them as many error message as possible. 

## Lab Notes

- Today, they will be building off of their prior lab and add a register and login action to it. they will also enable the use of JWT tokens and send back a JWT token to the frontend applicaiton within their API

## What might students struggle with today?

- Remembering everything from before project week.

## Past bugs, issues or surprises...
N/A

## General Comments and Notes
N/A
