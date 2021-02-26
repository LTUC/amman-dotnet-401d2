# Facilitators Guide: View Components

## Overview

View components are small, self-contained "sections" or "components" of a page, backed by a model and rendered using a view. They're excellent for intertwining dynamic content over many pages

### How does this topic fit?

**Where we've been**:
In the previous class, students were introduced to Razor Pages and got some experience in scaffolding out a basic web application, backed by data services

**What are we focusing on today**:
Today, we'll be adding the "View Component" concept, which will allow them to break up their site into smaller parts, where re-usability is a requirement

**Where we're headed**:
Next class will focus on integrating some 3rd party APIs as we close our the E-Commerce Project

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day is to have students confident in wiring up a single data-backed view component for use throughout their application

## Preparation

The documentation for View Components is actually pretty good. You should read the documentation in it's entirety before the lecture to get familiar with the content: [Documentation Here](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-2.1)

- Practice the demo.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Notes here

### TOPIC 1: View Components

- **Why** (5 min)
  - Re-Usability of components, especially those backed by data
    - Login/Logout in a header or as a panel
    - Shopping cart counter, or a full "mini-cart"
    - "Welcome User" messages
    - Ads
  - Essentially, if there is a section of the page that requires rendering and logic  manipulation, then a VC is a good choice.
  - View Components solve the issue of having reusable sections on our pages that require data logic.
    - This allows us to separate out the reusable code into it's own file and just call the component wherever it is needed

- **What** (10 min)
  - Razor View Components are often referred to as "Mini-Controllers"
  - View Components can process logic and make calls to a database, external APIs
  - They are comprised of:
    - A Component, which implements a specific interface
    - A view which renders the data for that component
  - These differ from fragments, in that fragments are purely markup, whereas views have logic and data
- **How** (30 min)
  - Thing
- **Experimentation and Discovery Ideas**
  - Thing

## Lab Notes

## What might students struggle with today?

## Past bugs, issues or surprises...

## General Comments and Notes
