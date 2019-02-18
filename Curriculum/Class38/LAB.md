![cf](http://i.imgur.com/7v5ASc8.png) Lab 38: Sprint 3 - Milestone #3
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.

## Directions:

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 

## User Stories & Guidance:

1. (Developer 1) As a developer, I would like to have a personal profile page that will display my basic information
2. (developer 2) As a user, I would like to view my last 5 orders I have created from the site
3. (Developer 1 & 3) As a user, I would like to have the ability to change my password 


### Guidance

**User Story 1**: Using .NET Core Razor Pages, create a personal profile page that a logged in user can easily access. The user profile should 
contain the ability for the user to:
1. Change their first name
2. View their email (don't let the user change it)

You will need to inject `userManager` into your razor page to get basic information about the user.


**User Story 2:** Within the user profile, the user should be able to view their last 5 orders that they have placed. Much like the admin dashboard, allow the user to view the individual details of each order.


**User Story 3:**  Explore the `SignInManager` and implement the ability to change the password of the user. Be sure that the user confirms their password when changing it to make sure they typed it in correctly. 


## Tests

Continue to test your basic CRUD operations within your services


## Rubric 
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements descibed above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
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
