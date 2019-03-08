![cf](http://i.imgur.com/7v5ASc8.png) Lab : Dependency Injection

=====================================

## To Submit this Assignment

- Create a new branch named `NAME-DependencyInjection` in your `AsyncInn` repo
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)


## The Problem Domain
Continue working on your hotel management application.  As a developer, you would like to follow modern design principles by implementing the repository and singleton design patterns, and by using dependency injection.


## Application Specifications
- Your application should include the following:
1. 3 new interfaces
2. All services registered in your `Startup.cs` class
3. 3 new "services" that implement each of the interfaces
4. You DbContext injected into each of the interfaces
5. Your interfaces injected into your controllers
6. Functionality of all `Create` and `Index` actions
7. Functionality of the `Edit` and `Delete` actions in your `Hotels` `Rooms` and `Amenities` pages.

## Guidance
- Read all the directions and specs, in it's entirety, before starting the lab.
Building off of your current project for the `AsyncInn`:
1. Implement the repository design pattern and the singleton design pattern using dependency injection into your current code base
2. Create three interfaces to contract minimum CRUD operations (with the future services) that are required for functionality and maintenance of Hotels, Rooms, and Amenities. 
3. Build out a service for each of the interfaces and implement them appropriately.
4. Within each service, don't forget to inject the your `DbContext` into your services, so that you have access to the database.
5. Register each of the services with the appropriate Dependency Injection Lifecycle in the `Startup.cs` class.
6. Refactor the `RoomsController`, `HotelsController`, and `AmenitiesController` to utilize the newly created services. Remove the need for the database in the controllers, inject the services as needed, and keep the controllers "loosely coupled" by offloading the CRUD functionality to the services you previously defined. 
7. Confirm that all of your `Index` and `Create` actions still work after your refactor
8. Confirm that your `Edit` and `Delete` actions still function as expected in your `Rooms`, `Hotels`, and `Amenities` controllers as expected after your refactor. 


## Tests
- There are no Tests required for this assignment.

I **strongly** encourage you to research how to write tests for a .NET Core MVC application. Attempt to write some tests, as they will eventually be required.  Research, start here: [Testing a Controller](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing){:target="_blank"}. 


## Stretch Goals
- There are no Stretch Goals for this assignment.


## Additional Resources
- There are no additional resources provided for this assignment.


## README

**A README is a requirement. No README == No Grade.** <br /> 
Here are the requirements for a valid README: <br />


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
- [sample-README](https://github.com/noffle/art-of-readme){:target="_blank"}

## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements described above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements described above // Program runs/compiles |
	2       | README Document does not meet minimum standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are properly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |


