# Facilitators Guide: Unit Testing

## Overview

Today consists of learning how to write unit tests using XUnit. The students will learn how to think and plan out their code before the actual implementation.


### How does this topic fit?

**Where we've been**:
In the previous class we were introduced to C# and learned about exception handling. 

**What are we focusing on today**:
Today, we'll be going one step further and implementing tests using TDD and XUnit. 

**Where we're headed**:
Next class will focus on file manipulation with Streams.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to get students used to the new workflow of writing tests before they write code.

## Preparation

- Read up on ...
- Get ready for questions about why unit testing is important.
- Look at previous course student submissions for insight as to what you might see in code review.
- Practice [the demo](../demo/demo-name) on whatever.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review ( 45 minutes)

- Review the prior day's lab. Dive into each of the methods and syntax to get the students comfortable with C#. 

### Comments & ReadMes (15 minutes)

- **Why** (5 min)
  - Developers need to be able to read code written by others. It helps communicate the intention of the codebase to anyone else working on the team. 
  - ReadMes are important because they help communicate the problem domain and use of a library or repository. 
- **What** (10 min)
  - Summary Comments live within the code base to help build documentation
  - ReadMes live at the root level of projects
- **How** (30 min)
  - Summary Comments can be auto created by adding `///` above a method where the template will automatically generate. 
  - README template are located in the Resources folder

### Unit Test [45 minutes]

- **Why** (5 min)
  - We need to make sure that new code that we write will work with current code base. Nothing is more stressful then finding that you introduced new bugs into your system. 
- **What** (10 min)
  - Unit testing is the act of writing tests for the code you wrote to ensure no new issues are introduced. It is a way to validate that your code functions properly within the system.
- **How** (30 min)
  - XUnit is a popular tool used for testing within .NET Core applications. Build a new project, bring in the XUnt dependency. Start writing tests. Refer to the demo for code.
  - Code out "FizzBuzz" using the TDD approach

- **Experimentation and Discovery Ideas**
  - Show students the full "red-green-refactor" lifecycle. 

### In-Class Exercise (45 minutes)
	- Have the students build out a calculator using TDD 
	- Have them plan before they code what the functionality of a single feature should be
		1. Write a test
		2. Code it out
		3. Run the test
		4. Repeat until feature is working as expected.
	- Remember to tell them NOT TO TEST METHODS THAT INCLUDE CONSOLE.READLINES. We do not test those, so they have to think about how the program will be laid out.

## Lab Notes

- They will be creating an ATM machine using test driven development. Encourage the students to follow the TDD approach, and not write the tests "after the fact", they will more than likely not have the right structure, making it harder to test.

## What might students struggle with today?

- Writing the tsts before the code.

## Past bugs, issues or surprises...
1. Make sure your PROGRAM class is public so that the Xunit can find it.

## General Comments and Notes
