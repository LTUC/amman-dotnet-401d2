![cf](http://i.imgur.com/7v5ASc8.png) Lab 7: Collections
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

## Directions
- Create a custom generic collection named `Deck<T>`.
- As we learned, under the hood, generic collections are arrays. Utilizing this concept, create a new generic collection (`Deck<T>`) that dynamically resizes an array for all the specified methods described below. (Note: Use an array, not a collection).
- Your Generic collection should hold Cards. (You will need to create a custom Card class)
- Create an Enum to hold the different card suits (Hearts, Diamonds, Spades, Clubs)
- The methods within your Deck<T> class should contain at minimum:
	1. Add
	2. Remove
	3. ReturnSuit
		- This method will return all of the cards in that suit within the deck.


- (stretch) In your `Program.cs` have a method named `Deal` that gets called from `Main` that evenly distributes the deck of cards amongst 2 players. the dealer keeps any remaining. Output to the console the cards each player has and what the dealer has kept. **NOTE: The dealer is NOT a player**.

- When running your application, it should activate a console that outputs each of the 
cards added to the deck, information about what card was removed, and then proof it is gone 
without any direct code manipulation from the grader. 


Possible example below:

```
The cards in your deck are:
Ace Diamonds, K Hearts, Q Diamonds, 10 Spades, 6 Hearts.....

Removing K Hearts

Cards left: 
Ace Diamonds, Q Diamonds, 10 Spades, 6 Hearts.....
```

Your `Program.cs` Main method should demonstrate:
1. The instantiation of the generic collection. 
2. The instantiation of at least 10 cards with values
3. Adding and removing cards from the Deck<T>
4. Proof that the ShowSuite method works 
5. Use a `foreach` loop on your created Deck, and output each of the cards to the console. 

## Tests
Your tests should cover the following functionality:
1. Add a card to your deck
1. Getter/Setters of your properties from your `Card` class
1. Remove a card from your deck that exists
1. Remove a card from your deck that does not exist

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
	2       | Missing Readme document // Readme document does not meet standards // Missing actual time CANVAS note |
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