# Lecture 14: Dependency Injection

### Three Take-a-ways
1. 3 Life cycles of DI
1. Advantages of the Repository Pattern
1. Advantages of why we use Asynchronous programming

## Introduce Dependency Injection
Dependency Injection (DI) allows us to keep our applications loosely coupled. 
Within MVC, it's a pretty standard architectural pattern that is followed.
DI allows us to separate the controllers and the functionality away from
specific services. Giving us the ability to easily switch out dependencies with
minimal overhead of refactoring code.  


## What is Dependency Injection?
- Power point deck goes over what DI is.

Slides of of interest:
1. Slide 7 - This is what it "looks" like. Note the constructors job of bringing in a variable. this is what is being "injected"
1. Slide 8 - This is the request flow. Keep referring to this slide to show students what is actually happening. 
1. Slide 10 - Lifecycles - These are the different type of DI lifecycles.

After going over the slide deck, pull up one of the controllers that were scaffolded. 
These controllers contain DI with the DBContext getting injected in. The registration of this
DBContext happens in the startup.cs file. Once we implement the Repo Pattern, we will
add more mappings to the startup file to register the DI classes.


## Repository Pattern
What is the repository design pattern?
Draw it out:

<DRAWING HERE>

1. Create a new interface with CRUD operations
1. Create a new class with that implements the interface
1. Register the interface in the startup
   - Show the error message of what happens when we "forget" to register
1. Refactor controller to use interface instead of DBContext
1. Make sure the interface is asynchronous where appropriate

