# Sprint 2 Requirements

These are the expectations for Sprint 2.

You will only have 48 hours from the initial due date of this sprint to submit your work. Anything past the 48 hours will not be accepted and you will receive a zero for this sprint. Each individual is responsible for their own submission. 

Re-sumbits for this sprint will only be accepted upon evaluation of sprint 3:

For example, Your team received feedback that you need to fix an error in one or two of your milestones. Instead of doing a submission and pushing to master halfway through your sprint 2, you will be required to **explicitly** tell your grader what you want them to regrade from sprint 1 when you submit for sprint 2. You will not be able to do any additional "resubmits" for sprint 1 once sprint 2 is due and graded. Plan accordingly.

You will each individually submit the following into Canvas as a text entry:

1. A deployed link to your azure website
2. Collaborate with each other and come up with 
    - What you did well
    - What you will do differently next sprint
3. Do you need anything from the instructional staff?

The instructional staff will review your current master branch in VSTS/Azure Dev Ops and evaluate you accordingly.

**Only push to master on sprint check-ins**

## Checkin

Upon completion of this sprint, Your E-Commerce site should contain the following:

1. MVC website with basic configurations
2. DB Context with products seeded into a SQL Server database
3. Repository Design Pattern properly setup and integrated into your site (interface with Startup.cs registration)
1. Home Page
   - Introduction to your site
   - Anonymous accessibility
2. Login Page
   - Login to an existing account
   - Anonymous accessibility
   - Option to login with at least two 3rd party service providers (OAUTH)
3. Registration Page
   - Create an account
   - Anonymous accessibility
   - Capture custom claims
5. Shopping Page
   - Shows all products in inventory for users to browse
   - Anonymous accessibility
6. Product Landing Page
   - Displays individual information about each product
   - Anonymous Access
7. Basket Page
   - View all items in the basket. Allow ability to edit/remove the item.
   - Must be logged in/Authorized
9. Receipt/Order Confirmation Page
   - Must be logged in/Authorized
   - Summary of the order that the user just completed.
6. Custom claims based policy implemented and registered and used in the site
 

### Shared
- CSS/HTML
- Deployed to Azure
- Your readme should contain the following:
- Readme should contain the following:
  - What is the product you are selling?
  - What claims are you capturing? Why?
  - What Policies are you enforcing? Why?
  - What OAUTH providers did you choose
  - Structure/Database Schema for your store DB (not identity)
  - Explanation of your DB Schema (mostly interested in your basket/order tables)
  - Link to your deployed website
  

### Graded Requirements:
Grades are distributed separately per student:

1. View Component (Mini basket on at least 2 different pages) - 10pts
2. OAUTH - at least two 3rd party service providers - 10pts
3. SendGrid email integration on registration and order confirmation - 10pts
4. Basket Page shows all current products in basket && each product landing page has an "Add to Basket" button - 10pts
5. Receipt page exists with order summary and grand total of all items - 10pts
6. HTML/CSS both polished from Sprint 1 and exists in new sprint 2 pages - 10pts
7. Deployed and functional w/ readme. Meets all the requirements listed above in required pages - 10pts
9. Each Partner participated in a fair share of the work 
    - i.e. Each partner did their assigned user stories
		- It's okay if one partner helped the other out with a few stories. That is encouraged if it's needed. I am primarily making sure that each person did their "fair share" of the sprint. Do not make your partner do all the work to stay on task. 
	- If the distribution is significantly uneven, or one partner did not (approx.) evenly contribute, **they will lose 20%** from the sprint. These points cannot be regained. 
  

**If you are missing all or the sprint 2 part of your readme documentation,  you will lose an additional 20%**. 
- The readme is important because it helps the instructional team grade your site. it is their guide/map
to your configuration and settings of your web application. 

Total: 70 pts

## Rubric

### E-Com Sprint 2 (100 points)

Review the rubric below to know and understand the overall expectations


#### Product Page (10 points)

Landing page that consists of product details, add to basket button, and visibility of the users current basket. 

#### Mini Basket (10 points)

"Mini Basket" exists on home page of site and product landing pages. 
Mini Basket holds a current view of all the existing items the user has in their basket. A view component is used to implement the mini basket across the site. 

#### Basket (10 points)

A dedicated Basket page that consists of all the user's current products. Items in the basket can be modified in quantity or removed.  Home page consists of a link to the basket page for easability. 
Basket page contains a "Checkout" button that redirects to the Receipt page. The user must be logged in to access the Basket page.

#### Receipt Page (10 points)

Receipt page consists of an itemized list of all products that the user has "purchased". Includes Item name, Quantity, and total price of each item as well as total price of all items in the basket. 

#### Email Sender (10 points)

A welcome email is sent to the user upon a new registration. A receipt email is also sent to the user after the "checkout" process from the basket page. Each email is fitting to the problem domain, and formatted professionally. The email consists of a custom greeting and personalization. 

#### User Experience (10 points)
HTML/CSS is present across the site. Site is clean and professional looking. Pages are properly linked and the overall experience and flow of the site is usable. Site does not contain any unhandled exceptions.

#### Readme & Documentation (10 points)
Readme contains an introduction to the web application. Site contains all required questions as well as a link to the deployed site. All contributors are referenced and cited within the ReadMe. **NO POINTS WILL BE GIVEN FOR THE ASSIGNMENT IF DEPLOYMENT LINKS ARE NOT PRESENT OR IS NOT FUNCTIONAL*

#### Azure DevOps Process (30 points)
Azure DevOps tool is properly maintained. User stories assigned to each member are properly filled out, including time estimation, tasks, branches, description, and acceptance tests. 50% of these points are for both partner's overall maintenance of the KanBan board, 50% of these points are dedicated to each individual partner for specific maintenance. These points CANNOT be regained.
