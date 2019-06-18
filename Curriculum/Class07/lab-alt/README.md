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


## The Problem Domain
Build a program that contains a deck of cards, with expected methods for manipulating the deck.


##Program Specifications
- Your solution should include the following:
1. The instantiation of the generic collection. 
2. The instantiation of at *least 10 cards* with values
3. Adding and removing cards from the Deck<T>
4. Use a `foreach` loop on your created Deck, and output each of the cards to the console. 
5. Call to the `Deal()` method following the directions from above. 


##Guidance
- Create a custom generic collection named `Deck<T>`.
- As we learned, under the hood, generic collections are arrays. Utilizing this concept, create a new generic collection (`Deck<T>`) that dynamically resizes an array for all the specified methods described below. (*Do not use a collection within your `Deck` class).
- Your Generic collection should hold Cards. (You will need to create a custom Card class)
- Create an Enum to hold the different card suits (Hearts, Diamonds, Spades, Clubs)
- The methods within your Deck<T> class should contain at minimum:
	1. Add
	2. Remove
	3. Count (the total number of cards in the deck)

- In your `Program.cs` have a method named `Deal` that gets called from `Main` that evenly distributes the deck of cards amongst 2 players decks. the Dealer Deck should keeps any remaining cards (if any). Output to the console the cards each player has and what the Dealer Deck has kept.

- When running your application, it should activate a console that outputs an example for each of the custom methods within your deck. It should show what cards were added to the deck, information about what card was removed, and then proof it is gone, as well as a final count of the number of cards without any direct code manipulation from the grader. 


Possible example below:

```
The cards in your deck are:
Ace Diamonds, K Hearts, Q Diamonds, 10 Spades, 6 Hearts.....

Removing K Hearts

Cards left: 4 
Ace Diamonds, Q Diamonds, 10 Spades, 6 Hearts.....
```

```
Player 1 Deck: Empty
Player 2 Deck: Empty
Dealer Deck: Ace Diamonds, K Hearts, Q Diamonds, 10 Spades, 6 Hearts

(Distributing Deck)

Player 1 Deck: Ace Diamonds, Q Diamonds
Player 2 Deck: King Hearts, 10 Spades
Dealer Deck: 6 Hearts

```



## Unit Tests
Test that your program has the following functionality:
1. Add a card to your deck
2. Getter/Setters of your properties from your `Card` class
3. Remove a card from your deck that exists
4. Cannot remove a card from your deck that does not exist

##Stretch Goals


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

The lab rubric can be found [HERE](../Resources/rubric){:target="_blank"} 