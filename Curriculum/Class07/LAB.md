![cf](http://i.imgur.com/7v5ASc8.png) Lab 7 : Collections
=====================================

## To Submit this Assignment
- fork this repository
- create a new branch named `lab07-`; + `<your name>` **e.g.** `lab07-amanda`
- write your code
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas
- Include a Readme.md (contents described below)

## Directions
Create a custom generic collection named `Deck<T>`.
Your Generic collection should hold Cards. (You will need to create a custom Card class) <br />
Create an Enum to hold the different card suites (Hearts, Diamonds, Spades, Clubs)
The methods within your Deck<T> class should contain at minimum:
1. Add
2. Remove
3. Shuffle
	- The shuffle logic will randomize the index of each of the items in the generic Deck<T> object

Your `Program.cs` Main method should demonstrate:
1. the instantiation of the generic collection. 
2. the instantiation of at least 15 cards with values
3. Adding and removing cards frm the Deck<T>
4. Proof that the shuffling method workds 
	- Have a method in your `Program` class named `Deal` that brings in the Deck. ouput the cards, shuffle, then output the cards again. 
5. Use a Foreach loop on your created Deck, and output each of the cards to the console. 

Unit tests are still required. 

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
- [Reference](https://github.com/noffle/art-of-readme)

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
