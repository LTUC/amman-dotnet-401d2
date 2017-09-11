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

1. Overview of the class
   - Syllabus
   - Bonus weekly Discussions
   - Lecture Hours/Lab Hours
   - 1:1 in week 3. 
   - My office hours
   - Expectations of self research (15 min rule)
   - 5 min Lightning Talks

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

* Microsoft Platform:
  * C# depends on a runtime equipped with a host of features such as automatic memory management and exception handling. The design of C# closely maps to the design of Microsoft’s Common Language Runtime (CLR), which provides these runtime features (although C# is technically independent of the CLR).
  * The CLR is the runtime for executing managed code. C# is one of several managed languages that get compiled into managed code. Managed code is packaged into an assembly, in the form of either an executable file (an .exe) or a library (a .dll), along with type information, or metadata.
  * Managed code is represented in intermediate language or IL. When the CLR loads an assembly, it converts the IL into the native code of the machine, such as x86. This conversion is done by the CLR’s JIT (just-in-time) compiler. An assembly retains almost all of the original source language constructs, which makes it easy to inspect and even generate code dynamically.
  * CLR is in charge of taking the managed code, compiling it into machine code and then executing it. On top of that, runtime provides several important services such as automatic memory management, security boundaries, type safety etc.


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

### Error Handling:
   - What do you do if you encounter an error (whiteboard // draw it)
   - 15 min rule
   - Take a deep breath, step away, break it down
   - documentation
   - look at the lecture
   - Online Research
   - ask a TA
   - Ask the instructor


### How to ask a question:

   - How do you ask a question?

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
