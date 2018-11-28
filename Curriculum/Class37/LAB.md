![cf](http://i.imgur.com/7v5ASc8.png) Lab 37: Sprint 3 - Milestone #2
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


## Directions:

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 

## User Stories & Guidance:

1. (Developer 1)As an Admin, I would like a custom dashboard that is only accessible by other admins
2. (Developer 2) As an admin, I would like to be redirected to the admin dashboard upon login
3. (Developer 1)  As an admin, I would like to manage my product inventory from the admin dashboard. 
4. (Developer 2) As an admin, I want to be able to see the last 10 orders that have been submitted from the admin dashboard


### Guidance

**User Story 1**: Create this page using the Razor Pages technique. Create a new "Pages" folder within your application. In addition, create a sub folder named "Admin". Within this "Admin" folder, you can create razor pages and associated page models. Use the demo code as a baseline. Be sure to lock these pages down so that only "admins" can access them. Please have it so both your instructor and your grader have access to the admin panel. 


**User Story 2:** When the user logs in, check the roles that they are associated with. If they are an admin, redirect them to the admin dashboard instead of the home page. 


**User Story 3:** Within the Admin dashboard, Create a link to redirect you to a new page (make this a razor page with a page model) that will add the ability to do standard CRUD operations on products. This includes create,get, update, and remove products from your inventory. Use your IProduct interface that you created earlier. A stretch goal would be to add the ability to track the inventory of products. 


**User Story 4:**  Within the Admin dashboard, add the ability for the admin to see the last 10 orders that were submitted. The admin should be able to quickly see:
1. The name of the Customer
2. The date of the order
3. The total price of the order
Each order should link to an individual order page that will give full order details including individual line items. 


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
