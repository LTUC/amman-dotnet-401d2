![cf](http://i.imgur.com/7v5ASc8.png) Class 02:Exception Handling & Debugging
=====================================

## Overview
* Today is solely focusing on how students should be approaching the setup and presentation of their assignments. 
* Use XUnit when unit testing within C#. 
* The documentation portion shows an example of what the readme documentation should look like, as well as comments within code.


## Learning Objectives
* Students will be able to successfully create unit tests for their C# console applications using the Red/Green/Refactor approach. 
* The students will understand and implement code coverage within their programs when testing
* Students will include intuitive comments within their code
* Students will setup readme documentation for each assignment given a specific format

# Lecture Outline

## Unit Tests TDD

### What are Unit tests?
	- Used to verify your code is working as expected
	- Defend your position - Used as a justification
	- Code Coverage - aim at 90%. 

### Demo
	- Code Challenge: FizzBuzz
		- recreate using the TDD approach
		- Show how to install NuGet packages and add XUnit

#### Demo Steps:
1. What are Unit Tests?
	- Why do we need them?
1. Display this RED/GREEN/REFACTOR article in class: General Code Kata reasoning [here](http://www.peterprovost.org/blog/2012/05/02/kata-the-only-way-to-learn-tdd/)
1. What does Red/Green/Refactor mean?
	- When you are in red, the only thing you can do is "Make the test pass"
	- When you are in green you have two choices - Refactor, or write a new test

1. Create a new test solution in Visual Studio.
1. Install the xUnit NuGet package on Demo solution (Confirm the xunit versions are the same on the test solution and original solution)
1. Break down what exactly we are testing. (Do a visual or PsuedoCode, if number is divisible by 3, return "Fizz", if 5, return "Buzz", if both "FizzBuzz" else if neither, return number.)
1. Create our first test in the Test solution, Call it `CanReturn1` < -- This is because we are assuming that we need to at least return a number. 
	- This test will fail at first because we don't have any code in our method to return any number.
	- After fail, Create/Update the Conver() method in the main solution to return jsut "1";
1. Create another test that will Return2, Return4. Set the assert to expect 2. 
1. Create a test that will accept BuzzFor3(); 
	- Update Convert Method to say if == 3 then return buzz
1. Create a test for 6. See that it fails, update the convert to be % 3 ==0;
1. After about 4 of these, introduce the "Theory" concept. 
	- FACTS - statements that are always true
	- Theories - statements that are true given a set of data. 

1. Focus on Just the Number returns
	1. Create a `NumberTest` test -- No paramenters
	1. Add theory above the method -- see the error requiring a parementer - add an int paramater. 
	1. Instead of doing the expected result as the parameter.tostring() (too close to implementation), just add a second paramter to bring in expected result.
	1. consolidate the other tests into one with different theories. 

1. Focus on logic for ReturnBuzzFor5() Test, fix the convert method accordingly
1. Do the same for FizzBuzz Return. Make it modulus of 15 == 0. Put it at the bottom of the if statements. see that it doesn't get hit. move it to the top. 


## Documentation
	- What is it?

### What is Documentation?
	- Why do we use it?
	- What are the different types?
		- Comments
		- README in github
	- How do we create it?
		- Example of Readme
		- Example of Comments

# Resources

# Assignments

## Readings
- [XUnit Documentation](http://xunit.github.io/#documentation)
- [Art of Readme](https://github.com/noffle/art-of-readme)
- [ReadMe Best Practices](https://github.com/jehna/readme-best-practices)

## Lab
- (2) Code Katas
	- Supermarket Challenge
	- War Card Game Challenge

- Stretch Goal - Additonal Katas

## Coding Challenge
- Reverse String challenge
 