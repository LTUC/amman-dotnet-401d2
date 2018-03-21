![cf](http://i.imgur.com/7v5ASc8.png) Lab 3 : Word Guess Game
=====================================

## To Submit this Assignment
- fork this repository
- create a new branch named `lab03-`; + `<your name>` **e.g.** `lab03-amanda`
- write your code
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas
- Include a Readme.md (contents described below)

## Directions

**Read ALL of the directions carefully before you begin....**

The directions below mock a scenario that an actual client may request. It is your job, as a developer, to interpret these directions and 
create a program based on what is stated below.

Josie Cat has requested that a "Word Guess Game" be built. The main idea of the game is she must guess what a mystery word is by inputting 
either (1) letter or a sequence of letters at a time (at most, 2). The game should save all of her guesses (both correct and incorrect) throughout each session of the game,
along with the ability to show her how many letters out of the word she has guessed correctly. 

Each time a new game session starts, the mystery word chosen should come from an external text file that randomly selects one of the words listed. 
This bank of words should be editable by Josie so that she may view, add, and delete words as she wishes. She expects the game to have a simple user interface that is easy to navigate. 

Using everything you've learned up to this point, create a word guess
game that will meet all of the requiements described in the user story above. 


## Program Components
- The program (should) contain the following
    - Methods for each action (Home navigation, View words in the external file, add a word to the external file, Remove words from a text file, exit the game, start a new game)
    - When playing a game, *randomly* select one of the words to output to the console for the user to guess
    - You should have a record of the letters they have attempted so far
    - If they guess a correct letter, display that letter in the console for them to refer back to when making guesses (i.e. C _ T S )
    - Errors should be handled through Exception handling
    - You may use any shortcuts or 'helper' methods in this project. Do not create external classes to accomplish this task. Stay within scope, you may use the the methods/classes listed below if desired.
	- Once the game is completed, the user should be presented with the option to "Play again" (a new random word is generated), or "Exit" (the program terminates)
	- the user should only be allowed to guess, **at most**, 2 letters at a time. Do not make it so that they can input the whole alphabet and get the answer. 

## Additional Resources
1. To check if a character or a subset exists in a string, use the Contains() method. 
	- [.Contains()](https://msdn.microsoft.com/en-us/library/dy85x1sa(v=vs.110).aspx)
2. To ramdonly pick a number between 0 -> N, use the Random Class.
	- [Random Class](https://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx)


## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to
1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. 
Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo for an example. 
- [Reference](https://github.com/noffle/art-of-readme)

## Rubric
- 7pts: Program meets all requirements described in Lab directions

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program runs/compiles, but throws exceptions during execution |
	2       | Missing tests // tests are not passing // not enough valid tests |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors. |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |
