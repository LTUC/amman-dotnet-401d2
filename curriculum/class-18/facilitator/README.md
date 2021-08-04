# Facilitators Guide: Identity

## Overview

Identity is the ability to add Authentication and Authorization to your web application. This includes registrations, logins, restricted access to specific members, and authentication through Facebook, Google, Twitter, etc...

ASP.NET Core Identity was created to help with the security and management of users. It provides this abstraction layer between the application and the users/role data. We can use the API in it's entirety, or just bits and pieces as we need (such as the salting/hashing by itself) or email services. There is a lot of flexibility within ASP.NET Core Identity. We have the ability to take or leave whatever we want. Identity combines well with EFCore and SQL Server.

### How does this topic fit?

**Where we've been**:
In the previous classes, we've covered all facets of API creation, Entity framework, DTOs

**What are we focusing on today**:
Today, we'll be adding the ability to register and login users into the database used by our API

**Where we're headed**:
Next class will focus on authenticating our routs, by restricting access to the data unless you have a valid login token (JWT)

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to understand the Register/Login workflow and gain more experience with controllers, services, DI and DTOs. Register/Login is an important design concept that allows us to focus on .net fundamentals with an interesting problem domain

## Preparation

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

### Identity

- **Why** (5 min)
  - Not everything is for everybody
  - Most applications have restricted information for the users
    - Some is their private information (profile, balances)
    - Some is just behind a paywall or login wall (access to your purchased ebooks)
- **What** (10 min)
  - Authentication: the process of determining _who you are_
  - Authorization:  The ability to tell a user **what they are allowed to do**
  - Microsoft Identity is a tool set used primarily for user management, which we use to implement Authentication
    - Security and manipulation of users within the application.
  - Within Identity, we can restrict access to specific parts of the site through policies, assign specific roles to users, and allow for 3rd party authentication using OAUTH.
- **How** (30 min)
  - Once we have Identity installed and configured, we will build out the Registration and Authentication processes
  - Registration
    - Create a user account
    - Obey username/password rules
    - Report any errors
    - Use a DTO (inbound and outbound) to ensure security of the data
  - Authentication
    - Use a DTO (inbound) to accept a username and password
    - Use Identity's built-in password hashing to validate a user
- **Experimentation and Discovery Ideas**
  - How do we test this?

## Lab Notes

- This is very much an "Implement the exact demo" type of lab.
- Encourage the students to write lots of summary docs an have their readme really explain the process

## What might students struggle with today?

- There's a lot of wiring that goes into getting Identity to function

## Past bugs, issues or surprises...

## General Comments and Notes
