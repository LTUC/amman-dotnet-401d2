![cf](http://i.imgur.com/7v5ASc8.png) Lab 02: Unit Testing
=====================================

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
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
- Create a bank "ATM" program within a console application with VS2017


## Program Specificaitons
- Your solution should include the following:
    - Main method
	- Testable external methods
	- User interface that prompts the user for standard ATM operations
		- View Balance
		- Withdraw Money
		- Add Money (not standard, but for this exercise it will be....)
=	- Keep asking the user to choose a transaction until they choose to 'exit' the application
	- Exception Handling. Implement `try`, `catch`, `finally` and a `throw` within your program.
- A few things to keep in mind:
	- Make sure the user can't go below a zero balance
	- You **cannot** unit test console `WriteLine` or `Readline`s. 
	- Make sure your methods are just returning values and not reading input from the console. 

- When running your application, it should activate the user interface without any direct code manipulation

- **Stay within scope of the what we have learned so far in the class.**
	- if we have not officially learned the concept you are trying to implement, then don't use it. 
	- Ask the instructor or TA if you have any questions about the scope. 


## Unit Tests
Test that your program has the following functionality:
1. Test every method/action (that does not require user input); there should be a passing valid input, and a passing invalid input.
- Have at least 2 tests for every non-void method.
- **A failing test, is not a valid test** - even if the failure is expected. 


## Stretch Goals
- Record each transaction the user records and when they exit, provide a receipt for every transaction they conducted. 


## README
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
	- These points are only awardable if you score at minimum a 4/6 on above criteria

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
