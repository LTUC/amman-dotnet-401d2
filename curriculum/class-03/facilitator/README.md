# Facilitators Guide: File Manipulation / System.io

## Overview

Today, we will learn about streams and how to write to and from a file within the stream.

### How does this topic fit?

**Where we've been**:
In the previous class we learned about unit testing and how to write programs using test driven development.

**What are we focusing on today**:
Today, we'll be switching over to file manipulation with streams.

**Where we're headed**:
Next class will focus on introducing classes and objects!

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to showcase how files and their contents get passed back and forth within a server side application.

## Preparation

- Read up on ...
- Get ready for questions about
- Look at previous course student submissions for insight as to what you might see in code review.
- Practice [the demo](../demo/demo-name) on whatever.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Code Challenge Review
  - This is a great pre-cursor to Linked Lists.
  - Point out that having to copy the entire array and make a new one is painful
    - Extra memory
    - Extra processing
    - Extra mental load for you
    - Linked Lists largely solve this (we'll get there in a few days)
- Review the ATM lab. It may be useful to either finish up a student's code, or recreate the lab from scratch.
  - Things to explore and look for:
    - Passing `balance` around and returning it vs using a Class level field ("global")
    - Using a `while` to keep the menu re-drawing
    - Common methods for common things
      - i.e. Using `getAmount()` for both Deposit and Withdraw
    - Breaking the problem down into many methods, each with a single purpose
    - Testability!

### Topic 1: Files

- **Why** (5 min)
  - Server Side applications very often need to deal with raw files
    - Logging
    - Storing Configurations
    - Saving data or images or pdfs, or anything
    - Uploading a file (using a stream)
    - PERSISTENCE
- **What** (10 min)
  - What are files?
    - Collection of data (bytes)
    - Persistent Memory
    - Just like RAM, a file system (drive) has slots for data, where it stores information
    - Files take contiguous slots (just like an array)
  - System.IO is an available library through .NET that allows for reading and writing to files and data streams.
    - `i` stands for input and
    - `o` stands for output.
- **How** (30 min)
  - `using System.io` gives you access to `File.*()` methods.
    - These Open, Operate, and Close files
    - The method you choose (`.ReadAllText()` etc) are the "Operate" phase
    - Quick, easy, and work synchronously or asynchronously
    - Work on the file as a whole, complete chunk of data
  - `using (FileStream fs = File.Create(path)){}` to work with a stream
    - Streams are for working with larger, binary files, typically over a network
    - File Handles are opened, data is transferred as a stream and then reassembled
  - Review the [System.IO](../resources/system-io.md)
- **Experimentation and Discovery Ideas**
  - introducing the `using(){}` statements
  - incrementally read and write to an external text file.
- **In-Class Exercise**
  - **Online/Virtual**: Use a breakout room
  - Have the students write a program that writes and reads to to a file
  - Problem domain:
	  - Building off of the warm up exercise:
      - create a new method that brings in the string array.
	    - Using System.IO, write the array to an external text file
	    - Create another method that returns a string array that returns the contents of the text file.
	    - Within the main method, output to the console all of the text contained within the file.
	    - STRETCH: Update or delete specific lines in the text?


## Lab Notes

This lab should be done solo.

This lab is a series of challenges that summarize all of the content up to this day. The objective of this lab is to provide additional practice of the language and fundamental exercises.

## What might students struggle with today?

- N/A

## Past bugs, issues or surprises...

## General Comments and Notes
