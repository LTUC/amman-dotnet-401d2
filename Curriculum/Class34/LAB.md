![cf](http://i.imgur.com/7v5ASc8.png) Lab 36: Sprint 3 - Milestone #1
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


## Directions:

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 

## User Stories & Guidance:

1. (Developer 1) As a user, I would like to use AUTH.NET as my automatic payment processing system
2. (Developer 2)As a user, I would like a fake Credit card drop down to be used for every transaction that occurs in my site.
3. (Developer 2 & 3) As a User, I would like to have a checkout page that captures basic information before being redirected to my order summary page. 


### Guidance

**User Story 1**: Use the Auth.NET docs located in today's readings. This is going to be your key to accomplishing this user story. Also be sure to use the demo code and the demo code provided in the docs. There are many resources (including the auth.net GH repo) for this to be accomplished. Be sure that you know exactly what is going on. 
Don't forget to  update your code to the new .NET Core 2.1 syntax for ApiOperationsBase:
ApiOperationBase<ANetApiRequest, ANetApiResponse>


**User Story 2:** This user story ties very closely into US1. Do not ask for a real credit card number. Your dropdown should consist of card types. Do not allow the user to put in any numbers into a text box. Make sure to refer to the Testing Guide of Auth.NET as a reference to the different test cards you can use.   


**User Story 3:** On the checkout page, This is where you will capture the information about the order in order for it to process. This includes the payment dropdown from the above user story. Upon completion of this user story, the user should be able to go from their Basket >> Checkout >> Receipt.  When the user submits their information for the order, make a call out to the Auth.NET Api, process the payment, and then redirect to the receipt page. Your Receipt page should indicate if the transaction was successful or not. 

## Tests

Write tests for your services against your database. Make sure the basic CRUD operations are possible. 

You do not need to test the Identity components. Only the CRUD operations on the Product and Basket.

Don't forget about the getters and setters.

Keep your tests clean, only 1 Assert per test


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
