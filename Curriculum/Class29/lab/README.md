![cf](http://i.imgur.com/7v5ASc8.png) Lab 29: Sprint 1 - Milestone #4
=====================================

## To Submit this Assignment

No Submission is required. 

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together. 

### END OF SPRINT
This is the end of sprint 1. please refer to the Sprint 1 assignment to confirm you have met all the requirements for submission. 


## User Stories & Guidance:

### User Stories

1. (Developer 2) As a user, I would like to have specific roles within my site so that i can determine the differene between an "Admin" and a "Member"
2. (Developer 1)  As a user, I would like an Admin Dashboard that is only accessible to those who are in the "Admin" Role. 
3. (Developer 1 & 3) As a user, I would like to have a page where visitors can view all the products I have in my inventory so that they can eventually purchase. 

### Guidance

**User story 1:** Much like we did in the demo, add default roles to your application. Add both "Member" and "Admin" at minimim. 
Do not hardcode each user into the roles, have an Enum or an external class with constant values. 

Update both your registration and login to either assign a role to a user, or capture the role of the user. If 
they are an admin, redirect them to the Admin Dashboard US2 is creating. If they are a member, redirect them 
back home. 

**Provide to your grader some credentials so that they can access/test the admin dashboard**

**User Story 2:** Enforce the Role from User Story 1 by creating an Admin Controller that is only accessible by those 
who meet the requirements of the policy of being an admin (Hint, the `IsInRole` should do the trick).
Don't forget to add the `[Authorize(Policy="{NAME OF POLICY}")]' at the top of the controller. 

The Admin dashboard controller should consist of a default index action that displays to the user a simple heading of 
acknowledgement they are on the admin dashboard. 

HTML and CSS should be present on this page. Make the page look neat and clean. 

**User Story 3:** This is essentially just a Shopping page. This is where the user can browse the store. 
This can be a "Shop" directory within your "Pages" directory. This page will display all the possible products 
that currently exist in the inventory.


## Tests
No Tests are required for this milestone

## Rubric
Review the final Sprint 1 submission for rubric/breakdown of all user stories
