# Lab 29: Sprint 2 - Milestone #1

### User Stories

1. (Developer 2) As a user, I would like to have specific roles within my site so that I can determine the difference between an "Admin" and a "Member"

2. (Developer 1 & 2)  As a user, I would like a dedicated location for Administrators so that they can securely manage the site. 

3. (Developer 1) As an administrator, I would like the ability to create, view, update, and delete products from my inventory so that i can manage the stock.


### Guidance

**User story 1:** Much like we did in the demo, add default roles to your application. Add both "Member" and "Admin" at minimim. 
Do not hard code each user into the roles, have an Enum or an external class with constant values. 

Update both your registration and login to either assign a role to a user, or capture the role of the user. If 
they are an admin, redirect them to the Admin Dashboard US2 is creating. If they are a member, redirect them 
back home. 

**Provide to your grader some credentials so that they can access/test the admin dashboard**

**User Story 2:** Enforce the Role from User Story 1 by creating an Admin Controller that is only accessible by those who meet the requirements of the policy of being an admin (Hint, the `IsInRole` should do the trick). Don't forget to add the `[Authorize(Policy="{NAME OF POLICY}")]' at the top of the controller. 

The Admin dashboard controller should consist of a default index action that displays to the user a simple heading of acknowledgement they are on the admin dashboard. Consider also adding a link to "Manage Products" which should redirect to the products controller index action.

Refer to the suggested wireframe as a reference on how the page should look. For now, disregard the "Orders" section of the admin page.

**User Story 3:**  Technically, this should be 4 different user stories, but for consolidation purposes it is condensed into one. 

You may scaffold out a ProductsController if you like, and update the controller to use the `IInventory` interface that you created in sprint  1.


## Tests
No Tests are required for this milestone

## Rubric
Review the final Sprint 1 submission for rubric/breakdown of all user stories

## To Submit this Assignment

No Submission is required. 

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together. 