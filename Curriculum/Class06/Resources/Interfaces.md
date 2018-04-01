# Interfaces

Interfaces tell a class what it can do. This means that when you visually see an interface **implemented** onto 
a class, that means that the class you are looking at has an obligation to fullfill the requirements listed in the
interface. 

The obligation that the class has extends out to all of the properties and methods that the interface defines. When implemetning
an interface, the class must, no exceptions, implement each of those items defined in the interface. If you choose not too...the 
compiler will error and you will be unable to continue. 


## Why use an interface?

Interfaces are traditionally used on more than one class, or better yet, have the ability to be used on more than one class. Interfaces
tell a class what it can do, versus inheriteance, which tells a class what it has. 

Traditionally, you use interfaces to allow functionality on a class on external compents that depend on the methods being called within the interface.

Most commonly, in the development world, when working across teams, your team will recieve an interface that must be implemented in your code. 
The interface defines what exactly this other team is expecting, and it is your job to define the functionality for each of those methods and properties. 

1. why do you need them?
	- Sometimes you need to group your objects together based on the **things they can do** rather than the classes they inherit from.
      That is where interfaces come in - they let you work with any class that can do the job. 
      Any class that implements an interface must promise to 'fulfill it's obligations' or the compiler will get upset. 
      - Think of interfaces like 'actions' or 'protocols' that can be implemented on other classes
	 
	 
### Demo:
- Build out a class (Person Class)
- Build out an interface (IDrive)
- Industry standard (starts with an "I")
- add properties and methods to the interface
- implement the interface on the class. (Person : IDrive)
- add the missing methods and properties into the class
- Create a method that takes in a Car as a parameter and allows the person do drive
- Add a Boat the implements IDrive
- Update the person Drive method to have the parameter as IDrive to allow for both.


## Interface References

1. You can't instantiate an interface, but you can **reference** an interface
- This is not allowed:
```csharp
	ICatAttack kitcat = new ICatAttack();
```
- this *is* allowed:
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

- An interface is like an abstract base class. Any class or struct that implements the interface must implement all its members.
- An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
- Interfaces can contain events, indexers, methods, and properties.
- Interfaces contain no implementation of methods.
- A class or struct can implement multiple interfaces. A class can inherit a base class and also implement one or more interfaces.
   


## Example
Let's dive into an example that may show interfaces a bit more clearly.

Imagine you have an application that creates automobiles. You structure your program so that it has an abstract Automobile class with a derived class
of `Car`. 

Imagine you also have a `Person` class. This `Person` class has the ability to do a lot of different actions such as walking, talking, and driving.
Because driving is really just a general action we don't/shouldn't have specific methods in the `Person` class that instructs them how to drive, instead we should 
just have a method/action that takes in a parameter requiring something that is drivable. 

We accomoplish this by creating an interface named `IDrive`. This specific interface will include methods such as `Start()`, `Brake()`, `Stop()` etc...
We will require any class that implements `IDrive` to incldue this functionality so that when a Person wants to drive a car, they can just call the Car.Start() method to start the automobile.
The person no longer has to guess if the automobile they are trying to drive has the correct functionality. It can be assumed that it has exactly what it needs to because
of the obligation and contract that interfaces have with the classes they are implemented into. 

The alternative to this is to force the person have a specific DriveCar method that takes in (Car Car), which means if we have a boat that is drivabe,
we would have to create another method that is called DriveBoat that takes in a (Boat boat).