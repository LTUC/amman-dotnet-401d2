![cf](http://i.imgur.com/7v5ASc8.png) Lab 14: 
=====================================

## To Submit this Assignment
- Create a new branch named `NAME-LAB14` in your `AsyncInn` repo
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- Include a `README.md` (contents described below)

## Directions

Continue with your AsyncInn Hotel Management System. For Today's branch, focus on working within the existing code base that was scaffolded out (If you chose to scaffold). 

1. Add data annotations to your existing models to validate basic user input fields as appropriate.
2. Seed your database with at least 5 default Hotel Locations, 6 Room Types, and 5 Amenities. Do not make any seeded associations with `HotelRoom` or `RoomAmenities`.
3. Update dropdown lists to include the `Layout` enum, and associations between the `Room` and `Hotel`, as well as the `Room` and `Amenities`. Be sure to display user friendly information in your views. 
4. Remove the ability to edit `RoomAmenties`
	- You should only have the option to create associations, and delete associations.
	- This will require the removal of the actions and view pages from the scaffold code.
	- You may have to leverage URL parameters to properly remove the right combination (`mysite.com?Room=123&Amenity=2`)
5. Modify the existing code to edit a `HotelRoom`.
	 - You may have to leverage URL parameters to properly navigate to an edit action for this entity. 
6. Based off of the readings from day 14, either utilize bootstrap (download it into your project from NuGet), or remove all bootstrap specific classes in your HTML. (clean it up!)
7. Add your own styling  to the Hotel Creation page and Room creation page. 

## Tests
No Tests are required for this lab. I **strongly** encourage you to research how to write tests for a .NET Core MVC application. If able, attempt to write some tests, as they will eventually be required.

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
	4       | Program meets most of the functionality requirements descibed above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	2       | Readme Document does not meet minimum standards |
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
