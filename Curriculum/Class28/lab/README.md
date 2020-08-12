# Lab 28: Sprint 1 - Milestone #2

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


### User Stories

1. (Developer 2) As a User, I would like the images of my products to be stored securely and external to the project. 
1. (Developer 1 & 3) As a user, I would like the home page to showcase and reflect the products that we are selling.
1. (Developer 1) As a user, I would like to be able to easily login and register for the site from the home page so that the user can quickly get started.
1. (Developer 1) As a user, I would like to have an administrative role available within the application. 

### Guidance

**User Story 1:** Use Azure to store all of your assets.
1. Create a new page that allows the user to upload an image. 
2. Lock this page down so that only admins can access (dependency: user story 4 for Developer 1)
3. Have the saved images go straight to Azure Blob.
4. You will receive a url back from Azure, that should be stored in your database, and referenced as the image for your product. 

**User Story 2:** Add some HTML and CSS to your home page. Customize it so that it is tailored to your product you are selling. 
Some ideas may be to "feature" products on your homepage! Have fun, make it look professional. In addition, add navigation to all of your external pages. Don't worry about showcasing all 10 products, we will make a page for that in lab 29. Just introduce your product on this home page.

**User Story 3:** Within your Homepage, include a link to easily Register or Login. Traditionally, these are located in your 
homepage navigation. This link can just redirect to the appropriate page. We will build onto this functionality once the user is logged in during Milestone 3, so don't stress about customizing the login/logout experience just yet. 

**User Story 4:**  Set your application up so that at minimum single role of Admin, and an administrative user is pre-populated into the application. Register a new policy named "AdminOnly" that only allows the Admin role access to specific pages. Use your AsyncInn labs as a resource.

## Tests
No tests for today. Confirm that all of your services/repositories are being tested.

## Rubric

Review the final Sprint 1 submission for rubric/breakdown of all user stories

## To Submit this Assignment

Submit the answer to the following questions:
1. What suprised you most about this milestone?
1. How long did it take you to complete this milestone?
1. How long did you expect to take?
1. What did you find most challenging about this milestone?
1. What do you need to continue to work on during this project?
1. Any Concerns that the instructional staff should be aware of?