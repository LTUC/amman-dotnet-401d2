# ![cf](http://i.imgur.com/7v5ASc8.png) Class 06

## Learning Objectives
1. The student will create and implement interfaces within an applicaiton
2. The student will understand how to implement a linked list

## Lecture Outline
   
1. *Build out/Review OOPs principles*
   - What is Inheritance?
     - How do you implement implement inheritance?
     - why do we use inheritance?
   - What is Abstraction?
     - How do you make an class abstract?
     - Whats the purpose of an abstract class?
   - What is Polymorphism?
     - What does Polymorphism mean?
     - how do you make a class polymorphic?
   - What is Encapsulation?
     - Why use encapsulation?
     - What are the different accessor types?

1. **REVIEW:** True/false: C# supports multiple inheritance?
      - **Answer**: FALSE

### **Interfaces**
   1. why do you need them?
      - Sometimes you need to group your objects together based on the **things they can do** rather than the classes they inherit from.
      That is where interfaces come in - they let you work with any class that can do the job. 
      Any class that implements an interface must promise to 'fulfill it's obligations' or the compiler will get upset. 
      - Think of interfaces like 'actions' or 'protocols' that can be implemented on other classes
   - **Example**:
      - Build out a class
      - Build out an interface
        - Industry standard (starts with an "I")
        - add properties and methods to the interface
      - implement the interface on the class.
      - add the missing methods and properties into the class
      - Build out another interface
        - Addp properties and methods
      - implement that on the class

   1. You can't instantiate an interface, but you can **reference** an interface
        - This is not allowed:
            ```csharp
            ICatAttack kitcat = new ICatAttack();
            ```
        - the *is* allowed:
          ```csharp 
            KittyCat kitty = new KittyCat();
            ICatAttack kitcat = kitty;
           ```
            - A new reference is created using the variable ICatAttack.
            - This reference can point to an instance of **any class that implements ICatAttack**
   1. You can create a new object and assign it straightto an interface reference variable:
   ```csharp
    IKittyCat = kitcat = new Kitty();
   ```

   1. "is" Keyword
      ```csharp
       if(x is Kitty)
        {
          //Logic here
        };
         ```

### Interface Properties

- An interface has the following properties:
- An interface is like an abstract base class. Any class or struct that implements the interface must implement all its members.
- An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
- Interfaces can contain events, indexers, methods, and properties.
- Interfaces contain no implementation of methods.
- A class or struct can implement multiple interfaces. A class can inherit a base class and also implement one or more interfaces.
   


### Linked Lists
  1. What is a linked list?
     1. at it's simplist layer - a linked list is an array with pointers referencing the preceeding and proceeding node.  
     2. 'Singly' referes to one reference to it's next
     3. 'Doubly' refers to its last and next
     4. each item is referred to as a 'node'
     5. There is a 'head' and and 'end' on each of these. 
     

## Readings
- [Interfaces](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/)
- [Interfaces #2](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
- [Linked List](https://www.wikiwand.com/en/Linked_list)
- [Linked List #2](https://www.cs.cmu.edu/~adamchik/15-121/lectures/Linked%20Lists/linked%20lists.html)
   
## Code Challenge 06
Implement a singly linked list
- Using your "data-structures" repository created in class  2
  - add a folder and label it `Linked Lists`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas