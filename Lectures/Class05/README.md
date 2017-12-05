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

**More on Properties**
1. The value keyword is used to define the value being assigned by the `set` accessor.
2. Properties can be read-write (they have both a `get` and a `set` accessor), read-only (they have a `get` accessor but no `set` accessor), or write-only (they have a `set` accessor, but no `get` accessor). Write-only properties are rare and are most commonly used to restrict access to sensitive data.
    
      ```csharp
        class Person
        {
            private string name;  // the name field (called a 'backing store' note how it is private)
            public string Name    // the Name property
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
        }

        Person person = new Person();
        person.Name = "Joe";  // the set accessor is invoked here                

        System.Console.Write(person.Name);  // the get accessor is invoked here
      ```


  1. Logic can exist in the Get/Set accessors. 
         - This is OK
        ```csharp
            public class Date
            {
                private int month = 7;  // Backing store

                public int Month
                {
                    get
                    {
                        return month;
                    }
                    set
                    {
                        if ((value > 0) && (value < 13))
                        {
                            month = value;
                        }
                    }
                }
            }
            ```

      - So is this:

        ```csharp
        class Employee
        {
            private string name;
            public string Name
            {
                get
                {
                    return name != null ? name : "NA";
                }
            }
        }
        ```

        ***This is NOT good practice:***

        ```csharp
        private int number;
        public int Number
        {
            get
            {
                return number++;   // Don't do this
            }
        }
        ```


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
       - The member functions and variables which are declared as Internal only can be accessible inside the same assembly.
    1. **Protected**
       - The Protected members can only be accessible from its child class or in same class. It is best when you are using inheritance in your project.
    1. **Protected Internal**
       - It is accessible from the current assembly or from types that are derived from the containing class


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
    private void Machine()
	{
		Console.WriteLine("I'm the TC")
	};

    private void TVColor()
	{
		Console.WriteLine()
	};

    public void TVKeys()
	{
		Console.WriteLine(//KEYS - accessible to public)
	};

    public void Remote()
	{
		Console.WriteLine(//remote - accessible to public)
	};

    public void TVScreen()
	{
		Console.WriteLine(public - accesible)
	};

}
```

**Polymorphism:** <br />
  - Taking it one step further, "What if we need to change the behavior of the methods in the base class?"
  - Answer: Virtual and override methods.
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

# Assignments

## Readings

## Lab
- Create CodeFellows (students and staff)

## Code Challenge 5
- Most occurances in an array

## Weekend Assignment
- [Two Fighters, One Winner](https://www.codewars.com/kata/two-fighters-one-winner)
- [Chess Knight](https://www.codewars.com/kata/chess-fun-number-3-chess-knight)