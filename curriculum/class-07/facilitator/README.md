# Class 07 - Interfaces

Today is an we extend Class 06, introducing Interfaces.

## Code Review

- Review the OOP principles from Class 06
- Quiz, Draw, Build

## Lecture

### Topic 1: Interfaces

[Resources](../resources/interfaces.md)

- **Why** (5 min)
  - We need a way to represent common functionality
- **What** (30 min)
  - An interface represents things that a class can do
    - Action (verb)
  - A class can "Opt In" to using this functionality
  - Inheritance says "I am a..."
  - Interfaces represent "I can..."
    - To the compiler, it's actually "I Must" once you implement an Interface
  - Naming Convention
    - Starts with `I`
    - Often ends with `able` (i.e. Flyable, Driveable)
- **How** (30 min)
  - An interface represents a functionality/behavioral contract
  - Similar to Inheritance, but it presents a common "API" to seemingly unrelated things
    - i.e.
      - A person can drive many things (car, plane, boat)
      - Many things can be driven
      - So, a contract can exist (an interface) that says anything that can be driven must:
        - Start, Stop, GoForward, GoBackward, Slow Down, Turn
        - The user (Person) can then `Drive(IDriveable thing)` where  the `thing` implements the IDriveable Interface.
      - The person knows what methods to call, and each thing implements those methods
  - This ensures that multiple teams can make completely separate things that obey the same contract.
  - In hardware terms, think of USB. It's an interface for exchanging data and voltage. Both ends of that know what can be done and how to invoke those actions
- **Demo** (45min)
  - Create a demo showing some basic driving functionality shared by disparate classes
- **Experimentation and Discovery Ideas**
  - Be sure to stress the differences between an abstract class and an interface. This is a super common interview question.

## Lab Notes

## What might students struggle with today?

Interfaces are sometimes difficult for students to understand. It is important to stress the differences between a class and an interface. The differences between an Abstract class and an interface.

## What bugs, issues, or surprises have come up in the past for this class?

## General comments
