# Exception Handling

## What is Exception Handling

When an application or a program encounters a problem/error, the C# CLR has the ability to package up that error and put into something called an Exception.

Typically, when an exception gets thrown, the rest of that method does not get run, instead the catch block is triggered, and the finally block (if present) finsihes out the 
execution of the program. 
The C# language comes with many built in exceptions, but you are not bound to those exception, you actually have the ability to create your own Exceptions by deriving the 
custom class from the `Exception` class if you wish. For now, let's just look at the built in exceptions. 

## Different types of Exceptions:

1. **NotImpelemtedException** - Indicates that a method has not yet been implemented. 
1. **IndexOutOfRangeException** - Indicates that an index outside the range of a collection has been referenced
1. **InvalidCastException** -  Indicates that a cast has been attempted on the incorrect object type
1. **FormatException** - Text was not in the coorect format when converting it to something else.
1. **NotSupportedException** - An action was attemtped that was not supported.
1. **NullReferenceException** - Reference type was null, instead of an object
1. **StackOverflowException** - Indicates that there is no more room left on the callstack. 
1. **DivideByZeroException** - You can't divide by zero....
1. **ArgumentNullException** - A required non-null argument provided was null.
1. **ArguementOutOfRangeException** - Arguement contained a value that was out of range then what it was expecting. 

### Try

 A `try` is a code block that is executed under the preparation that an error may potentially be thrown. Each try should be accompanied by a 
 `catch` . 

If there is no catch, and an exception is thrown, the CLR throws an unhandled error and stops the execution of the program. 
Generally, it is not reccomended to not have a catch block, although you can have an empty catch block or a catch block without an exception. 

Here is an example of what a `try` block woukd look like:

```csharp
		string number = "twenty";
		try
		{
			int twenty = Convert.ToInt32(number); //Error
		}
		catch(FormatException e)
		{
			Console.WriteLine("{number} is not an integer");
		}
```

### Catch

A catch block actually catches the error and then handles it. Like in the `try` example above, You *must* have a catch block after each try, or the CLR will thrown
an error and stop the execution of the program.

A cool thing about catch blocks is that you are not required to only have one....you can have as many `catch` blocks as you. The catch blocks are run from top to bottom and executes
the first valid/applicable catch block it finds. 

If you are unsure of what type of exception will be thrown, there is a very general exception called `Exception` that you can use. If you choose to use
this exception class as your choice in your `catch` block, make sure it is the very last catch block because that block will always run if an exception is caught. 
By having it at the bottom, this allows for a more valid/approraite exception to potentially be run instead. 

Here is an example:

```csharp

	try
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;

            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
        }
        catch(DivideByZeroException ex)
        {
            Console.Write("Cannot divide by zero. Please try again.");
        }
        catch(InvalidOperationException ex)
        {
            Console.Write("Not a valid number. Please try again.");
        }
        catch(FormatException  ex)
        {
            Console.Write("Not a valid number. Please try again.");
        }

```

### Finally

Finally blocks are structured to be placed right after a try/catch block. The finally will always be executed whether or not an exception is thrown. 
The finally block is generally used for cleaning up code, disposing unmanaged objects, etc...

```csharp
    int zero = 0;    
    
    try
    {
        int result = 5/zero;  // this will throw an exception       
            
    }
    catch(Exception ex)
    {
        Console.WriteLine("Inside catch block. Exception: {0}", ex.Message );
    }
    finally
    {
        Console.WriteLine("Inside finally block.");

    }

```

### Throw

a `throw` allows you to force an exception to be thrown. This can be done in either a `catch` block or a regular code block.
The advantages to this is if you have a custom exception that you would like to throw in replacement to the exception that was caught, or
you want an exception to be thrown, given a certain condition being met. 


```csharp
    if (original == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", "original");
    }

```
When your method throws an exception, that method is not required to handle it. If it chooses, it can just pass it back up the callstack and let the preceeding methods
handle it. The exception will keep moving up the callstack until it either finds a catch statement OR reaches the last point. 

### CallStack

The Callstack ...

- What is the Callstack?
- Exception Handling outside of methods

```
Main() --> MethodA() <br />
MethodA() --> MethodB() <br />
MethodB() --> MethodC() <br />
MethodC() encounters an exception -> No catch in MethodC(); <br />
Looks in MethodB() -> No catch in B either <br />
Looks in MethodA() -> No catch found <br />
Looks in Main() -> No catch <br />
Program Terminates. 

```

Another Example:

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