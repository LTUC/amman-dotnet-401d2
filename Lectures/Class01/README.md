![cf](http://i.imgur.com/7v5ASc8.png) Class 01: Intro to C#
=====================================

## Overview 
* First day of Class! Spend the first part of class doing kickoff with the students
* Spend no more than an hour with students reviewing the pre-work. Do a review about what they should have learned and applied to their lab 
that they were instructed to create. 
 

## Learning Objectives
* The student will successfully request user input and output a response to the console.
* The student will implement try-catch statements as a form of exception handling within their code.
* Set-up a debugger within Visual Studio 2017
* Understand and be comfortable with debugging through code to identify potential bugs and errors. 

# Lecture Outline

**Kickoff**
* Welcome to Code 401
* Student Introductions
* TA Introductions
* Instructor & Assistant Instructor Introductions

1. Overview of the class
   - Syllabus
   - Lecture Hours/Lab Hours
   - 1:1 in week 3. 
   - My office hours
   - Expectations of asking for assistance (15 min rule)

**C# Basics**
* What is C#
  * Where did it come from?
	* Currently on C# 7
		* Updates to the language are always in the works to make it better
* What is .NET
* What is ASP.NET
* What is ASP.NET Core
	
* Why do we use it?
	* Statically Typed
		- Type checking occurs at compile time (C#)
	* Dynamically Typed
		- Type checking occurs at Run time (JS)
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



## **Exception Handling**
* Why do we need it?
  * Ask students about their experience from the prework's lab assignments. 
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

    ```csharp
    catch (Exception e)
    {
        //Do something with e here
    }
    ```

    ```csharp
    catch (WebException ex)
    {
       //code specifically for a WebException
    }
    ```

#### Finally
    - Examples of the Finally statement
    - The finally statement executes regardless if the catch was hit or not
    ```csharp
    public static void Main()
    {
        int[] array1 = {0, 0};
        int[] array2 = {0, 0};

        try
        {
            Array.Copy(array1, array2, -1);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Error: {0}", e);
        }
        finally
        {
            Console.WriteLine("This statement is always executed.");
        }
    }
    ```
#### Callstack
- What is the Callstack?
- Exception Handling outside of methods

```
Main() calls MethodA() <br />
MethodA() calls MethodB() <br />
MethodB() calls MethodC() <br />
MethodC() throws an exception -> No catch in MethodC(); <br />
Looks in MethodB() -> No catch in B either <br />
Looks in MethodA() -> No catch found <br />
Looks in Main() -> No catch <br />
Program Terminates. 

```

#### throw
- What is a throw?
- You can only throw an exception object or descendent from an exception.
- When you write a method that catches an exception, your method doe snot have to handle it. You can let the calling method handle the exception. 

```csharp
static void Main()
{
	try{
		WriteLine("Trying in Main() Method");
		MethodA();
	} catch(Exception ae)
	{
		WriteLine($"Caught in Main() Method  -- {ae.Message}");
	}

	WriteLine("Main() MEthod is done");
}

private static void MethodA()
{
	try{
	WriteLine("In Method A");
	MethodB();
	
	}catch{
		WriteLine("Caugh in MethodA");
		throw;
	}
}

private static void MethodB()
{
	try{
	WriteLine("In Method B");
	MethodB();
	
	}catch{
		WriteLine("Caugh in MethodB");
		throw;
	}
}

private static void MethodC()
{
		WriteLine("Caugh in MethodC");
		throw(new Exception("This is from Method C");
}
```


1. The solo "throw" just hands it off up the call stack
2. If no catch is found...it just moves its way down the callstack until it either hits the last point or finds a catch statment.

## **Setting Up a Debugger:**
- Why do you need a debugger
- How do you set up a debugger?
- How do you use a debugger?
  - Step through
  - Step over
  - Step into

### Error Handling while during Lab:
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
		- What Have you done (summarize in 1-2 sentances)
		- What *specific* error are you encountering
		- Where have you looked to find a solution for the error?
			- Example: MS Documentaion, "Bing" the error?

# Resources

* [C# Guide](https://docs.microsoft.com/en-us/dotnet/csharp/index)

# Assignments


## Readings
- C# 7.0 in a Nutshell - pg. 158 - 166 (start @ “try Statements and Exceptions)
	- Try/Catch & Exceptions excerpt from assigned book (introduction)
- [Try/Catch Blocks](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-the-try-catch-block-to-catch-exceptions)
- [Exception Handling](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/exception-handling-statements)

## Lab

[Lab 01 - About Me]("Lab 01 - AboutMe")

## Coding Challenge

* FizzBuzz Game
