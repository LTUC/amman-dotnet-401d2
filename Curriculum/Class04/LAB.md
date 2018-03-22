![cf](http://i.imgur.com/7v5ASc8.png) Lab 4: Tic-Tac-Toe
=====================================

## To Submit this Assignment
- fork this repository
- create a new branch named `lab04-`; + `<your name>` **e.g.** `lab04-amanda`
- write your code
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas
- Include a Readme.md (contents described below)

## Directions
In a new Console Applicaiton within Visual Studio, create a Tic-Tac-Toe game. 

Create your program to follow the traditional Tic-Tac-Toe rules. This includes (but not limited to...):
This game will allow for 2 players to play side by side (on the same screen/board) and alternate
between selecting their positions on the board. 

A winner is determined when either Player 1 or Player 2 has succesfully placed 3 of their markers either in a row
horizontally or vertically. 

When the game is over, ask the user if they want to play again. 

If the user says yes -> start a new game
if the user says no -> terminate the program

## Program Components
Create a game board that looks like this:
```
|1||2||3|
|4||5||6|
|7||8||9|
```
The numbers in each of the squares will indicate the position number. Prompt the user to select which position they wish to 
play and then replace that position with either an `X` or an `O`.

A winning board may look like this (O Wins!):

```
|X||X||O|
|4||O||X|
|O||X||9|
```
Remember that Tic-Tac-Toe is a 2 player game, so be sure to "switch" between players. Make it known to the user that
their turn is over and it's time for the next players turn. You will have both play on the same board. 

 Here are a couple of ideas for different classes that you can have. You are not required to have these classes, but it may be a good start for guidance...
- Game Board (this should construct the board after every turn with it's new state)
- Player (This will hold the players information such as name or marker, in addition to any actions that user may take)

Be sure to check for a winner after each turn. Be aware that it is possible to have a tie/draw if no winner can be determined and all 
marks on the board are occupied. 

Stay within scope of this project. Please only use concepts and resources that we have covered so far in previous labs/lectures/assigned prework. 
If you are unsure if it is within scope, please ask a TA or instructor.

## Additional Resources
Review/research these resources to assist you in the construction of your program:

- [Two Dimensional Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays)

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
	5       | Program runs/compiles, Program contains logic/process errors|
	4       | Program runs/compiles, but throws exceptions during execution |
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
||O|
|4||O||X|
|O||X||9|

Remember that Tic-Tac-Toe is a 2 player game, so be sure to "switch" between players. Make it known to the user that
their turn is over and it's time for the next players turn. You will have both play on the same board. 

 Here are a couple of ideas for different classes that you can have. You are not required to have these classes, but it may be a good start for guidance...
- Game Board (this should construct the board after every turn with it's new state)
- Player (This will hold the players information such as name or marker, in addition to any actions that user may take)

Be sure to check for a winner after each turn. Be aware that it is possible to have a tie/draw if no winner can be determined and all 
marks on the board are occupied. 

Stay within scope of this project. Please only use concepts and resources that we have covered so far in previous labs/lectures/assigned prework. 
If you are unsure if it is within scope, please ask a TA or instructor.

## Additional Resources
Review/research these resources to assist you in the construction of your program:

- 2 Dimensional Arrays

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
	5       | Program runs/compiles, Program contains logic/process errors|
	4       | Program runs/compiles, but throws exceptions during execution |
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
