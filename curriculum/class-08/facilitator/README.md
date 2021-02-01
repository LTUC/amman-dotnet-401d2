# Class 08: Collections & Enums

Today, the students will build off of interfaces and see how a built in interface can apply to generic collections. They will see the use of enums and how they are used in code, and create their own generic collection and learn what actually happens when they get instantiated.


## Code Review
- Review the OOP principles from Class 06
- Quiz, Draw, Build

## Lecture

### Topic 1: Enumerations (enums)

[Resources](../resources/enums.md)

- **Why** (5 min)
  - Data needs to be normalized and standardized
  - Avoid "trusting" users to spell things right
- **What** (30 min)
  - Booleans are a type of enum
  - But 2 isn't always enough
    - Days of the week
    - Months of the year
    - Models of cars
  - Constant values defined.
    - Behind the scene they are numeric and auto-incrementing.
      - This can be overridden
  - They provide a consistent way to provide a measured choice
    - Great for switch statements, filling web forms, etc
- **How** (30 min)
  - Declare an enum in a class with an optional numeric type and constant values and allow the language to assign your numeric index
    ```csharp
    enum Months : byte
    {
      January,
      February,
      March,
      ...
    }
    ```
    Or, explicityly:
    ```csharp
    enum Months : byte
    {
      January = 15,
      February = 21,
      March = 33,
      ...
    }
    ```
  - Use that enum to enforce a value by matching the names
    - Here, our `Month` property must have a value from the enum `Months`
    ```csharp
     public Months Month { get; set; }
    ```
- **Demo** (45min)
  -
- **Experimentation and Discovery Ideas**
  -

### Topic 2: Collections

[Resources](../resources/collections.md)

- **Why** (5 min)
  - Working with arrays is painful in C#
    - Heap management, etc
  - Javascript sure made that nice with `.push()` and `pop()`
  - Most of the time, you don't know how big a list will be
    - i.e. How many items in a users' shopping cart
- **What** (30 min)
  - Collections are dynamic, flexible, and allow us to "just add" items to a list
  - We don't have to manage memory any longer, but we do have be aware
  - A collection is a Class!
    - It must therefore be "invoked"
  - Collections require a Data type
    - Generic - 1 Data Type
    - Non-Generic can be a mix of data types (int, string, in the same list)
      - This is JS like ...
      - Why? Older C# versions weren't as type safe, but we are backwards compatiable
      - These are frowned upon today
- **How** (30 min)
  - Declarations:
    - `Dictionary<string, string> People = new Dictionary<string, string>();`
    - `List<string> myList = new List<string>()`
      - *"Create a List called myList where the members are strings by instantiating a List noting that members are strings"*
      - The chevrons call out that it's a "Generic"
      - This will require you to `using System.Collections.Generic`
    - Now, we have a list (an array) that we can manipulate
      - `myList.Add("Chevrolet");`
      - `myList.Add("Toyota");`
      - `myList.Add("Ford");`
    - You can `foreach`, loop, `Remove()`, etc
- **Demo** (45min)
  - Demo as you go ... collections are best seen as they're created
- **Experimentation and Discovery Ideas**
  -

## Lab Notes

The lab directions contain some code snippets to assist students if needed. They are allowed to use this code, if they wish, but they must comment the code to show understanding.

## What might students struggle with today?

## Past bugs, issues or surprises...

## General comments

