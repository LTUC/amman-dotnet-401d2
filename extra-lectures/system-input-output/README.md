# Lab 03: Word Guess Game

## The Problem Domain
Read the entire problem domain carefully before you begin

Your client has requested that a "Word Guess Game" be built. The main idea of the game is she must guess what a mystery word is by inputting (1) letter at a time.  The game should save all of her guesses (both correct and incorrect)  throughout each session of the game, along with the ability to show her how many letters out of the word she has guessed correctly.

Each time a new game session starts, the mystery word chosen should come from the external text file that holds a list of all the possible words. The program should randomly select one of the words in this file as the new mystery word for the next game round. This bank of words should be editable by your client so that she may view, add, and delete words as she wishes. She expects the game to have a simple interface that allows her to navigate across the game. Some actions that she wants available within her interface are:

1. View All words in the list
1. Add a word
1. Remove a word
1. Play Game

Using everything you've learned up to this point, create a word guess game that will meet all of the requirements described in the scenario above.

## Program Specifications
**Read ALL of the specifications carefully before you begin....**

### Plan

Create a domain model that outlines the functionality of your application. Include in your domain model all of the methods you plan on using and how they are utilized and called within the application. Here are a couple of resources if you need a refresher on domain modeling:

1. [Introduction to Domain Modeling](https://medium.com/@olegchursin/a-brief-introduction-to-domain-modeling-862a30b38353)
1. [Domain Modeling](https://www.scaledagileframework.com/domain-modeling/)

Some methods that you should consider creating with your application, ***at minimum***:

1. Main Method
    - This will be the first method that runs in the program. Consider calling the `UserInterface()` method from this method.
1. UserInterface
   - Asks the user what action they should take
1. ViewWords
   - Reads the words in from the external file and outputs them to the console
1. RemoveWords
   - Gives the user the ability to remove one of the words in the list
1. AddWord
   - Add a new word to the list
1. ExitGame
   - End the game
1. StartGame*
   - Actual game logic of guessing a letter of the mystery word

*Your StartGame method will likely need to be broken up into smaller methods. Be sure that these additional methods are represented in your domain modeling image

Place your domain model drawing in your project README with a short description/overview of your functionality.

### Implement

Your solution should include, at minimum, the following functionality:

1. When playing a game, *randomly* select one of the words in the external file to output to the console for the user to guess (Use the `Random` class)
1. You should have a record of the letters they have attempted so far.
1. If they guess a correct letter, display that letter in the console for them to refer back to when making guesses (i.e. C _ D E)
1. Your program does not need to be case sensitive.
1. Errors should be handled through Exception handling
1. ***Do not create external classes to accomplish this task. All code should live in the `Program.cs` file***
1. Stay within scope, you may use the methods/classes listed below if desired.
1. Once the game is completed, the user should be presented with the option to "Play again" (a new random word is generated), or "Exit" (the program terminates)
1. The user should only be allowed to guess only 1 letter at a time. Do not make it so that they can input the whole alphabet and get the answer.

## Guidance
This lab will test and practice your analytical and problem breakdown skills. It will also be your first approach at system design. Look at the **base functionality** first, and then build from there. Here are the first few (suggested) steps. You do not have to follow these steps but it's a good place to start if you get lost.

1. Draw out within your domain model the methods that you will need and how they interact with each other. Once you have your plan, start creating these methods within your project itself. Leave summary comments above each method that provides a highlight of what the method should do.
1. In addition, add comments within each method that outlines specifics of what should be done.
1. When you begin coding, start with the System.IO basics
	- Be sure you can create a file (with default words), read the file in, Add new words to the file, and delete the file. Create this logic first in the respective methods.
1. After reading in the words from the external file, see if you can get a word to "randomly" be chosen from the list of words you read in.
1. Implement the user input feature by having the user "guess" a letter. Confirm that you can accurately determine if the letter the user inputted exists in the selected mystery word. Don't worry about the word being hidden yet, that can happen later.
1. Next, add some logic that could potentially "make" something happen if the correct letter is guessed?

.... (more steps)

.... (more steps)

Make user interface last.

Focus on the functionality, and build your application out from there.


## Unit Tests
Test that your program has the following functionality:
1. Test that a file can be updated with a new word
	- Add a new word and then confirm the word exists in the file
1. Test that you can retrieve all words from the file
	- Add words to a file and confirm that file contains the same number of words as you expected
1. Test that the word chosen can accurately detect if the letter exists in the word (test that a letter does exist and does not exist)


## Stretch Goals
No stretch goals for this lab

## Additional Resources
1. To check if a character or a subset exists in a string, use the `Contains()` method.
	- [.Contains()](https://msdn.microsoft.com/en-us/library/dy85x1sa(v=vs.110).aspx){:target="_blank"}
1. To randomly pick a number between 0 - n, use the `Random` Class.
	- [Random Class](https://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx){:target="_blank"}
1. To get an array of characters of a specific word.
	- [ToCharArray](https://docs.microsoft.com/en-us/dotnet/api/system.string.tochararray?view=netframework-4.7.2#System_String_ToCharArray){:target="_blank"}
1. Ignore Casing `StringComparison.CurrentCultureIgnoreCase`

## README
**A Readme is a requirement. No Readme == No Grade.**
Here are the requirements for a valid readme:

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.

Your job is to

1. tell them what it is (with context, provide a summary)
1. show them what it looks like in action (Visuals)
1. show them how they use it (Step by step directions, "Happy Path" walk through)
1. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

Refer to the README templates in the class repo `Resources` folder for an example.
- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"}


## Rubric

The lab rubric can be found [HERE](../../resources/rubric){:target="_blank"}

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back to main
- Submit a link to your PR in canvas
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
