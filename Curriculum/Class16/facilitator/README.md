# Class 16: Dependency Injection

## How do I prep for today?

Build off of the demo code from class 14. 

Today's Topics:
1. Intro to Dependency Injection (slide deck)
2. Intro to the Repository Design Pattern
	- Review of Interfaces
      - Emphasize the reusablilty of interfaces. 
      - Talk about the OOP principles and how/where interfaces fit.
	- Create a new interface with basic CRUD operations
		- IStudent
		- ICourse
	- Create services that implement the interfaces
	- Register the Interface using DI

## Lecture

- **Dependency Injection**
  - **Why** (5 min)
    - Keeping our applications "loosly coupled" is important because we want applications to depend on behavior and functionality instead of actual dependencies. 
  - **What** (10 min)
    - The ability to inject dependencies into our web application without being tightly coupled to a specific service or application. We work with the service provider directly to map what dependencies get injected into where. 
  - **How** (30 min)
    -  Any and all dependencies will need to be registered with the service provider through the `Startup.cs` class. These registrations will map directly to which classes get instantiated when specific dependencies are getting called. 
- **Repository Design Pattern**
  - Why
    - When working with Data Access Objects, primarily with our Models within our Database, we find that we get a lot of the same method signatures, Create, Read/Get, Update, and Delete. The repo design pattern allows for us to have a layer of abstraction when working with dependency injection. Instead of direclty injecting a dependency into a service or controller. we would instead inject an interface that outlines the required behavior. 
  - What
    - The repository design pattern is an architectural pattern that assists in the overall layout and data flow of a web application. The Repo Design Pattern acts almost as a "middleman" or middle layer between the data access logic and the web app itself. 
  - How
    - The repo design pattern is shown through the use of interfaces and services. Individual services get created that work directly with the dependency required and implements the interface that shows the minimum behavior required for that dependency to be used. We then register both the interface and dependency with the service provider in our Startup class to use with Dependency Injection.

## Lab Notes
This lab larger and more complex in size than previous labs. TThe students will be creating an interface 


## What might students struggle with today?  
This is a very heavy day. We are introducing two new major concepts
that blend into together. 

Students will likely not get these concepts right away.  Historically, they understand these concepts after exposure, repitition, and constant explanation. don't be suprised if you find yourself repeating the same thing over and over again. Eventually
they will get it!

Be prepared to review this concept again on class 17. This day's demo should have consisted of Refactoring only 1 controller with a new interface and service. It is reccomended that you also do a second controller with interface and service on Day 17 to solidify the concepts. 