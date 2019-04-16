![cf](http://i.imgur.com/7v5ASc8.png) Lab 32: Sprint 2 - Milestone #2
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


## Directions:

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 

## User Stories & Guidance:

Here are the user stories for Milestone 2:
1. (Developer 1) As a user, I would like to have a designated basket page that will allow me to modify the items in my basket
2. (Developer 2) As a user, I would like to quickly navigate to my basket from the home page. 
3. (Developer 1 & 2)  As a user, I would like at least 2 OAUTH options of 3rd party tools to sign-in into or register for the e-commerce site. (Each developer should implement one)
4. (Developer 2) As a user, i would like the icons of the 3rd party OAUTH options to display on the login page. 

### Guidance

**User Story 1:** This is a place that will eventually "kickoff" your checkout process. Besides seeing all the basket items through the view component from yesterday, you should also be able to view all the items the user has on a dedicated page. Make it so that the basket items can be modified (View the product landing page of that product, edit the product qty if applicable, delete the product from the basket). 
	
**User Story 2:**  On the home page, the user should be able to see a shortcut for their basket. When they select this button, redirect the user to their appropriate basket. Make this page an [Authorize] page. They must be logged in to view their basket. 

**User story 3:** This user story is the actual setup of OAuth. This means creating the specific actions in the Account Controller that are called and activated once the 3rd party service provider is selected. Refer to the demo code, and the lecture again for guidance on what the code base means and how to implement it.

 Each developer should pick a 3rd party service provider. Navigate to the developer panel for a service provider, and register your deployed web application to with the service to allow login.

**User story 4:** On the login page, find thumbnail icons of the service providers and place then on your login page.
	

## Tests

No tests are required for today. 


## Rubric

The lab rubric can be found [HERE](../Resources/rubric){:target="_blank"} 
