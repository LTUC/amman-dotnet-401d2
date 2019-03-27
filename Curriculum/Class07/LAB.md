![cf](http://i.imgur.com/7v5ASc8.png) Lab 7: Phil's Lending Library 
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
Build out a Lending Library! Create your own Lending Library filled with Books. Make your Lending Library a generic collection, and your `Book` a separate class that holds appropriate properties and behaviors. In addition, remove items from the newly created library and place them into another generic collection (such as a `List<T>`) to prove the movement of the individual objects. 


## Program Specifications
- Your solution should include the following in your `Program.cs` file:
1. The instantiation of the generic collection. 
2. The instantiation of at *least 10 books* with the following properties
	- Title
	- Author (Make Author it's own class with the appropriate properties)
	- Genre (This should be an enum)
3. Ability to add and remove books from the `Library<T>`
4. Use a `foreach` loop on your created Library, and output each of the books to the console. 
5. Call to the `Borrow()` method following the directions from below. 


## Guidance
- Create a custom generic collection named `Library<T>`.
- As we learned, under the hood, generic collections are arrays. Utilizing this concept, create a new generic collection (`Library<T>`) that dynamically resizes an array for all the specified methods described below.
- Your Generic collection should hold Books. (You will need to create a custom Book class)
- Create an Enum to hold the different genres of book types
- The methods within your `Library<T>` class should contain at minimum:
	1. Add
	2. Remove
	3. Count (the total number of books in the library)


- In your `Program.cs` have a method named `Borrow` that gets called from `Main`. The `Borrow` method should output to the console all the books in the library, as well as distribute books amoungst two other standard generic `List<T>`s. Output to the console the books that are contained in each of the other two lists. 

- When running your application, it should activate a console that outputs an example for each of the custom methods within your Library. It should show what Books were added to the Library, information about what Book was removed, and then proof it is gone, as well as a final count of the number of books without any direct code manipulation from the grader. In addition to activating the `Borrow()` method. 


## Unit Tests
Test that your program has the following functionality:
1. Add a Book to your Library that exists
2. Remove a book from your library
3. Cannot remove a book from the library that doesn't exist. 
4. Getter/Setters of your properties from your `Book` class
5. Getter/Setters of your properties from your `Author` class.
6. Accurate count of books within the library
7. One edge case of your choice

## Stretch Goals
1. A method with the signature of: `public bool IsAvailable(T book)` that determines if a book is available. (Hint: use the `.Equals()` helper)
2. Add the ability to Find a specific book by "Author" or "Title" of the book.(You may need to set a restrction on `T`)

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
