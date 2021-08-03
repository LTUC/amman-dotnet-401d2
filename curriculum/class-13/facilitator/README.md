# Facilitators Guide: Dependency Injection & Repository Design Pattern

## Overview

Dependency Injection (DI) allows us to keep our applications loosely coupled. Within MVC, it's a pretty standard architectural pattern that is followed. DI allows us to separate the controllers and the functionality away from specific services. Giving us the ability to easily switch out dependencies with minimal overhead of refactoring code.

### How does this topic fit?

**Where we've been**:
In the previous class students wired up a basic .NET Web App using Entity Framework and MVC Controllers

**What are we focusing on today**:
Today, we'll be "fixing" the controllers by using Dependency Injection with the Repository Design Pattern to be much more DRY with our implementation

**Where we're headed**:
Next class will focus on Routing and Navigation Properties

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to have students become more acquainted with DI, REST, and the scaffolding/wiring of a .NET Web App.

## Preparation

- Read up on ...
- Get ready for questions about
- Look at previous course student submissions for insight as to what you might see in code review.
- Practice [the demo](../demo/demo-name) on whatever.

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Notes here

### TOPIC 1: Dependency Injection

- **Why** (5 min)
  - Keeping our applications "loosely coupled" is important
    - We want applications to depend on behavior and functionality **not** specific dependencies.
  - We want to be flexible and scalable as we grow and potentially replace services
- **What** (10 min)
  - The ability to inject dependencies into our web application without being tightly coupled to a specific service or application.
  - We want services to be interchangeable
  - Map services to interfaces
    - What is a service?
      - Concrete class that implements an agreed upon interface
      - We will be injecting our DbContext into the service, not the Controller
    - **Interfaces**
      - Common behaviors
        - Possibly different inbound/outbound data
  - For example:
    - we wire up some code to search yahoo.

      ```csharp
      // Fetch some data from our favorite search engine
      yahoo.search('stuff');
      ```

    - Then google replaces Yahoo, so we have to change our implementation

      ```csharp
      // Fetch some data from our favorite search engine
      // yahoo.search('stuff');
      google.search('stuff');
      ```

    - Now, DuckDuckGo becomes popular. We're repeating ourselves, and potentially introducing issues. Better:

      ```csharp
      // Use an "internet search interface" to let us toggle what's being used for real
      internet.search('stuff');
      ```

- **How** (30 min)
  - Any and all dependencies will need to be registered with the service provider through the `Startup.cs` class.
  - These registrations will map directly to which classes get instantiated when specific dependencies are getting called.
- **Experimentation and Discovery Ideas**

### TOPIC 2: Repository Design Pattern

- **Why**
  - When working with Data Access Objects, primarily with our Models within our Database, we find that we get a lot of the same method signatures
    - Create, Read/Get, Update, and Delete.
  - The Repository Design Pattern allows for us to have a layer of abstraction when working with dependency injection.
  - Instead of directly injecting a dependency into a service or controller. we would instead inject an interface that outlines the required behavior.
- **What**
  - The Repository Design Pattern is an **architectural design pattern**
  - Assists in the overall layout and data flow of a web application.
  - The Repository Design Pattern acts almost as a "middleman" or middle layer between the data access logic and the web app itself.
- **How**
  - The Repository Design Pattern is shown through the use of interfaces and services.
  - Individual services get created that work directly with the dependency required and implements the interface that shows the minimum behavior required for that dependency to be used.
  - We then register both the interface and dependency with the service provider in our Startup class to use with Dependency Injection.

## Lab Notes

- This lab larger and more complex than previous labs.
- The students will be creating an interface.

## What might students struggle with today?

This is a very heavy day. We are introducing two new major concepts that blend into each other.

Students will likely not get these concepts right away.  Historically, they understand these concepts after exposure, repetition, and constant explanation. Don't be suprised if you find yourself repeating the same thing over and over again. Eventually they will get it!

Be prepared to review this concept again in the following classes. This day's demo should have consisted of refactoring only 1 controller with a new interface and service. It is recommended that you also do a second controller with an interface and service to solidify the concepts.

## Past bugs, issues or surprises...

## General Comments and Notes
