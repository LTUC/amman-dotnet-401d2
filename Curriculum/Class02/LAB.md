![cf](http://i.imgur.com/7v5ASc8.png) Lab 2: Unit Testing
=====================================

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- write your code
- push to your repository
- submit a link to your Repo in canvas
- Include a Readme.md (contents described below)

## Directions

### The Problem Domain

- Create a bank "ATM" machine within a console application with VS2017
- Your solution should include the following:
    - Main method
	- Testable external methods
	- User interface that prompts the user for standard ATM operations
		- View Balance
		- Withdraw Money
		- Add Money (not standard, but for this exercise it will be....)
=	- Keep asking the user to choose a transaction until they choose to 'exit' the application
- A few things to keep in mind:
	- Make sure the user can't go below a zero balance
	- You cannot unit test console outputs or readlines. 
	- Make sure your methods are just returning values and not reading input from the console. 

- **Stay within scope of the what we have learned so far in the class.**
	- if we have not officially learned the concept you are trying to implement, then don't use it. 
	- Ask the instructor or TA if you have any questions about the scope. 

### Unit Tests
1. Provide unit tests for your ATM.
2. For every method/action (that does not require user input), there should be a passing valid input, and a passing invalid input.
3. Have at least 2 tests for every non-void method.
3. **A failing test, is not a valid test** - even if the failure is expected. 

### Stretch

- Record each transaction the user records and when they exit, provide a receipt for every transaction they conducted. 

## ReadMe

**A Readme is a requirement. No Readme == No Grade.** <br />
Here are the requirements for a valid readme: <br />

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context, provide a summary)
2. show them what it looks like in action (Visuals)
3. show them how they use it (Step by step directions, "Happy Path" walk through)
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo `Resources` folder for an example. 
- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"} 


## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements descibed above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |
