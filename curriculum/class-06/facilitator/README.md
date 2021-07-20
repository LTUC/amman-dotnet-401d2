# Class 06

## How do I prep for today?

1. Upload the demo code to the class repository. This will serve as an example for the students on what is expected for their lab.
1. Be prepared to go over the required data structure this day. Refer to the Common Curriculum Day 5 implementation on what data structure to teach.
1. There is an alternative lab that you may optionally choose. The initial lab is creating a zoo, the alternative lab is creating a vehicle dealership. Both have the same requirements, just different problem domains.

## Lecture

1. Code Review
   - Review the basics of classes and objects
1. Introduce OOP
     - Inheritance
     - Abstraction
     - Polymorphism
     - Encapsulation

Included in the demo folder is an example of a diagram that you can draw with the class as you go over the OOP principles. There is also the code base when converting the diagram to Visual Studio.

When they return from the exercise, build this out for them (with them) as a means of having everyone on the same page. Great opportunity to stack learn!

### OOP Principles (90 minutes)

The "Object Oriented Principles" (Pillars, Foundations)

[Resources](../resources/oop-principles.md)

- **Why** (5 min)
  - These are the principles of how we code with Objects
- **What** (30 min)
  - Inheritance
    - Derivatives
    - Parent is the base. Child is derived (often called "Sub-Classes").
    - Children implement each of the props and methods of the parent
      - ... and they can add/override as needed to make them unique
    - This really helps to keep things DRY
    - Think `<X> is a <Y>, with "these differences"`
  - Abstraction
    - Traditionally: **Difficult** to Understand, but **Easy** to implement
    - Broken down to basics (no form, no explicit use)
    - No Specific Use
    - No Specific Implementation
    - (We all see "art" in different ways, but it's still art)
    - In C#, we use an "Abstract Class"
      - An "Abstract Class" is created when more information is required
      - Think of it as a template for classes of a certain type
      - "I'm not going to tell you how to exist, only that you must"
      - **Cannot be instantiated**
    - Note: Concrete Classes are the default.
      - They can be instantiated, and therefore have structure.
      - They can also be derived from, but do not have enforcement
  - Polymorphism
    - Poly = Many, Morph = Change
    - Ability to change behaviors and properties
    - Group data together, but change what we want
    - Applies to classes and methods
    - Types:
      - Concrete - Standard, able to be implemented/used
      - Abstract - Templated, method signature only, required but not specified
      - Virtual - Allowed to be overridden
      - Sealed - Locked for change
  - Encapsulation
  - These allow us to more deeply describe and differentiate related classes/objects
- **How** (30 min)
  - Lead a UML exercise, modeling a party type hierarchy
  - Call out what/when things differ, what might be abstract
- **Demo** (45min)
  - Inheritance
    - We create sub-classes (identify inheritance) using the `:` in the class definition
      - i.e. `public class Student : Person { ... }`
      - Parent methods are `base()`, so you can call those as needed
        - Constructor: `public Student( string name ):base(name)`

- **Experimentation and Discovery Ideas**
- **In-Class Exercise** (30 minutes)

  > Do each of these after the relevant part of the lecture.

  - **Inheritance**: Using the same problem domain as we did on class 04, Build out a pizza store class and have it inherit down a new pizza store
  - **Abstraction**: Make the parent level pizza store abstract
  - **Polymorphism**: Set methods such as "OrderPizza" virtual to allow different ways to order
    - Allow methods like "MakePizza" abstract to require each store to set their own reqs on how to make the pizza
  - **Encapsulation**: Set the appropriate internal information private vs general props and methods public

## Lab Notes

Today is part 1 of a 2 part lab. In today's lab they will:

1. Draw/plan out a hierarchy chart of classes. This drawing should be present in their lab README.
1. Implement the classes and behaviors within Visual Studio. The hierarchy chart should match the implementation.
1. Tests to prove the OOP principles.

## What changed from yesterday?

N/A

## What might students struggle with today?

- The actual reasoning and implementation behind the OOP principles usually go pretty smoothly. I have found
breaking it down by each principle and showing how it looks in both the diagram and the VS code helps concrete the idea/concept.

## What bugs, issues, or surprises have come up in the past for this class?

- N/A

## General comments

This is a good day to encourage class interaction while building out the demo code together.
