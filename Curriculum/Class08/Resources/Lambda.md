Now that we understand what Delegates are and why we would use them....one thing that we can see within our delegates is that we still had to create multiple methods with code in it that isnt that substantial.

Image we only want a bit of code to run...once. We don't want to necessarily create a whole new method for it, so instead...let's make the compiler do it for us. We can take this method:

```csharp
   static bool GetAllEvenNumbers(int n)
        {
            return n % 2 == 0;
        }
```

and turn it into this

```csharp
IEnumerable<int> values = GetNumbers(myArray, n => n % 2 == 0 );

```

Essentially, the compiler, in the background is making this method for us, but since we are only using this code once, there "isn't a need" for us to do it ourselves. 

This "Arrow" (=>) is called a "Lambda". The first value is the variable (which can map to the parameter), and everything after the arrow is the code for the method. the arrow points to the body of the method. That's it. 