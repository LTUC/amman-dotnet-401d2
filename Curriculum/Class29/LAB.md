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

1. (Developer 2) As a user, I would like to implement a custom claims-based policy
2. (Developer 1)  As a user, I would like part of my site to only be accessible to those who meet the criteria for a specific policy 
3. (Developer 1 & 3) As a user, I would like to have a page where visitors can view all the products I have in my inventory so that they can eventually purchase. 

### Guidance

**User story 1:** Think up a claims based policy that you want to enforce. I used the "age" example in class. Can you think of a different one? An example of one may be only someone with a specific email domain can access parts of the site. Here are some **required components** that you must have:
- `IAuthorizationRequirement` that holds some basic information about the requirement
- `AuthorizationHandler<T>`That enforces the requirement from above. This is what checks the condition for the policy to pass.
- Add the policy under your `AddAuthorization()` in your `Startup.cs` file
- Register the policy with dependency injection by giving it a lifecycle attribution


**User Story 2:** Another claim based policy is to only allow people to certain parts of the site if a specific claim exists. It doesn't necessarily matter the value of the claim, just that they have it attached to their profile. An example could be "Any user who has the claim of "LovesCats" can access a specific part of the site that is specific to cat lovers. Provide a link on your hompage to this custom page

**User Story 3:** This is essentially just a Shopping page. This is where the user can browse the store. This can be a "ShopController" and it will display all the possible products that currently exist in the inventory.


## Tests
No Tests are required for this milestone

## Rubric
Review the final Sprint 1 submission for rubric/breakdown of all user stories

