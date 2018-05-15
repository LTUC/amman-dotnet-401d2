# Python OOP Principles

## Procedural Programming vs OOP Programming

### Procedural Programming (imperative programming)
Procedural programming is a list of instructions that tells program what to do step by step.
Procedural relies on a series of computational steps to be carried to completion. This is usualy done telling 
the program what to do first at the beginning, and what to do at the end. it is a bit more intuitive and simple
to read from top to bottom. Procedural programming languages are also called "top down "


### What is Object Oriented Programming?
Object oriented programming is mimicking real world objects in code. 
Everything in C# is essentaily a class, and we can instantiate objects from 
classes that we can manage at a smaller level. 

OOP objects are created to interact with other elements of the program regardless of where the command
is being called from. 


## Class
### What is a Class?
A class is a blueprint for a specific type or category of object. This means that the class will outline what exactly each object will have in regards to 

```python
class Dog:
    pass
```

Two different types of Classes:
1. Concrete
2. Abstract

### Instance Attributes

```python

class Dog:

    # Initializer / Instance Attributes
    def __init__(self, name, age):
        self.name = name
        self.age = age
```


### Class Attributes
A class attributes are specific to the whole class. This means that this variable/value is set to be the same 
value whenever an object is instantiated. 

Equivelant to Properties in C#


```python

class Dog:

    # Class Attribute
    species = 'mammal'

    # Initializer / Instance Attributes
    def __init__(self, name, age):
        self.name = name
        self.age = age
```


### Function vs a Method
Function is a unit of code/action that is not in a class.
A Method is the same unit of code/action, except it lives in a class.

3 different types of methods (in C# and Java)
1. Concrete - standalone virtual
2. Virtual - methods that can be overridden
3. Abstract - methods that have to be overwritten

2 different types
1. Concrete
2. Abstract
3. Since all methods in Python are technically virtual, it's not a thing. 

## Objects

### What is an object?
An object is an instance of a class.
You instantiate objects

### Instantiating an Object

```python
 class Dog:
     pass

	a = Dog()
	b = Dog()
	# check and see if a and b are equal, to confirm that each object is unique. 
	a == b
	>> False
```

here is complete example class  example: 

```python
	class Dog:

    # Class Attribute
    species = 'mammal'

    # Initializer / Instance Attributes
    def __init__(self, name, age):
        self.name = name
        self.age = age

    # instance method
    def description(self):
        return "{} is {} years old".format(self.name, self.age)

    # instance method
    def speak(self, sound):
        return "{} says {}".format(self.name, sound)

	# Instantiate the Dog object
	mikey = Dog("Mikey", 6)

	# call our instance methods
	print(mikey.description())
	print(mikey.speak("Gruff Gruff"))

```

## Inheritance
Inheritance is the process by which one class takes on the attributes and methods of another. 
Newly formed classes are called child classes, and the classes that child classes are derived from 
are called parent classes.

It’s important to note that child classes override or extend the functionality (e.g., attributes and behaviors) of 
parent classes. In other words, child classes inherit all of the parent’s attributes and behaviors 
but can also specify different behavior to follow. The most basic type of class is an object, 
which generally all other classes inherit as their parent.

### Single Inheritance

When you do single inheritance, you are only passing on one class's behavior onto a derived class. This is 
the most common type of inheritance amongst programming languages. (C# and Java only support single inheritance)

```python
class RussellTerrier(Dog):
    def run(self, speed):
        return "{} runs {}".format(self.name, speed)
```

### Overriding Functionality

```python
>>> class Dog:
...     species = 'mammal'
...
>>> class SomeBreed(Dog):
...     pass
...
>>> class SomeOtherBreed(Dog):
...     species = 'reptile'
...
>>> frank = SomeBreed()
>>> frank.species
'mammal'
>>> beans = SomeOtherBreed()
>>> beans.species
'reptile'
```

### Multiple Inheritance
Multiple inheritance is when a class can inherit attributes and methods from more than one parent class. 
This can allow programs to reduce redundancy, but it can also introduce a certain amount of complexity as well as 
ambiguity, so it should be done with thought to overall program design. 

```python

class Coral:

    def community(self):
        print("Coral lives in a community.")


class Anemone:

    def protect_clownfish(self):
        print("The anemone is protecting the clownfish.")


class CoralReef(Coral, Anemone):
    pass

```

We can start using the code like so...

```python
great_barrier = CoralReef()
great_barrier.community()
great_barrier.protect_clownfish()

```

Multiple inheritance allows us to use the code from more than one parent class in a child class. 
If the same method is defined in multiple parent methods, the child class will use the method of the 
first parent declared in its tuple list. 

## Abstraction

in C#/Jave OOP - Abstract classes are not supposed to be instantiated. They are only supposed to be used as a template that can be
derived further down for more clarity. 

Here is an example of an abstract class in Python

```python
class Document:
    def __init__(self, name):    
        self.name = name
 
    def show(self):             
        raise NotImplementedError("Subclass must implement abstract method")
 
```
## Polymorphism
Poly (means many), morphism in many forms. 
In polymorphism, you create a structre that can take or use many forms of objects. 

Examples included


Polymorphism with a function

```python

class Bear(object):
    def sound(self):
        print "Groarrr"
 
class Dog(object):
    def sound(self):
        print "Woof woof!"
 
def makeSound(animalType):
    animalType.sound()
 
 
bearObj = Bear()
dogObj = Dog()
 
makeSound(bearObj)
makeSound(dogObj)

```

Polymorphism with an abstract class (most commonly used)

```python

class Document:
    def __init__(self, name):    
        self.name = name
 
    def show(self):             
        raise NotImplementedError("Subclass must implement abstract method")
 
class Pdf(Document):
    def show(self):
        return 'Show pdf contents!'
 
class Word(Document):
    def show(self):
        return 'Show word contents!'
 
documents = [Pdf('Document1'),
             Pdf('Document2'),
             Word('Document3')]
 
for document in documents:
    print document.name + ': ' + document.show()

```

### Duck Typing
Duck typing exists in dynamic languages, like python. 
Essentially, you dont need a type in order to invoke an existing method on an object. If a method is defined, you can invoke it. 

## Encapsulation
Encapsulation is the process of hiding implementation details from the user.
Encapsulation is the act of hiding methods and attributes that should not be exposed to unauthorized or unneeded
classes or methods. Examples of encapsulation are Public, private, and protected. 

1. Public - Everyone has access
2. Private - Only the class has access to it
3. Protected - the class and any of it's derived children have access. 

Python doesn't really have Encapsulation