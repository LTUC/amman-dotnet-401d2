# Sprint 1 Requirements

These are the expectations for Sprint 1.

You will only have 48 hours from the initial due date of this sprint to submit your work. Anything past the 48 hours will not be accepted and you will receive a zero for this sprint. Each individual is responsible for their own submission. 

Resumbits for this sprint will only be accepted upon evaluation of sprint 2:

For example, Your team received feedback that you need to fix an error in one or two of your milestones. Instead of doing a submission and pushing to master halfway through your sprint 2, you will be required to **explicitly** tell your grader what you want them to regrade from sprint 1 when you submit for sprint 2. You will not be able to do any additional "resubmits" for sprint 1 once sprint 2 is due and graded. Plan accordingly.

You will each individually submit the following into Canvas as a text entry:

1. A deployed link to your azure website
2. Collaborate with each other and come up with 
    - What you did well
    - What you will do differently next sprint
3. Do you need anything from the instructional staff? (these comments are confidential and only shared with instructional staff)

The instructional staff will review your current master branch in Azure Dev Ops and evaluate you based on the rubric below.

**Only push to master on sprint check-ins**

## Checkin

1. All pages should have basic CSS/HTML with a good overall user experience.
2. Web app and databases should be deployed to Azure

### Readme

Readme should contain the following:
  1. What is the product you are selling?
  1. What claims are you capturing? Where? Why?
  1. Link to your deployed website

## Rubric

Review the rubric below to know and understand the overall expectations

### E-Com Sprint 1 (50 points)

#### Readme & Documentation (5 points)
Readme contains an introduction to the web application. ReadMe contains all required questions as well as a link to the deployed site. All contributors are referenced and cited within the ReadMe. 
**NO POINTS WILL BE GIVEN FOR THE ASSIGNMENT IF DEPLOYMENT LINKS ARE NOT PRESENT OR IS NOT FUNCTIONAL*

#### MVC Skeleton & Scaffold (5pts)
Site contains basic MVC Scaffold including a DBContext with basic products seeded into database. 
Site implements the repository design pattern with appropriate interfaces and services. D.I. is properly registered in Startup.cs file.

#### Home Page (3 points)
Introduction to the site with HTML/CSS. Anonymous accessibility. Home page contains login/register links as well as custom greeting for logged in users This area will be used by the assessor to leave comments related to this criterion.

#### Login Page (3 points)
Login page consists of username and password form with password masked of visibility. Login page redirect to home page after successful login. Login page access is anonymous allowed. Login page utilizes ASP.NET Core Identity.

#### Registration Page (3 points)
Registration page consists of a form that successfully creates a new account while utilizing ASP.NET Core Identity. Custom claims are properly captured within registration. User is automatically logged in and redirects user to home page after registration. Registration is accessible by anonymous users.  

#### Products Page (5 points)
Shopping page is accessible by anonymous users as well as fully displays all products existing in the database. 
Each product is evenly displayed on the page and shopping page has a clean professional appearance.

#### Azure Blob (10 points)
All images are stored in Azure. Admin panel exists where an admin can create new products.

#### User Experience (6 points)
HTML/CSS is present across the site. Site is clean and professional looking. Pages are properly linked and the overall experience and flow of the site is usable. Site does not contain any unhandled exceptions.

#### Azure DevOps Process (10 points)
Azure DevOps tool is properly maintained. User stories assigned to each member are properly filled out, 
including time estimation, tasks, branches, description, and acceptance tests. 50% of these points are for all
partner's overall maintenance of the KanBan board, 50% of these points are dedicated to each individual partner for specific maintenance. These points CANNOT be regained.

### Industry Standard (5 points)
Summary Comments are present and completed. Methods and variable names are appropriate. Fundamentals are 
properly used. No misuse of code or industry standards present

#### Even Workload (-20% deduction)
All User stories and work completed within this sprint was approx even between all partners. Partners properly 
communicated with each other and no major conflicts were present during sprint. (20% deduction to overall sprint will be applied if necessary)
