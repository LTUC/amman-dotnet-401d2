![cf](http://i.imgur.com/7v5ASc8.png) Lab 29: Sprint 1 - Milestone #4
=====================================

## To Submit this Assignment

No Submission is required. 

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together. 

### END OF SPRINT
This is the end of sprint 1. please refer to the Sprint 1 assignment to confirm you have met all the requirements for submission. 

## Directions:

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 

## User Stories & Guidance:

### User Stories

1. (Developer 2) As a user, I would like to implement a custom claims-based policy
2. (Developer 1)  As a user, I would like part of my site to only be accessible to those who meet the criteria for a specific policy 
3. (Developer 1) As a user, I would like to have a page where visitors can view all the products I have in my inventory so that they can eventually purchase. 

### Guidance

**User story 1:** Think up a claims based policy that you want to enforce. I used the "age" example in class. Can you think of a different one? An example of one may be only someone with a specific email domain can access parts of the site. Here are some required components that you should have
	1. `IAuthorizationRequirement` that holds some basic information about the requirement
	2. `AuthorizationHandler<T>`That enforces the requirement from above. This is what checks the condition for the policy to pass.
	3. Add the policy under your `AddAuthorization()` in your `Startup.cs` file
	4. Register the policy with dependency injection by giving it a lifecycle attribution


**User Story 2:** Another claim based policy is to only allow people to certain parts of the site if a specific claim exists. It doesn't necessarily matter the value of the claim, just that they have it attached to their profile. An example could be "Any user who has the claim of "LovesCats" can access a specific part of the site that is specific to cat lovers.

**User Story 3:** This is essentially just a Shopping page. This is where the user can browse the store. This can be a "ShopController" and it will display all the possible products that currently exist in the inventory.



## Tests
TBD


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
