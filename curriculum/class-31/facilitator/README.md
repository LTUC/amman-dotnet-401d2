# Facilitators Guide: Razor Pages

## Overview

Razor Pages is a newer, simplified web application programming model. It removes much of the ceremony of ASP.NET MVC by adopting a file-based routing approach. This presents a departure from MVC, which we'll be using for this sprint to build out the customer facing pages of our stores.

### How does this topic fit?

**Where we've been**:
At this point, the students used MVC to build a complete CMS, with full CRUD to manage the categories and inventory for an online store. They should have Identity services as well as a full DbContext with data wired up.

**What are we focusing on today**:
Today, we'll be shifting gears and looking at the consumer side of the site, starting with the basics of Razor Pages as a view pattern.

**Where we're headed**:
Next class will focus on Razor Components, which will have students wiring up small, reusable bits of view state into the application

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to gain an understanding of the Razor Pages rendering cycle

## Preparation

- Practice the demo
- Work on a good list of pros/cons and differentiators between MVC and Razor

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### TOPIC 1: Razor Pages

- **Why** (5 min)
  - Simplifies the data flow by "removing" the middleman
  - Create Single Page Apps with ease and with control
    - SPA vs Static
      - Yes, MVC is static even though the data is dynamic
- **What** (10 min)
  - More of an MVVM Model than MVC
  - Model - View - View Model
  - New to .NET Core (previous version)
  - MS is trying to make this the new standard
    - There's still some "Best Practices" being fought over
  - A "Razor Page" is a single page
    - Contains the view and the model and the logic
    - This really helps with keeing things Single Responsibilty and asking questions like "What controller should this belong to?"
- **How** (30 min)
  - `viewname.cshtml`
    - Still the view, still has a @model
  - `viewname.cshtml.cs`
    - This is the Model and the Controller combined into one
    - Still has DI, still can call services, etc.
    - But this is "FOR" a single page
- **Experimentation and Discovery Ideas**
  - Thing

## Lab Notes

## What might students struggle with today?

## Past bugs, issues or surprises...

## General Comments and Notes
