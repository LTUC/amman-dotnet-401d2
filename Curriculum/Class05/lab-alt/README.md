# Lab 05: .NET Motors

## The Problem Domain

***This is part 1 of a 2 part assignment.***

You have been tasked to stock the inventory of ".NET Motors". The owner of this company is requesting that you show to them possible vehicles that they can stock the showroom with. They have specifically asked that you provide for them a map of all the different types that they can have as well as the commonalities between them.

Think about a vehicle dealership. They sell vehicles of all sorts; cars, trucks, boats, they even sell airplanes! Think about what each of these vehicles have in common. Build out the hierarchy of a vehicle dealership. Your program will instantiate each of your concrete classes, and prove that they are inheriting traits/features from their various parent classes.

## Instructions 

Using UML, diagram what vehicles the inventory will consist of. Include in each class the properties and behaviors for each vehicle, as well as the relationships between each vehicle from it's base classes. 

Here are some UML resources to help get you started:

1. [UML Overview](https://www.tutorialspoint.com/uml/uml_overview.htm)
1. [OOP and UML](https://www.codeproject.com/articles/618/oop-and-uml)

Next, create a new console application that will instantiate each of your concrete vehicles, and prove that they are inheriting traits/features from their various parent classes.

Your lab should showcase all 4 of the Object Oriented Principles (OOPs). 

1. Implement each of the classes you showcased in your UML within Visual Studio.
	- There should be at least 3 layers of inheritance with at least 5 different types of vehicles. 
1. Prove that the behaviors for each class exist or were properly inherited by returning strings as necessary .
	- Some example methods could be: `Drive()` `Brake()` `Start()` etc... 
	- You are allowed to use these example methods within your lab, along with others not listed
1. Include the following labels:
	1. Label the parent and derived classes
	2. Label the abstract classes and concrete classes
	3. Label the access modifiers for each of the classes
	4. Label where you are using polymorphism in your program. Identify where the virtual and abstract methods are defined, and where are they being overridden.
1. Your program class should instantiate each of the concrete classes to prove the functionality of it's base classes. 


## Program Specifications

Your solution should include the following:
- Have at least 3 different abstract classes
- Have at least 3 layers of inheritance
- Have at least 5 concrete classes
- Have at least 2 abstract methods (make sure you override them)
- Have at least 2 abstract Properties (make sure you override them)
- Have at least 2 virtual methods (make sure you override at least one of them)
- Have at least 2 virtual properties (make sure you override at least one of them)
- Your (digital) drawing of your diagram should be clearly labeled

## Unit Tests
Test that your program has the following functionality: 
1. Getters/Setters on all properties
2. All concrete and virtual methods that have non-void return types.
3. 3 of your concrete classes exhibit at least at least 2 expected behaviors from a parent/base class.

## Stretch Goals
No stretch goals present for this project

## Additional Resources
- Please refer to the in-class diagram and code base as an example of the expectation. 


## README
**A Readme is a requirement. No Readme == No Grade.**

Here are the requirements for a valid readme: <br />

Your readme is ***extremely important*** in this lab because it will be a guide for us to know 
exactly what you did where and how. Define for me, in your readme, the following:
1. An introduction to the project
1. Your digital drawing of your inventory
1. Create your own technical documentation. Breakdown and define each of the OOP principles in your own words.
1. Provide under each OOP definition a couple (you do not have to define all) of examples of how you 
are applying this into your project



## Rubric

The lab rubric can be found [HERE](../../Resources/rubric){:target="_blank"} 

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `DotNetMotors`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)