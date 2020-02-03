Lab 6: Interfaces
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
***This is part 2 of a 2 part assignment***

Building off of Lab 5....
1. Add these interfaces onto your map hierarchy. Label each interfaces as `<interface>`
1. Create a minimum of 2 interfaces.
	- Each interface created should be implemented by more than one class.
	- Have at least one class implement more than one interface

- When running your application, it should output each of the concrete vehicles and one 
behavior that it has inherited without any direct code manipulation

## Program Specifications
Your solution should include the following:
	- Have at least 3 different abstract classes
	- Have at least 3 layers of inheritance
	- Have at least 5 concrete vehicles
	- Have at least 2 abstract methods (make sure you override them)
	- Have at least 2 abstract Properties (make sure you override them)
	- Have at least 2 virtual methods (make sure you override at least one of them)
	- Have at least 2 virtual properties (make sure you override at least one of them)
	- Have at least 2 interfaces properly implemented onto classes (as described above)
	- Your (digital) drawing of your vehicle diagram should be clearly labeled

## Unit Tests
Adding additional tests with the following functionality: 
1. Test that the classes that implement the interface actually implement it
1. Test inheritance
1. Test polymorphism
	- Prove methods have been overridden
	- Prove that one of your concrete vehicles `is an` Vehicle

##Stretch Goals
no stretch goal for this lab

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
- 6pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	6       | Program runs as expected, no exceptions during execution, all requirements met |
	5       | Program meets all of the  functionality requirements described above (including tests). Program contains logic/process errors|
	4       | Program meets most of the functionality requirements described above (including tests). Program throws unhandled exceptions during execution |
	3       | Program missing most of the functionality requirements described above |
	2       | Missing Readme document // Readme document does not meet standards // Missing actual time CANVAS note |
	0       | No Submission or program does not compile/run. Build Errors. Missing Required Tests. Failing Tests |

- 3pts: Code meets industry standards
	- These points can only be awarded if you score at minimum a 4/6 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // method and variable names are appropriate // Selective and iterative statements are used appropriately, Fundamentals are properly executed // Clearly and cleanly commented using summary comments |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments // minimal or no commits |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // summary comments missing |
	0       | No Submission. Incomplete submission. Not Eligible |

- 1pt: Git workflow followed

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	1       | Git workflow properly followed. Frequent commits. Repo organized as directed. Pull Request exists and properly formatted. |
	0.5       | Git workflow mostly followed. infrequent commits. |
	0       | No Submission or git workflow not followed |

