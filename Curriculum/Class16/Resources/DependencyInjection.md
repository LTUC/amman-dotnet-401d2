# Lecture 14: Dependency Injection


### Three Take-a-ways
1. 3 Life cycles of DI
2. Advantages of the Repository Pattern
3. Advantages of why we use Asynchronous programming


## Scaffold a Controller
- This will demonstrate what DI looks like with the DbCOntext
- "Eager" and "Explicit" Loading
- Talk about Lazy, 

### Asyncronous Programming

## What is Dependency Injection?
- Power point deck

## Repository Pattern
1. Create a new interface with CRUD operations
2. Create a new class with that implements the interface
3. REgister the interface in the startup
4. Refactor Controller to use interface instead of DBContext
5. Make sure the interface is asynchronous where appropriate

