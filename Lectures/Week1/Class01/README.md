![cf](http://i.imgur.com/7v5ASc8.png) Class 01: Intro to C#
=====================================

## Overview 
* This week focuses on the fundamentals of the C# language. The assumption coming into this course is the students have never coded in C# before, and this is their first exposure. 
We will go over the general basics of a console app, what methods are, as well as iteration statements, selection statements, and user input.

* A lot of the iteration and selection statements should be review for them from 201 and 301 from JavaScript. We may only need to slightly tweak their syntax for C#.
This will likely give the students some confidence on the first day that they do already know more than they think they do.

* Students will be writing code on the first day, so it is important for them to have their tools installed and ready to go. 
We will go over in class a walkthrough on how to start a new project. Live Code demo in class will take place so that students can get immediate exposure.

## Learning Objectives
* The student will be able to successfully identify and create methods and their components within a console application. 
* The student will be able to successfully identify and create selection statements and iteration statements to solve a problem.
* The student will successfully request user input and output a response to the console.

# Lecture Outline

**Kickoff**
* Welcome to Code 401
* Student Introductions
* TA Introductions
* Instructor & Assistant Instructor Introductions

**C# Basics**
* What is C#
  * Where did it come from?
	* Currently on C# 7
		* Updates to the language are always in the works to make it better
* What is .NET
* What is ASP.NET
	
* Why do we use it?
	* Statically Typed
		* vs Dynamically Typed
	* Object Orented
	* Microsoft Platform
* Introduction to Visual Studio 2017 Community
	* How to create a console applicaiton
	* Disect the contents of a standard console applicaiton
		* Namespace
		* Methods
          * arguments // parameters
          ```csharp

			public static void Main()
			{
				Greeting("Amanda");
			}
			

			public static string Greeting(string name)
			{
				string greeting = $"Hello, my name is {name} ";
				
				return greeting;
			}

			public static void Goodbye(string message)
			{
				Console.WriteLine("Goodbye");
				//No return required because it's a void
			}
			```
		* **iteration statements**
          * For Loop
            ```csharp
				for (int i = 1; i <= 5; i++)
				{
					Console.WriteLine(i);
				}
			```
          * Foreach Loop
            ```csharp
				int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
				foreach (int element in fibarray)
				{
					System.Console.WriteLine(element);
				}
			```
          * While Loop
            ```csharp
				int n = 1;
				while (n < 6) 
				{
					Console.WriteLine("Current value of n is {0}", n);
					n++;
				}
			```
          * Do While Loop
            ```csharp
				int x = 0;
				do 
				{
					Console.WriteLine(x);
					x++;
				} while (x < 5);
			```
			   
			
		* **selective statements**
          * If Statements
             ```csharp
				bool condition = true;

				if (condition)
				{
					Console.WriteLine("The variable is set to true.");
				}
				else
				{
					Console.WriteLine("The variable is set to false.");
				}
			```
          * If-Else statemetns
            ```csharp
			if (condition)  
			{  
				then-statement;  
			}  
			else  
			{  
				else-statement;  
			}  			
			```
          * Switch
            ```csharp
			int caseSwitch = 1;
      
				  switch (caseSwitch)
				  {
					  case 1:
						  Console.WriteLine("Case 1");
						  break;
					  case 2:
						  Console.WriteLine("Case 2");
						  break;
					  default:
						  Console.WriteLine("Default case");
						  break;
				  }			
			```
		* variables and different data types
			* how to declare them
	* Ask/Recieve User Input
		* `Console.Writeline()` - Write out a question
          ```csharp
			Console.WriteLine("Hello, How are you?");
			```
		* `Console.ReadLine()` - Read user input
			* put answer in a string variable
             ```csharp
			string answer = Console.ReadLine();
			```
			* Show the `Convert.To()` method to allow conversions 
				```csharp
				Console.WriteLine("How old are you?");
				int answer = Convert.ToInt32(Console.ReadLine());			
				```
            * Day 2 is when we talk about error handling, so don't get to far into this. just mention to be careful with conversions

# Resources

* C# 5 In a nutshell - C# basics
* [C# Guide](https://docs.microsoft.com/en-us/dotnet/csharp/index)

# Assignments


## Readings

* [Selection Statements](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/selection-statements)
* [Iteration Statements](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/iteration-statements)
* [Methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
* [Namespace](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace)

## Lab

[Lab 01 - About Me](https://www.google.com "Lab 01 - AboutMe")

## Coding Challenge

* FizzBuzz Game
