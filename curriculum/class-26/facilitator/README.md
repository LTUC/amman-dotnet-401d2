# Facilitators Guide: Intro to MVC

## Overview

This is the kickoff to the E-Commerce Project. There is quite a bit of setup that is required for this second half. Review the prep section below to confirm you are ready.

1. Be sure that you are comfortable with Azure Dev Ops (ADO)
1. Divide the class into teams/pairs of 2
1. Each day, they will work together and build towards a larger project.

### How does this topic fit?

**Where we've been**:
To this point, students have built a full REST API, using SQL Server backed models with Entity Framework.

**What are we focusing on today**:
Today, we'll be starting a full stack application using MVC, deployed through Azure Dev Ops

**Where we're headed**:
Next class will focus on the UI, using Razor Pages

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are ... (use this pull quote to call out any instructor facing notes/outcomes that need toe highlighted)

## Preparation

Here is checklist of items that you should complete before the start of lecture:

1. Become familiar with Azure Dev Ops project management tool & the VS Team Explorer Extension
    - [Azure Dev Ops](https://dev.azure.com/)
    - [Team Explorer Reference](https://docs.microsoft.com/en-us/azure/devops/user-guide/work-team-explorer?view=azure-devops)
1. Refer to the [Cheat Sheet](../../projects/E-Commerce/azure-devops-cheatsheet.md) as steps on how to complete some of the basic tasks within ADO. Walk through the creation of a repo and with some basic tasks. You will do these steps in lecture as well.
1. Be comfortable with the demo code and all of the different moving components

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Review 1st Half Concepts
  - DI
  - Repository
  - MVC Roles
  - ERDs and UML

### TOPIC: E-commerce Project

- **Why** (5 min)
  - In a multi-module project, students will need to know the progressions
  - Expectations setting, group work, toolset, etc.
- **What** (10 min)
  - Introduce the ECom project by reviewing each week's expectations (30min)
  - Peer reviews at the end of each sprint
  - Everyone is responsible for their own submission (no "group" submissions)
- **How** (30 min)
  - Show an example of Day 1's (and 2's if they need to see the "guidance" section) user stories and how they are split up
  - Show the grading rubric for sprint 1

### TOPIC: MVC

- **Why** (5 min)
  - Understanding the MVC Design Pattern is a cornerstone of creating scalable full-stack applications
- **What** (10 min)
  - Thing
- **How** (30 min)
  - Lab will create a basic MVC app and use the "ceareal.csv" file as day's data set.
  - They should build out a Products page using MVC controller views from the dataset.
- **Experimentation and Discovery Ideas**
  - Note that the next day, we will "Swap Out" the data source from  CSV to SQL using the Repository Pattern!

### TOPIC: ADO

- **Why** (5 min)
  - Thing
- **What** (10 min)
  - Thing
- **How** (30 min)
  - Introduce Azure Dev OPS project management tool & VS extension
  - Walk through the creation of a repo and cloning it down to your Visual Studio.
  - Create a basic scaffolded MVC app w/ a database in class following the Azure Dev Ops work flow
    - The demo provided is using User Secrets, so don't forget to include the User secrets file and Connection String file!
- **Experimentation and Discovery Ideas**
  - Thing

### Lecture

1. Introduce MVC
    - Review what MVC stands for. Use the Resources of MVC, and the Diagram to assist

### LAB Prep

Have student pairs ready to be posted in Canvas. For lab, each group should be expected to:

- Create an Azure Dev Ops account
  - Only one person needs to do this. Have them invite their partner.
  - Deploy the basic app to Azure (only on one of the accounts)

## What might students struggle with today?

## Past bugs, issues or surprises...

## General Comments and Notes
