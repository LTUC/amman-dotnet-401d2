# Facilitators Guide:  Authentication, Authorization, Cookies

## Overview

We'll be introducing students to 2 major web app features in this class: Cookies as a general means of local storage and Login/Authentication

### How does this topic fit?

**Where we've been**:
In the previous class students created an Admin Dashboard scaffold, mapping out an administrator's various workflows.

**What are we focusing on today**:
Today, we'll be adding Login and Authentication to the system, using cookies to maintain our login status between sessions, using Identity

**Where we're headed**:

Next class will have the students connecting to Azure Blog Storage to upload images of their products in the store. This will be the first time dealing with a true 3rd party API

Additionally, the students will be completing the wiring of all CRUD operations for the admin dashboard, behind the authentication wall.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are a core understanding of how cookies work in general, and specifically how Identity uses them in a .net web application

## Preparation

- Practice the demo
- Be prepared to discuss cookie security and issues

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

It's highly likely that students did not seek out the instructional team for follow up questions on the lab requirements. It was vague on purpose, to force them to ask deeper questions.

Use code review to reinforce that process, and then to help them unwind.

- The goal for this module is to be very self directed in terms of application wiring.
- Try to unblock students, but don't provide answers

### TOPIC 1: Cookies

- **Why** (5 min)
  - We often have a need to persist data between sessions
  - That data should be easily shared between browser and server
- **What** (10 min)
  - Local storage is a programmatic key/value pair of data in the browser
  - Cookies are also a programmatic key/value pair of data in the browser
  - The differences are:
    - The server can "Set" a cookie on any response
    - The client (browser) will send back it's cookies on every request
  - There are security concerns
    - What is safe to store?
    - Who can see, read, access cookies?
    - We can use session ids instead of data
- **How** (30 min)
  - The demo will have you set, read, and display cookie data in an MVC App
- **Experimentation and Discovery Ideas**
  - Work socratically with the students to devise a session cookie system
    - They don't have to implement it, but knowing it works is great for interviews

### TOPIC 2: Authentication via Identity

- **Why** (5 min)
  - While we can manually set and retrieve login cookies and do this manually...
  - .Net MVC + Identity wires this in for us and allows us to "just work"
- **What** (10 min)
  - 95% of the implementation is the same as with Bearer Auth
  - In fact, we can re-implement Bearer Auth with manual cookies if we choose
  - However, Using `SignInManager` to validate our users an set the cookie is a breeze
  - ... and it works with our Authorization (RBAC) system natively
- **How** (30 min)
  - Mob program with the students the core authentication/Identity pieces
    - Treat this as a review
  - Once built, add in the MVC forms and pages to do this in the browser
- **Experimentation and Discovery Ideas**
  - What must be done to "Log Out" a user?
  - How can we transmit our login status to the Page Layout?

## Lab Notes

- Demo will give them 90% of what they need to get Authentication working.
- Ensure that their wiring is very tight, and that they're writing tests

## What might students struggle with today?

## Past bugs, issues or surprises...

## General Comments and Notes
