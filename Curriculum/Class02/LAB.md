![cf](http://i.imgur.com/7v5ASc8.png) Lab 2: Unit Testing
=====================================

## To Submit this Assignment

- fork this repository
- create a new branch named `lab02-`; + `<your name>` **e.g.** `lab02-amanda`
- write your code
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas
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
	- Exception Handling (try/catch/finally)
	- Keep asking the user to choose a transaction until they choose to 'exit' the application
- A few things to keep in mind:
	- Make sure the user can't go below a zero balance
	- You cannot unit test console outputs. 
	- Make sure your methods are just returning values and not reading input from the console. 

- **Stay within scope of the what we have learned so far in the class.**
	- if we have not officially learned the concept you are trying to implement, then don't use it. 
	- Ask the instructor or TA if you have any questions about the scope. 

### Unit Tests
1. Provide unit tests for your ATM.
2. For every method/action (that does not require user input), there should be a passing valid input, and a passing invalid input.
3. **A failing test, is not a valid test** - even if the failure is expected. 

### Stretch

- Record each transaction the user records and when they exit, provide a receipt for every transaction they conducted. 

## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo `Resources` folder for an example. 
- [Reference](https://github.com/noffle/art-of-readme)


## Rubric

- 7pts: Program meets all requirements described in Lab directions
- 3pts: Code meets industry standards
- **Readme.md AND tests required for submission. Missing readme document and tests will result in a best score of 2/10**
