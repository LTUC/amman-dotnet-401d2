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

The lab rubric can be found [HERE](../Resources/rubric){:target="_blank"} 
