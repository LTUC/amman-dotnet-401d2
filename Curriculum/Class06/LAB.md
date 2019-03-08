![cf](http://i.imgur.com/7v5ASc8.png) Lab 6: Interfaces
=====================================

## To Submit this Assignment
- Building off of your repo from Lab 5:
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)

## The Problem Domain
Build out a zoo.  Your program will instantiate each of your concrete animals, and prove that they are inheriting traits/features from their various parent classes.

- This is part 2 of a 2 part assignment. 
1. Create a minimum of 2 interfaces.
	- Each interface created should be implemented by more than one class.
	- Have at least one class implement more than one interface
- Test your code with Unit testing
- Label interfaces as `<interface>`

- When running your application, it should output each of the concrete animals and one 
behavior that it has inherited without any direct code manipulation


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
<br />
*NOTE*: You are not required to be scientifically correct with your animal names. You will not be fact checked.
You do not need to label your animals anything more complicated than (Mammal, Reptile, Cat, Bird, etc....)


## Unit Tests
Test that your program has the following functionality: 
1. Test that the classes that implement the interface actually implement it
2. Test inheritance
3. Test Polymorphism
	- Prove methods have been overridden
	- Prove that one of your concrete animals `is an` Animal


##Stretch Goals


## Additional Resources
- Please refer to the in-class diagram and code base as an example of the expectation.


## README

**A Readme is a requirement. No Readme == No Grade.** <br />
Here are the requirements for a valid readme: <br />

Add the following to your current readme from Lab 5/Part 1:
1. Define what an interface is in your own words
1. Describe what your interfaces are, where are they being implemented, and why. Provide Examples.
1. Updated diagram with your interfaces mapped out. 


## Rubric
- 14pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	14       | Program runs as expected, no exceptions during execution |
	10       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	8       | Program meets most of the functionality requirements described above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	6       | Program missing most of the functionality requirements described above // Program runs/compiles |
	4       | Missing Readme document // Readme document does not meet standards // Missing actual time CANVAS note |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 6pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 10/14 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	6       | Code meets Industry Standards // method and variable names are appropriate // Selective and iterative statements are used appropriately, Fundamentals are properly executed // Clearly and cleanly commented // Frequent Commits |
	4       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments // minimal or no commits |
	2       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |

