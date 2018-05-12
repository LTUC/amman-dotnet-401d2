![cf](http://i.imgur.com/7v5ASc8.png) Lab 33 : Personal Portfolio
=====================================

## To Submit this Assignment
- fork this repository
- create a new branch named `lab07-`; + `<your name>` **e.g.** `lab33-amanda`
- write your code
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas
- Include a Readme.md (contents described below)

## Directions

## Day 1
Create a portfolio using a Razor Page application. 
Your milestons for Day 1 are as follows:
1. Using the web application template, create a new Portfolio project 
1. Create a homepage for your Razor page that presents the user with 3 options:
	1. Visit your projects (links to /projects)
	1. Visit your Data Structures (links to Github DS repo)
	1. About me page (links to /about)
1. Seed your database with at least 3 projects
	- Provide a GitHub link to your project's repo
	- Azure Link (if applicable)
	- Description of the project
	- Languages used
1. Implement an interface named `IPortfolioService`
	1. The Interface should require the following at minimum:
		1. Add
		1. Save
		1. Get
		1. Update
		1. Delete

## Day 2

1. Create a service called `PorfolioService` that implements the interface noted above. 
1. Within Porfolio service, make a connection to the database to implement standard CRUD operations on other
Portfolio objects

## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details

<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> <br /> Refer to the sample-README in the class repo for an example. 
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
