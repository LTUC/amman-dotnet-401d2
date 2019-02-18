![cf](http://i.imgur.com/7v5ASc8.png) Lab 34: Sprint 2 - Milestone #3
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


## Directions:

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 

## User Stories & Guidance:

1. (Developer 1 & 2 & 3) As a developer, I would like to use IEmailSender as my interface when configuring email functionality. 
2. (Developer 2) As a user, I would like an email confirmation to be sent to me after I have registered for an account on the site.
3. (Developer 1) As a user, I would like a "checkout" button present on the Basket page.
4. (Developer 2 & 3) As a user, I would like an order Receipt page so that I can view all the items that I "purchased".
5. (Developer 1) As a user, I would like a receipt of my purchases to be emailed to me after completing the checkout process


### Guidance

**User Story 1:** Utilize the .Net Core's IEmailSender interface. Create a model that implements this interface that will create and send emails through SendGrid. 

**User Story 2:** Building off of US1, Make an email get sent after registration of a new account.

**User Story 3:** Update your Basket page to have a "Checkout" button. This checkout will complete the customers order. Make this Checkout button link to a "Receipt" action in the "CheckoutController"

**User Story 4:** Create a new "CheckoutController" with an action named "Receipt". On this summary page, bring in all the items from the user's basket and displays line items of what the user has "purchased". Display:
	1. The name of the product
	2. The price of the product
	3. The Qty purchased
	4. Grand total of all the items purchased.

**NOTE:** In the next sprint we will capture user specific order information such as shipping address, "fake" payment, etc... Don't worry about capturing that information just yet. For now, just have your "Checkout" button on your Basket page redirect to the summary page. 


**User Story 5:** Make an email get sent after an order is completed. This email should contain a receipt/confirmation of the order that was placed. Make this an external method that can get called whenever it is needed. For now, have this email get sent when the "checkout" button is clicked. Modify this in Sprint 3 to activate when the order information is captured. 

## Tests

No tests are required for today. 


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
