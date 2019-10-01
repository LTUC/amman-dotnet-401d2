Lab 34: Sprint 2 - Milestone #3
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


## Directions: 

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 


## User Stories & Guidance:

Here are the user stories for Milestone 2:

1. (Developer 2) As a user, I would like to quickly navigate to my basket from the home page. 
2. (Developer 1) As a user, I would like a "checkout" button present on the Basket page.
3. (Developer 2 & 3) As a user, I would like an order Receipt page so that I can view all the items that I "purchased".
4. (Developer 1) As a user, I would like a receipt of my purchases to be emailed to me after completing the checkout process


### Guidance
	
**User Story 1:**  On the home page, the user should be able to see a shortcut 
for their basket. When they select this button, redirect the user to their 
appropriate basket. Make this page an [Authorize] page. They must be logged in to view their basket. 

**User Story 2:** Update your Basket page to have a "Checkout" button. 
This checkout will complete the customers order. Make this Checkout button link 
to a "Receipt" Razor Page (have it in a "Checkout/Receipt" directory), Developer 1 will be creating
this page so make sure you are communicating the routing  with them. 

**User Story 3:** Create a new Razor page direcotry named "Checkout".
Create a subdirectory named "Receipt". This should be a summary page of all the items 
purchased. Bring in all the items from the user's basket and display each line item
of what the user has "purchased". 
Here is a list of what should be displayed:
	1. The name of the product
	2. The price of the product
	3. The Qty purchased
	4. Grand total of all the items purchased.

**NOTE:** In the next sprint we will capture user specific order information 
such as shipping address, "fake" payment, etc... Don't worry about 
capturing that information just yet. For now, just have your 
"Checkout" button on your Basket page redirect to the summary page. 


**User Story 4:** Make an email get sent after an order is completed. 
This email should contain a receipt/confirmation of the order that was placed. 
 this an external method that can get called whenever it is needed. For now, have 
this email get sent when the "checkout" button is clicked. Modify this in 
Sprint 3 to activate when the order information is captured. 
