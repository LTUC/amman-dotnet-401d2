![cf](http://i.imgur.com/7v5ASc8.png) Lab 03: Word Guess Game
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
- Include a `README.md` (contents described below)

## Directions

**Read ALL of the directions carefully before you begin....**

The directions below mock a scenario of a request from a client. It is your job, 
as a developer, to interpret these directions and 
create a program based on what is stated below.

Josie Cat has requested that a "Word Guess Game" be built. The main idea of the game is 
she must guess what a mystery word is by inputting (1) letter at a time.  The game should save all of her guesses (both correct and incorrect) 
 throughout each session of the game, along with the ability to show her how many letters out of the word she has guessed correctly. 

Each time a new game session starts, the mystery word chosen should come from an external text 
file that randomly selects one of the words listed. 
This bank of words should be editable by Josie so that she may view, add, and delete words as 
she wishes. She expects the game to have a simple user interface that is easy to navigate. 

Using everything you've learned up to this point, create a word guess
game that will meet all of the requirements described in the user story above. 


## Program Components
- The program (should) contain the following
    - Methods for each action (suggestions: Home navigation, View words in the external file, add a word to the external file, Remove words from a text file, exit the game, start a new game)
    - When playing a game, *randomly* select one of the words to output to the console for the user to guess (Use the `Random` class)
    - You should have a record of the letters they have attempted so far
    - If they guess a correct letter, display that letter in the console for them to refer back to when making guesses (i.e. C _ T S )
	- Your program does not need to be case sensitive. 
    - Errors should be handled through Exception handling
	- Do not create external classes to accomplish this task.
	- Stay within scope, you may use the methods/classes listed below if desired.
	- Once the game is completed, the user should be presented with the option to "Play again" (a new random word is generated), or "Exit" (the program terminates)
	- the user should only be allowed to guess only 1 letter at a time. Do not make it so that they can input the whole alphabet and get the answer. 
	
- When running your application, it should activate the user interface without any direct code manipulation

## Breakdown
This lab will test and practice your analytic and problem breakdown skills. Look at the **base functionality** first, and then build from there. I will give you the first few (suggested) steps, and see if you can continue from there. You do not have to follow these steps but it's a good place to start if you get lost. 

1. Get your System.IO working
	- Be sure you can create a file (with default words), read the file in, Add new words to the file, and delete the file. 
2. See if you can get a word to get "randomly" chosen from the list of words you read in
3. Given user input, can you accurately see if a letter exists in the "mystery" word (the word does not have to be hidden yet)
4. Can you make something "happen" if they guess the right word?

.... (more steps)

.... (more steps)

Make user interface last. 


## Tests
Test that your app has the following functionality:
1. Test that a file can be created
1. Test that a file can be updated
1. Test that a file can be deleted
1. Test that a word can be added to a file
1. Test that you can retrieve all words from the file
1. Test that the word chosen can accurately detect if the letter exists in the word (test that a letter does exist and does not exist)

## Additional Resources
1. To check if a character or a subset exists in a string, use the `Contains()` method. 
	- [.Contains()](https://msdn.microsoft.com/en-us/library/dy85x1sa(v=vs.110).aspx){:target="_blank"} 
2. To randomly pick a number between 0 - n, use the `Random` Class.
	- [Random Class](https://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx){:target="_blank"} 
3. To get an array of characters of a specific word. 
	- [ToCharArray](https://docs.microsoft.com/en-us/dotnet/api/system.string.tochararray?view=netframework-4.7.2#System_String_ToCharArray){:target="_blank"} 
4. Ignore Casing `StringComparison.CurrentCultureIgnoreCase`


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
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements described above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements described above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // method and variable names are appropriate // Selective and iterative statements are used appropriately, Fundamentals are properly executed // Clearly and cleanly commented // Frequent Commits |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments // minimal or no commits |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |