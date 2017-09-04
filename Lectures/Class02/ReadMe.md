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
## **Exception Handling**
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

## **Setting Up a Debugger:**
- Why do you need a debugger
- How do you set up a debugger?
- How do you use a debugger?
  - Step through
  - Step over
  - Step into

1. Open up the project from Day one,
2. Attach the debugger
3. Use the step through/over/into actions to demonstrate what you need it for
4. "change" the values of the variables within the debugger to show flexibility


# Resources

# Assignments

## Readings

### Blog posts
1. [Debugging your C# applicaiton](https://weblogs.asp.net/imranbaloch/aspnet-vnext-debugging-mvc-source)
### Official docs
1. [How to use the try/catch block to catch exceptions](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-the-try-catch-block-to-catch-exceptions)
1. [How to explicitly throw exceptions](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-explicitly-throw-exceptions)
1. [How to use finally blocks](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-finally-blocks)
1. [Best Practices](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions)

## Lab
Day02- About Me Quiz w/ Exception Handling

## Coding Challenge
Reverse String challenge
 