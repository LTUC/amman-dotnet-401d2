# Facilitators Guide: Intro to C# / Exception Handling

## Overview

This is the first class of the course! The assumption is that the prework was completed and you are ready to dive into the usage of the language. 

### How does this topic fit?

**Where we've been**:
Pre-work included initial exposure to the language. They all should have successfully created C# console applications with all the basic fundamentals.

**What are we focusing on today**:
Today, we will we learning about Exception Handling. When working with user input, there is a lot of opportunity for errors to occur. Today, we will discuss how to identify, plan, and handle those errors through exception handling. 

**Where we're headed**:
Next class we will introduce the contents of test driven development with unit tests. 

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to continue to practice the C# language and how to create functional console applications. While exception handling is important, use this day to get students comfortable with the environment.

## Preparation

- Read the daily posted readings
- Get ready for questions about the prework. 
- Practice [the demo](../../DemoCode).
- [Great C# reference](https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework) 
1. [Types]("../Resources/Types.md") 

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- No code review. Spend this time reviewing the basics of Visual Studio and the anatomy of a C# console application. 

### Types

- **Why** (5 min)
  - C# is a known as a strictly typed language, which means we need to know the types before we run our application. This helps us increase performance and allows us to manage our memory. 
- **What** (45 min)
   - Review the Types doc
  - [Types]("../Resources/Types.md") 
- **How**
  - Review how to declare variables with different types.
- **Experimentation and Discovery Ideas**
  - N/A

### Exception Handling

- **Why** (20 min)
  - Error messages can be difficult to read or understand. We need a way to handle errors when they occur so that we can properly document them on the system side and communicate them on the user side.
  - Some real life Examples of code bases that did not have proper exception handling
       1. [Therac-25](https://en.wikipedia.org/wiki/Therac-25) was a computer controlled radiation therapy machine in 1982 after the Therac-6 and Therac-20 units. 
          * At least 6 accidents between 1985 - 1987 patients were given massive overdoses of radiation. 
          * reasoning was due to errors of giving patients radiation doses that were hundreds of times greater than normal..resulting in death or serious injury. 
          * Engineers were overconfident in their initial work and did not handle exception handling for lethal doses
          * They reused code from the previous versions without checking it first
          * The issue only happened when a sequence of keystrokes occurred within a short period of time (8 seconds). Which made it difficult to catch

          *The software set a flag variable by incrementing it, rather than by setting it to a fixed non-zero value. Occasionally an *arithmetic overflow* occurred, causing the flag to return to zero and the software to bypass safety checks. 

     2. [Ariane 5](https://en.wikipedia.org/wiki/Ariane_5) Launch of 1996
        * Rocket self destructed 37 seconds after launch becuase of a software malfunction.
        * data conversion from 64-bit floating point to a 16-bit signed int value failed b/c the floating point value was too large to be represented into a 16-bit signed integer. 
        * This code was originally used for the Ariane 4 but was not protected because the way the Ariane 4 was written, the engineers "assumed" it was impossible for the value to get that large....when upgrading the system, they did not update the error handling either causing the issue.  
        
- **What** (15 min)
  - Exception handling is the ability to catch an error as soon as it happens and process it dependent on the type. With error handling, we have complete control of what the system does when an error occurs, how we want to handle it, and what steps occur next. This allows us to know exactly how the system will react and not allow it to interfere with production environments. 

  - Here are different types of Exceptions available: 
    - 
     1. **NotImpelemtedException** - Indicates that a method has not yet been implemented. 
     1. **IndexOutOfRangeException** - Indicates that an index outside the range of a collection has been referenced
     1. **InvalidCastException** -  Indicates that a cast has been attempted on the incorrect object type
     1. **FormatException** - Text was not in the correct format when converting it to something else.
     1. **NotSupportedException** - An action was attempted that was not supported.
     1. **NullReferenceException** - Reference type was null, instead of an object
     1. **StackOverflowException** - Indicates that there is no more room left on the call stack. 
     1. **DivideByZeroException** - You can't divide by zero....
     1. **ArgumentNullException** - A required non-null argument provided was null.
     1. **ArguementOutOfRangeException** - Argument contained a value that was out of range then what it was expecting.
 
- **How** (45 min)
  - Error handling is primarily handled through `try...catch...finally` blocks. Review the demo on good examples of how to use each.
- **Experimentation and Discovery Ideas**
  - Showcase how the call stack is involved with exception handling. `throw` the exceptions through methods back and forth to request flow of how the exceptions are handled. 


**In-Class Exercises**

  - Exercise 1 (20 minutes):
    1. Build an application, with a partner, that asks the user to enter a single number. 
    2. Save that number in a string variable.
    3. Ask the user to enter a 2nd number.
    4. Save that number in a new string variable. 
    5. Convert each of the string numbers into an integer
    6. Be prepared to `catch` a `FormatException` if the value entered cannot be converted to a number
    7. Within the `catch` output a message to the console that shows the user what they inputted.

  - Exercise 2 (15 minutes):
    1. Building off of exercise 1, ask the user if they want to add,subract,multiply, or divide. (a/s/m/d)
    2. Depending on their answer conduct that math equation with the two numbers. 
    3. What exceptions should we expect? Create as many catch statemetns as you feel are needed to fully cover the exception handling for this problem.

### Debugging

- **Why** (5 min)
  - Errors and bugs happen. It's inevitable. We need a way to target what those errors or bugs are so that we can handle them. 
- **What** (10 min)
  - debugging is the act of stepping through your code line by line, and validating the values of the variables. We no longer have `console.log` that you are used to seeing in JS. within Visual Studio, we have breakpoints!
- **How** (30 min)
  - Set Breakpoints
  - Set conditional breakpoints
  - manipulate the 'locals' window in Visual Studio
- **Experimentation and Discovery Ideas**
  - Play with the different breakpoint settings. Create errors and fix them/find them using debugging.

## Lab Notes
- There are 3 different lab assignments
     - Calculator app - Optional. This is a great exercise if you are conducting afternoon lecture and need an assignment in the morning. 
     - Practice debugging - This is a required assignment that will be due the next day. Students can expect to spend 2 hours on this assignment. 
     - Exception Handling - This is the core assignment for the day and reflects what was taught in lecture. 

- This lab primarily focuses on reading and following the directions with a small math twist towards the end. this lab shows the students the power of the call stack as well as the usage of variable scope and method management. 

## What might students struggle with today?

- The environment and basic layout of applications. C# is very different from what they are used to, be patient with their syntax questions. 

## Past bugs, issues or surprises...
N/A

## General Comments and Notes
