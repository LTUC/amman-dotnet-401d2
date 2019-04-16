![cf](http://i.imgur.com/7v5ASc8.png) Lab 28: Sprint 1 - Milestone #3
=====================================

## To Submit this Assignment
No Submission is required. 

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together. 

## User Stories & Guidance:

### User Stories
1. (Developer 1 & 3) As a user, I would like to login to my website on a custom secure login page.
2. (Developer 1) As a User, I would like custom claims to be captured upon registration of the site. 
3. (Developer 2 & 3) As a user, I would like to be greeted by a custom home page visiting the site. 
4. (Developer 2) As a user, I would like to be able to either login or register easily through a link on the home page. 
5. (Developer 2) As a user, I would like to be greeted, after login, with my first and last name

### Guidance

**User Story 1:** Within your AccountController, add a Login() action. The approach to this is going to be similar to how you are approaching the Register() action. You need to create a view to hold the form, have both an HTTPGET and HTTPPOST in your controller for your action, as well as a View Model to hold the Username and Password that the user is inputting.  Make sure the login controller is accessible by Anonymous users.

**User Story 2:** Capture a couple other claims from the user...this can all be directly related to what you capture from the registration process. As we develop the site, you can continue to add claims as needed. Remember that each time you add a new claim..old users will not have that claim so you may need to delete/reset your database of users. Here are some ideas of claims you can collect:
	- First Name, Last Name 
	- Birthday
	- Email
	- Favorite Color
	- US State
	- Favorite Disney Movie (Frozen or Brave?)


**User Story 3:** Add some HTML and CSS to your home page. Customize it so that it is tailored to your product you are selling. some ideas may be to "feature" products on your homepage! Have fun, make it look professional. 

**User Story 4:** Within your Homepage, include a link to easily Register or Login. Traditionally, these are located in your homepage navigation. This link can just redirect to the appropriate page. We will build onto this functionality once the user is logged in during Milestone 3, so don't stress about customizing the login/logout experience just yet. 

**User Story 5:**  For this user story, you need to capture the user's first and last name upon registration . You also want to create the claim of the user's first and last name as a "Name" claim. Take this claim, and display it somewhere that will be visible to the user. Generally, it's a good idea to be able to use the user's name after they login, because it gives them a more personalized experience. Display this in the nav bar potentially that says "Hi, Amanda!". This can be done in your layouts, to display on all pages of your site, or you can have a cool design on the homepage that tactfully displays the users name. Get creative, and let the user know you care :) 

## Tests


## Rubric

Review the final Sprint 1 submission for rubric/breakdown of all user stories