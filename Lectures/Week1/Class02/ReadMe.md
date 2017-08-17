![cf](http://i.imgur.com/7v5ASc8.png) Class 02:Exception Handling & Debugging
=====================================

## Overview
* The students likely encountered some errors during their first program that they created on day 1. There may have been user input errors or data manipulation issues. During the code review, or even the beginning of the actual lecture, ask the students what sort of issues they encountered, and work with them to become familiar with error and exception handling.
* When introducing error and exception handling, we will primarily be focusing on the try/catch/finally statements. This is what is most commonly used, and what the students will be implementing in their application from the previous day and just about all code moving forward.
* The best way to show or demonstrate the try/catch/finally is to do so in a live code demo. Pull up your code from the first lab, and add in your try/catch/finally statements to compare/contrast the differences.
* We will also be introducing debugging into this lesson. This can go hand-in-hand with the exception handling. This can be approached by an additional way to catch/find errors in the code that are not throwing an exception.
* As with the try/catch/finally statements, the debugging can be demonstrated through a live session. Demonstrate how to setup the debugger, what 'step over' 'step into' and 'step through' mean. 


## Learning Objectives
* The student will implement try-catch statements as a form of exception handling within their code.
* The student will setup a debugger within Visual Studio 2017
* The student will understand and be comfortable with debugging through code to identify potential bugs and errors. 


# Lecture Outline
**Exception Handling**
* Why do we need it?
  * Ask students about their experience from the previous day's lab assignments. 
  * What kind of errors did they receive?
  * How did they handle them?
  * Introduce Try/catch/finally statements
     #### Try
	 ```csharp
		string number = "twenty";
		try
		{
			int twenty = Convert.ToInt32(number); //Error
		}
	```
       - *If an exception is thrown, the common language runtime (CLR) looks for a `catch` block to handle the exception* 
       - *if there is no catch block, the CLR throws an unhandled error, and stops execution of th program*
       - *To not have a `catch` block is not reccomended. You **are** allowed to have an empty `catch` block or a `catch` block without an argument.*
	
	#### Catch
	- Here is an example of a catch statement:
	```csharp
	catch(InvalidCastException e)
	{
		Console.WriteLine(e);
		//You can also handle the exception however you choose to here
	}
	```
      - `throw` rethrows the exception or you can throw your own exception
	 ```csharp
		catch (InvalidCastException e)   
		{  
		 // Perform some action here, and then throw a new exception.  
		 throw new YourCustomException("Put your error message here.", e);  
		} 
	```


# Resources


# Assignments


## Readings

## Lab

## Coding Challenge
 