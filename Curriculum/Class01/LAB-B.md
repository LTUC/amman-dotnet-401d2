![cf](http://i.imgur.com/7v5ASc8.png) Lab 01: Numbers Game
=====================================

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
- Include a `README.md` (contents described below)

## The Problem Domain
Within a new .NET Core console application, follow the instructions below to create  the program given the specifications. 

## Program Specifications

Within the `Program.cs` file, add the following methods described below.

For each type of generic exception that you have in your code, `throw` it back to the main method.
For all non-generic (specific exceptions), output the exception message to the console.

#### Main Method
This method is given to you. Do not change the method signature. 

1. The "Main" method should be:
	- ***static or instance***: static
	- ***return type***: void
	- ***parameters***: `string[] args`
2. The logic within this method should:
	1. Call the `Start()` method from `Main`.

3. Expected Exceptions:
	1. Generic Exception 
		- Let the user (nicely) know that they did something wrong. 
		- output the message of the exception to the console.

4. Include a `finally` that tells us that the program is completed

#### Start Method
1. The "Start" method should be
	- static
	- void return type
	- no parameters
2. The logic within the method should 
	1. prompt the user to "Enter a number greater than zero"
	2. Utilize the `ConvertToInt32()` method to convert the user's input to an integer
	3. Call the method `GetNumbers`(see below for requirements) and set the returning value to a new integer array
	4. After the integer array is populated, call the `AddNumbers` (see below for requirements), set the returning value to a new integer named `sum`. 
	5. After receiving the sum of all the numbers in the array, call the `GetAverage` (see requirements below) method and set the returning value to a new integer named `average`.
	6. Finally, Output to the console the details of all these values. Have your output be similar to the following example (Pay attention to line breaks!):
	```
	The array of numbers are: 4, 8, 15, 16, 23, 42
	The sum of all these numbers are: 108
	The average of these numbers is: 18
	```
3. Expected Exceptions:
	1. FormatException
	2. Generic Exception

#### GetNumbers Method
1. The "GetNumbers" method should be
	- static
	- return type: integer array
	- 1 parameter of an integer number
2. The logic within the method should
	1. instantiate a new integer array that is the same size as the parameter coming into the method
	2. iterate through the newly instantiated array that prompts the user to enter a specific number. Example: "Please enter a number 1/6" (indicate to the user what number they are inputting)
	3. Utilize the `ConvertToInt32` method to convert the user's input to an integer (Remember not to directly manipulate the user's input. store the response into a string first).
	4. Add the number just inputted into the array. 
	5. Repeat this process until all numbers have been requested and the array is filled. 
	6. Return the newly created array
3. Expected Exceptions:
	1. OverflowException
	2. IndexOutOfRangeException
	3. FormatException
	3. Generic Exception

#### AddNumbers Method
1. The method signature of GetNumbers should contain:
	- ***static or instance***: static
	- ***return type***: integer
	- ***parameters***: integer array
2. the logic within the method should:
	1. declare an integer variable named `sum`
	2. iterate through the array and populate the `sum` variable with the sum of all the numbers together
	3. Add the capability to `throw` a custom exception if the sum is less than 20, with the message "Value of {sum} is too low". (replace {sum} with the actual sum of the variable)
	4. return the sum
3. Expected Exceptions:
	1. none

#### GetAverage Method
1. The method signature of GetAverage should contain:
	- ***static or instance***: static
	- ***return type***: integer
	- ***parameters***: integer totalSum and an integer divisor (what you will be dividing by)
2. The logic within the method should:
	1. create a new integer name `quotient` that will hold the answer to the division problem
	2. set the value of `quotient` to the totalSum divided by the divisor.
	3. return the quotient.

3. Expected Exceptions:
	1. DivideByZero Exception
	2. Generic Exception


## Stretch Goals

## README

Provide setup documentation 

- **Comment your code.**
- Provide a readme that includes clear directions on setting up this program.
- Questions to Consider: 
	1. What is the purpose of the program?
	1. How do I run the program?
	1. What does the program look like? (visual)

## Rubric
- 7pts: Program meets all requirements described in Lab directions

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements described above // Program runs/compiles, but throws exceptions during execution | 
	3       | Program missing most of the functionality requirements described above // Program runs/compiles |
	2       | Missing Readme document // Readme document does not meet standards // Missing actual time CANVAS note |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awarded if you score at minimum a 4/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // method and variable names are appropriate // Selective and iterative statements are used appropriately, Fundamentals are properly executed // Clearly and cleanly commented // Frequent Commits |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments // minimal or no commits |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |

