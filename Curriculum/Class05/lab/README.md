# Lab 05: I built a Zoo!

## The Problem Domain
A zoo contains animals, and animals can come in many different shapes and sizes. It is your job to plan and build out what animals that live in the zoo. 

This is the first part of a 2-part assignment. Lab 06 builds off of Lab 05.

## Instructions 

Using UML, diagram what animals the zoo will consist of. Include in each class the properties and behaviors for each animal, as well as the relationships between each animal from it's base classes. 

Here are some UML resources to help get you started:

1. [UML Overview](https://www.tutorialspoint.com/uml/uml_overview.htm)
1. [OOP and UML](https://www.codeproject.com/articles/618/oop-and-uml)

Next, create a new console application that will instantiate each of your concrete animals, and prove that they are inheriting traits/features from their various parent classes.

Your lab should showcase all 4 of the Object Oriented Principles (OOPs). 

1. Implement each of the classes you showcased in your UML within Visual Studio.
	- There should be at least 3 layers of inheritance with at least 5 different types of animals. 
1. Prove that the behaviors for each class exist or were properly inherited by returning strings as necessary .
	- Some example methods could be: `Eat()` `Sleep()` `Sound()` etc... 
	- You are allowed to use these example methods within your lab, along with others not listed
1. Include the following labels:
	1. Label the parent and derived classes
	2. Label the abstract classes and concrete classes
	3. Label the access modifiers for each of the classes
	4. Label where you are using polymorphism in your program. Identify where the virtual and abstract methods are defined, and where are they being overridden.
1. Your program class should instantiate each of the concrete animals to prove the functionality of it's base classes. 


## Program Specifications

Your solution should include the following:
- Have at least 3 different abstract classes
- Have at least 3 layers of inheritance
- Have at least 5 concrete animals
- Have at least 2 abstract methods (make sure you override them)
- Have at least 2 abstract Properties (make sure you override them)
- Have at least 2 virtual methods (make sure you override at least one of them)
- Have at least 2 virtual properties (make sure you override at least one of them)
- Your (digital) drawing of your zoo diagram should be clearly labeled

*NOTE*: You are not required to be scientifically correct with your animal names. Keep the names of your animals simple. For example you do not need to label your animals anything more complicated than Mammal, Reptile, Cat, Bird, etc...

## Unit Tests
Test that your program has the following functionality: 
1. Test that each of your concrete animals exhibit the at least 2 appropriate behaviors given to them from a base class.

## Stretch Goals
No additional Stretch goals are required for this lab

## Additional Resources
- Please refer to the code demo in the GH class repo as an example of the expectation. 

## README
**A Readme is a requirement. No Readme == No Grade.** 

Here are the requirements for a valid readme: 

Your readme is ***extremely important*** in this lab because it will be a guide for us to know 
exactly what you did where and how. Define for me, in your readme, the following:
1. An introduction to the project
1. Your digital UML drawing of your zoo
1. Create your own technical documentation. Breakdown and define each of the OOP principles in your own words.
1. Provide under each OOP definition a couple (you do not have to define all) of examples of how you 
are applying this into your project

## Rubric
The lab rubric can be found [HERE](../../Resources/rubric){:target="_blank"} 

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back to master
- Submit a link to your PR in canvas
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)