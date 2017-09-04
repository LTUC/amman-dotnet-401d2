# ![cf](http://i.imgur.com/7v5ASc8.png) Class 05

## Overview:
1. We are shifting gears this day away from the basic syntax of the langauge, more into the actual OOP side of C#. 
1. Students will be introduced to memory management this day (stack/heap) as well as the first 2 pillars of the OOP principles
1. This is a good day to potentially "draw" on the board or tablet what it is you are talking about when it comes to stack/heap
a well as inhearitance and hierarchy of classes.

## Learning Objectives
1. The Student will be introduced to the Object Oriented Pillars and know how and when to identify and apply them in code.
1. The student will understand how stack and heap fit into memory management, and the basic concepts of garbage collection
## Lecture Outline

### OOP principles pt 2

**Encapsulation**
- Encapsulation means to encapsulate logic (into classes)
  - hide the secure or unwatned data to user. 
  - Hide the member functions variables, etc...to the outside world. 
  - Encapsulation is a way of encapsulating the data [wrapping the data] into a single unit called class. 


### Access Modifiers:

  1. **Private**
        - restrict the member function or variable to be called outside from the class. If we create any
          function or variable inside the class as private then it will not be accessible to outside the class. 
    2. **Public**
       - member function or variable declared as public can be accessed from outside the class. it means you can access public members from anywhere
    3. **Internal**
       - The member functions and variables which are declared as Internal only can be accessible inside the same namespace. You cannot access these members outside the namespace where these are declared.
    1. **Protected**
       - The Protected members can only be accessible from its child class or in same class. It is best when you are using inheritance in your project.
    1. **Protected Internal**
       - It can be accessible within the assembly where it is declared or in derived class of other assembly


**Demo**

```csharp

class Program {
	public class Account {
		private decimal accountBalance = 500.00;

		public decimal CheckBalance() {
			return accountBalance;
		}
	}

	static void Main() {
		Account myAccount = new Account();
		decimal myBalance = myAccount.CheckBalance();

		/* This Main method can check the balance via the public
		* "CheckBalance" method provided by the "Account" class 
		* but it cannot manipulate the value of "accountBalance" */
	}
}

```

```csharp
class TV
{
    private void Machine(){Console.WriteLine("I'm the TC")};
    private void TVColor(){Console.WriteLine()};
    public void TVKeys(){Console.WriteLine(//KEYS - accessible to public)};
    public void Remote(){Console.WriteLine(//remote - accessible to public)};
    public void TVScreen(){Console.WriteLine(public - accesible)};

}
```

**Polymorphism:**
    1.Taking it one step further, "What if we need to change the behavior of the methods in the base class?"
      1. Answer: Virtual and override methods. 
          - Virtual Methods: a derived class can `override` the method with it's own implementation
```csharp
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Draw Draw Draw from the base!");
    }
}

class Circle:Shape
{
    public override Draw()
    {
        Console.WriteLine("Now I'm drawing a Circle")
    }
}
```
- Everytime `Circle.Draw()` is called, it will output "Now i'm drawing a Circle".
- What if I want to keep the base class method AND override it with my own action? 
    - Answer: Add the `base` keyword

```csharp
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Draw Draw Draw from the base!");
    }
}


class Circle:Shape
{
    public override Draw()
    {
        Console.WriteLine("Now I'm drawing a Circle")
        base.Draw();
    }
}

```

- fields **cannot** be virtual, only methods properties, events, and indexers. 

- What if you want your derived class to have the same name as a member from the base, but do nto want it to participate in virtual invocation?
  - use the `new` keyword

```csharp
public class Shape
{
    public void CrayonColor(){//logic}
}

public class Circle: Shape
{
    public new void CrayonColor(){//logic}
}
```


### **Stack/Heap & Garbage Collection**
   1. When you declare a variable in a .NET application, 
         it allocates some chunk of memory in the RAM. This memory has three things: 
        1. the name of the variable
        2. the data type of the variable
        3. the value of the variable.
    1. What is the Stack?
       1. Imagine it like a stack of shoe boxes 
       1. Keeps track of what is being executed in the code
       1. Holds value types
       1. Self-maintaining -takes care of it's own memory management
    1. What is the heap?
       1. Imagine it like a bucket with a lot of 'things' in it
       1. Keeps track of objects / reference types / *sometimes* Value Types
       1. Relies on Garbage collection (GC) for memory management
       1. Reference Types usually go to the heap


***Demo***

```csharp
    Public void MyMethod()
    {
        int x= 5;
        int y= 10;
        MyClass objName = new MyClass();
    }   
```

**Breakdown the Code above**
1. ***Line 1:*** the comiler allocates a small amount of memory on th stack for this variable declaration. (the stack is responsible for keeping track of the running memory needed in your application)
1. ***Line 2:*** This is the next step, and it then 'stacks' the next memory allocation on top of the previous one. Think of this as 2 boxes stacked on top of each other. 
   1. Memory Allocation works like this: LIFO (last in first out) - meaning memory is allocated and de-allocated at only one end fo the memory (top of the stack)
1. ***Line 3:*** Here, we created an object, when this is executed, it creates a pointer on the stack to the actual object stored in the "Heap". 
   1. Heap does not track running memory, its just a pile of objects that can be reached at any moment in time. Heap is used for dynamic memory allocation. 

1. ***Exiting the Method***: When the exectution meets the end of the method, it will start 'exiting' meaning it will clear the memory variables that are assigned in the stack. This de-allocaiton happsn in a "LIFO fashion of the stack.
    1. this leaves the heap still with the object reference. Garbage Collection will take care of this by removing the object ***as long as there are no pointers or references to it***


**Stack/Heap Before Exiting**

|Stack           |Heap           |
|----------------|---------------|
|objName(ref -->)|ObjName(object)| 
| y=10 |               | 
|  x= 5  (first in last out)  | | 


**After Exiting**

|Stack           |Heap           |
|----------------|---------------|
||ObjName(object)| 
||               | 
| | | 


- Static Memory ==> Stack
- Dynamic Memory ==> Heap

- Value Types: are types whch hold both data and memory on the same location

```csharp
int x = 5;
int y = x;
```

|Stack           |Heap           |
|----------------|---------------|
|y = 5|| 
|x = 5|| 

- Reference Type: has a pointer which points to the memory location

```csharp
MyClass obj = new MyClass();

MyClass obj2 = obj;
```

|Stack           |Heap           |
|----------------|---------------|
|obj2(reference)->| Object| 
|obj(reference) ->|(same object w/ 2 pointers)| 


## Readings

## Code Challenge 5
