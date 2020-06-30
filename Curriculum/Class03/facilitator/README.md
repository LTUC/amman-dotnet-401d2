# Facilitators Guide: File Manipulation

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

- Review the ATM lab. It may be useful to either finish up a student's code, or recreate the lab from scratch.
- To prep for the in-class exercise later, have the students create a brand new console application. Have them complete the following:
	- Create a brand new method that brings in an integer, and returns a string array. 
	- Within that method, have the students instantiate an array equal to the size of the int parameter
	- populate the array with "anything" they want, but make sure it's a string value. (Example: Flavors of ice cream, different colors, or even pet names)
	- Within the main method, output to the console each value in the array. 

### File Streams

- **Why** (5 min)
  - When working as a server side application we need a way a way to manage file uploads and file manipulation. The best way and safest way to do this is through Streams. 
- **What** (10 min)
  - System.IO is an available library through .NET that allows for reading and writing to files and data streams. The i stands for input and the o stands for output.
- **How** (30 min)
  - Review the [System.IO](/Resources/System.IO)
- **Experimentation and Discovery Ideas**
  - introducing the `using(){}` statements
  - incrementally read and write to an external text file. 
- **In-Class Exercise**
  - Have the students write a program that writes and reads to to a file
  - Problem domain:
	- Building off of the warm up exercise, create a new method that brings in the string array.
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
