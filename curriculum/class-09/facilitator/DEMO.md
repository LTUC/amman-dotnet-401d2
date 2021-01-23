# Demos: LINQ & Delegates

Note: Demos as they exist in the `/demo` folder are provided in their **completed** state.

This demo feels like a lecture and is a lot of the "Resource" material repeated. It's important to use this sequence to solidify the core OOP concepts in an organized fashion, by building it out during lecture.

## Delegates

1. Create a Method external from main that does a CWL to show it is being run
1. Call the method (this should all be review)

```csharp

public static void Main(string[] args)
{
  MyMethod();
}

public void MyMethod()
{
  Console.Writeline('Hello');
}
```

- Introduce the concept of a Delegate (Delegates allow us to parameterize code. Review what a "method" actually is). Much like in JavaScript, we are able to send code into a method.
- Create the delegate and tell them that a class is getting created in the background

```csharp
delegate void MyDelegate();

public static void Main(string[] args)
{
  // MyMethod();

  // Create a delegate reference to MyMethod
  MyDelegate del = new MyDelegate(MyMethod);
  // Invoke MyMethod using a delegate instead of a direct call
  del();
  // del.Invoke() does the same thing
}
```

- Now, make a new method and pass delegate in so it can be run
- Note that you can do this 2 ways
  - First: By instantiating the delegate as shown before
  - Second: Just pass in the function name directly.
    - So long as the signatures match, it'll work!

```csharp
public static void Main(string[] args)
{
  // Create a delegate reference to MyMethod
  MyDelegate del = new MyDelegate(MyMethod);
  ExampleDelegateCall(del);

  // Bypassing the constructor
  ExampleDelegateCall(MyMethod)
}

// Delegate (reference is passed in as an arg that we can use in this method)
public void ExampleDelegateCall(MyDelegate del)
{
  Console.WriteLine("I'm Here");
  del(); // Runs MyMethod
}
```

Finally, create a generic function that does stuff with an IEnumerable set of numbers, and then a bunch of delegates that it can be called with to find things like evens, odds, etc

## LINQ

