# Facilitators Guide: Introduction to MVC

## Overview

First day of web development! This is the first day the students get to learn about web development. You will draw out for them the MVC request flow and create for them a full stack application utilizing the MVC pattern.

### How does this topic fit?

**Where we've been**:
In the previous classes we've specifically worked with only the C# language. 

**What are we focusing on today**:
Today, we'll be doing ...

**Where we're headed**:
Next class will focus on ...

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are ... (use this pull quote to call out any instructor facing notes/outcomes that need toe highlighted)

## Preparation

- Review the day's readings. Included in the readings is a video introduction to .NET Core.
- Review MVC and how the components work with each other in ASP.NET.
- Upload to the GitHub class repository the appropriate .csv file for whichever lab you are choosing to use for this day.
- Upload to the MVCSetup.md file to the `Resources` folder in your GH class repository. 
- Look at previous course student submissions for insight as to what you might see in code review.
- Practice [the demo](../demo/demo-name) on the construction of MVC.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Skip code review today, as there shouldn't be a lab to review. You will likely need the entire lecture time to teach today's content. 

### Intro to MVC

- **Why** (5 min)
  - Separation of Concerns. This means that we need the ability to separate out each component of an application so that they can be independently worked on. MVC allows us to separate out each component and make changes without the fear of affecting others in the process.  
- **What** (10 min)
  - MVC is an architectural pattern that allows us to separate out the presentation layer from the service layer of a web application. 
  - Draw out the MVC web request diagram for the students. Include the request flow for MVC Core specifically. 
- **How** (30 min)
  - Build out the demo application from scratch.
    - Start with an empty web app
    - Add middleware and routing
    - Create Controllers
      - Introduce actions
      - Introduce Model Binding and URL Query
    - Create View
      - Discuss the folder structure of the View from the controller
      - Introduce Razor Syntax
    - Create a model
      - Use the model in the controller and send it to the view. 
- **Experimentation and Discovery Ideas**
  - Continually build your project and show errors as you expect them to showcase possible situations the students may come across
  - Make the structure of your demo very similar to the lab requirements. This lab is about getting exposure to MVC and building their first MVC site. 
  - Deploy the app to Azure!

## Lab Notes

- The lab requires that they use System.IO for reading in a CSV file. This may be a good thing to review in Code Review in class 12. 
- The students will depend heavily on the resources provided during lecture. This is a heavy day, so be clear on where to find the resources and the structure of MVC. 
- Expect many questions on the request flow. 

## What might students struggle with today?

- Request flow of MVC. The students will struggle with the models in the views and how to utilize them. 

- Make sure students have the proper SDK installed for .NET Core

## Past bugs, issues or surprises...

ASP.NET Core MVC is always changing. stay up to date with any recent releases. 

## General Comments and Notes

N/A