![cf](http://i.imgur.com/7v5ASc8.png) Lab 3 : Word Guess Game
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a directory named `lab-#`; + `<your name>` **e.g.** `lab03-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas

## Directions
The directions below mock what an actual client requirements document may contain. It is your job, as a developer, to interpret these directions and 
create a program based on what is stated below.

Josie Cat has requested that a "Word Guess Game" be built. The main idea of the game is she must guess what a mystery word is by inputitng 
either (1) letter or a sequence of letters at a time. The game should save all of her guesses (both correct and incorrect) throughout each session of the game,
along with the ability to show her how many letters out of the word she has guessed correctly. 

Each time a new game session starts, the mystery word chosen should 
come from an external text file that randomly selects one of the words listed. This file should be editable by Josie so that 
she may view, add, and delete words as she wishes. She expects the game to have a simple user interface that is easy to navigate. 

Using everything you've learned and researched up to this point, create a word guess
game that will meet all of the requiements described in the user story above. 
 

## ReadMe
- Your readme should include the following information:
	- How long did it take you to complete this assignment?
	- What did you struggle with? Why? How did you solve?
	- What did you learn during this assignment?
    - What resources did you utilize for this assingment?

## Components
- The program (should) contain the following
    - Methods for each action (Home navigation, View words in the text file, add a word to the text file, Remove words from a text file, exit the game, start a new game)
    - When playing a game, you should bring in all the words that exist in the text file, and *randomly* select one of the words to output to the conole for the user to guess
    - You should have a record the letters they have attempted so far
    - If they guess a correct letter, display that letter in the console for them to refer back to whebn making guesses (i.e. C _ T S )
    - Errors should be handled through try/catch statements
    - You may use any shortcuts or 'helper' methods in this project. Do not create external classes to accomplish this task.

## Rubric
- 3pts: Application runs without any errors
- 2pt: System.IO // CRUD file manipulation
- 2pt: Output user response with game progress
- 2pt: Readme included with answers to questions
- 1pt: Simple user interface

