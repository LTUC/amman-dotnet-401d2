# Class 04 : Classes and Objects

## Overview

Introduce the concept of Classes and Object Oriented Programming as well as the memory management of C#.

## How do I prep for today?

1. Upload the starter code for today's lab to the daily class repository in GitHub.
1. Be comfortable with the demo code and lecture content.

## Lecture

### Code Review

Try and keep it short today. There are a lot of topics to cover!

### Topic 1: Object Oriented Programming - Classes and Objects

- **Why** (5 min)
  - Creates order from chaos
  - Describe the properties and actions of real world entities
    - People, Cars, Pets, ... anything you would put in a database
  - Describe relationships between these entities
- **What** (10 min)
  - Using Classes in C#, we can **model** these entities
  - Using our brains, we can connect objects together to create a working, interconnected system

### Topic 2: Classes and Properties (90 minutes)

- **Why** (5 min)
  - Deciding we want to describe everything we see is the beginning
  - We'll need to learn the tools that allow us to start creating and connecting
- **What** (10 min)
  - Classes are Templates, Objects are Instances of Classes
    - Ask your students many, many times this definition and distinction! It's going to be asked in interviews.
  - Classes [Lecture](../resources/classes.md)
    - We use classes to "model" our entities
      - They are like 'Factories' where we create a mold or a template, feed it the details, and then get a new thing (or an "Instance")
    - Templates / Blueprint
      - Properties [Lecture](../resources/properties.md)
        - Data, Descriptors, Physical Characteristics
        - Color, Size, Age, Balance, etc
        - Generally we use "getters" and "setters" to work with our properties
      - Methods
        - What can the entity do?
          - People can walk, dogs can bark, etc.
  - Object
    - Instance of a class
      - A Red Corvette vs a Black Tesla
    - They are unique
    - Literally, think of cars coming out of a factory
- **How** (30 min)
  - Live Coding Demo
  - Create different classes with properties.
- **Experimentation and Discovery Ideas**
  - Have students describe things at their desk.
  - What things do we all have different versions of?
- **In-Class Exercise** (30 minutes)
  - Create a program and implement the following:
    - A "Pizza" Store Class
      - Properties that describe the store (Name, Address, Size)
      - Constructor to specify the name of the store
      - OrderPizza - -returns pizza
    - A "Pizza" Class
      - Constructor that specifies the type of pizza
      - Properties for the ingredients
      - Bake() Method
      - Cut() Method -
      - Order() Method

### Value/Reference Types (15 minutes)

- **Why** (5 min)
  - N/A
- **What** (10 min)
  - Value Types
    - Scalars
      - int, bool, floats, double, string
    - They live on "The Stack"
      - Each has their own value
      - `x=10; y=x;`
        - Copies/Clones: These are independent and can change separately
    - Created at Compile Time
    - Garbage Collection does not access it
  - Reference type
    - Arrays, Objects
    - References the address of the object, but not the object itself
    - The variable is on the stack, the object itself lives in "The Heap"
    - `int[] nums = new int[5]; int[] mornums = nums;`
      - These are the same data
  - A great example
    - Value Type: Printed Newspaper
      - If the news changes, you don't see it, it's locked
    - Reference Type: nytimes.com
      - As this changes, everyone's view of it also changes
- **How** (30 min)
  - [Lecture](../resources/val-ref-types.md)
  - Demo: Create variables and arrays. Modify each

### Stack/Heap/Garbage Collection ( 30 minutes)

- **Why** (5 min)
  - With value types, as we delete them, they go away (come off the stack)

- **What** (10 min)
  - The act of clearing memory of things that are no longer used
    - i.e. Things in the heap that don't have references from the stack
  - 3 Generations that speak to the longevity
  - What triggers GC?
    - Loss of Memory
    - Some threshold is hit (how much memory is being used)
    - You call `GC.Collect()`
- **How** (30 min)
  - [Lecture](../resources/stack-heap.md)
  - [Lecture](../resources/garbage-collection.md)
- **Experimentation and Discovery Ideas**
  - Draw out each and show how a program executes with both working
- **In-Class Exercise**
  - N/A

## Lab Notes

The Lab contains starter code. This will give them a look of what a console app with many classes could potentially look like.

Provide this for them after the lecture and before they begin the lab.

The lab will require some knowledge on multi-dimensional arrays. Encourage students to look back at the prework array readings as a refresher.

## What changed from yesterday?

- Today is the first day of "Classes". Many questions that may have come up through the week should now be answered, or at least more details provided.

## What might students struggle with today?

- Properties are a hard concept for many to grasp. Usually the response is
("why not just use variables and fields").
- Constructors are a bit confusing as well, they want to call and use them like methods. Just enforce constructors as an object requirements used to "construct" the
object they are requesting.
- Value Types and Reference types can be difficult to grasp along with the Stack and Heap. Draw out the stack and the references to the objects on the heap. This usually helps
students understand the concepts a bit better.
- Students sometimes don't realize how well classes can work together, and how you can have multiple classes in a program that work together
to accomplish a task. You can remedy this by reviewing the benefits and purpose behind object oriented programming.

## What bugs, issues, or surprises have come up in the past for this class?

N/A

## General comments

- Through the week we have been alluding to the concept of classes but never actually talked about them.. now we get to.
You may be able to start the conversation of the class out by reviewing what they know already about classes.
