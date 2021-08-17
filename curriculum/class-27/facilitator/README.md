# Facilitators Guide:  MVC Forms

## Overview

Proper execution of forms, tying them to data models and handling errors ... getting forms right is the key to CRUD!

### How does this topic fit?

**Where we've been**:
In the previous class students created an Admin Dashboard scaffold, mapping out an administrator's various workflows

**What are we focusing on today**:
Today, we'll be getting into the rendering of Forms that are bound to our data models so that we can easily save data to the DB as well as to provide a solid user experience

**Where we're headed**:
We will be incorporating Identity and Cookies so that we can have "protected" routes with Authorization as well as perhaps some conditional logic in the views to hide/show elements based on role.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to be familiar with CRUD forms programming patterns, POSTing data, and general user workflow.

## Preparation

- Practice the demo
- Be prepared to discuss error handling

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

It's highly likely that students did not seek out the instructional team for follow up questions on the lab requirements. It was vague on purpose, to force them to ask deeper questions.

Use code review to reinforce that process, and then to help them unwind.

- The goal for this module is to be very self directed in terms of application wiring.
- Try to unblock students, but don't provide answers

### TOPIC 1: Forms

- **Why** (5 min)
  - Forms are the #1 method for transmitting data from the Client to the Server
    - Query Strings (exposed on the URL -- GET requests)
    - Cookies (part of the header, sent on all requests)
  - Cookie and Query strings are nice, but the are limited in size and scope
- **What** (10 min)
  - Forms take direct user input and place it (usually in Query String format) in the **body** of a request
  - Data in the body can be of unlimited size
  - Data is always a string
  - Students could use a simple reminder of the 3 main ways to transmit data
    - Wiring up a form during demo and looking at the body, the format of the body and how the server receives it
- **How** (30 min)
  - C# Forms can really be done in 2 major ways
    1. Loosely Typed
       - These are simply forms, with an action that matches a controller method
       - The controller method takes in, as params, each form field (by name, exactly matched)
       - The controller then uses the `ViewData` or `ViewBag` built-in models to transmit data back to the view
       - This is quick and dirty, and decidedly not OOP. But sometimes, you need to operate that way
    1. Strongly Typed
       - Your form matches fields with a data model (by name, exactly)
       - Your controller method then can take as a param, the Data Model type
       - This way, you can then communicate using the data model (or a view model) between controller and view
       - Much more robust and there's an inherent "trust" between the 2 aspects of the application
- **Experimentation and Discovery Ideas**
  - While the general wiring of forms in .NET MVC is relatively simple, take your time to build it up
    - Work from loose forms to strong
    - Add in field level binding so that you can show how "magically" the framework can tie real model data to a field
      - This is where our tag-helpers really help us!

## Lab Notes

- Students today will be using forms in MVC to add the ability to perform CRUD operations on their CMS
- Note that your demo does NOT show them how to do that, only how to wire up a form to a data model
- They will need to "figure out" how to get their DbContext re-wired as they did in Async Inn, and make their controller methods that accept the form submissions call on their Service to save the data.

## What might students struggle with today?

## Past bugs, issues or surprises...

## General Comments and Notes
