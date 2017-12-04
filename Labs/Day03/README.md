![cf](http://i.imgur.com/7v5ASc8.png) Lab 3 : System.IO - Word Guess Game
=====================================

## To Submit this Assignment
- fork this repository
- create a new branch named `lab01-`; + `<your name>` **e.g.** `lab01-amanda`
- write your code
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas
- Include a Readme.md (contents described below)

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


## Program Components
- The program (should) contain the following
    - Methods for each action (Home navigation, View words in the text file, add a word to the text file, Remove words from a text file, exit the game, start a new game)
    - When playing a game, you should bring in all the words that exist in the text file, and *randomly* select one of the words to output to the conole for the user to guess
    - You should have a record the letters they have attempted so far
    - If they guess a correct letter, display that letter in the console for them to refer back to when making guesses (i.e. C _ T S )
    - Errors should be handled through Exception handling
    - You may use any shortcuts or 'helper' methods in this project. Do not create external classes to accomplish this task.


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
- 3pts: Code meets industry standards