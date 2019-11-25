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


### README REQUIREMENTS
Your readme should contain the following:
  - Link to your deployed website
  - What is the product you are selling?
  - What claims are you capturing? Why?
  - What Policies are you enforcing? Why?
  - Structure/Database Schema for your store DB (not identity)
  - Explanation of your DB Schema (mostly interested in your basket/order tables)
  

The readme is important because it helps the instructional team grade your site. it is their guide/map
to your configuration and settings of your web application. 


### Graded Requirements:
Grades are distributed separately per student. Refer to the rubric below for evaluation


## Rubric

### E-Com Sprint 2 (100 points)

Review the rubric below to know and understand the overall expectations

#### Mini Cart (10 points)

"Mini Basket" exists on product landing pages. 
Mini Basket holds a current view of all the existing items the user has in their cart. A view component is used to implement the mini cart across the site. 

#### Cart (10 points)

A dedicated cart page that consists of all the user's current products. Items in the cart can be modified in quantity or removed.  Home page consists of a link to the cart page for easability. 
Cart page contains a "Checkout" button that redirects to the Receipt page. The user must be logged in to access the cart page.

#### Receipt Page (10 points)

Receipt page consists of an itemized list of all products that the user has "purchased". Includes Item name, Quantity, and total price of each item as well as total price of all items in the basket. 

#### Email Sender (10 points)

A welcome email is sent to the user upon a new registration. A receipt email is also sent to the user after the "checkout" process from the basket page. Each email is fitting to the problem domain, and formatted professionally. The email consists of a custom greeting and personalization. 

#### Admin Dashboard (10 points)
Admin Dashboard exists with a landing page directing users to Products Controller. An admin can execute full CRUD operations on the products. Only useres with a role of "Admin" can acess this page. Credentials to an admin account are provided to grader in canvas note.

#### User Experience (10 points)
HTML/CSS/SCSS is present across the site. Site is clean and professional looking. Pages are properly linked and the overall experience and flow of the site is usable. Site does not contain any unhandled exceptions.

#### Readme & Documentation (10 points)
Readme contains an introduction to the web application. Site contains all required questions as well as a link to the deployed site. All contributors are referenced and cited within the ReadMe. **NO POINTS WILL BE GIVEN FOR THE ASSIGNMENT IF DEPLOYMENT LINKS ARE NOT PRESENT OR IS NOT FUNCTIONAL*

#### Azure DevOps Process (30 points)
Azure DevOps tool is properly maintained. User stories assigned to each member are properly filled out, including time estimation, tasks, branches, description, and acceptance tests. 50% of these points are for both partner's overall maintenance of the KanBan board, 50% of these points are dedicated to each individual partner for specific maintenance. These points CANNOT be regained.

#### Even Workload (-20% deduction)
All User stories and work completed within this sprint was approx even between all partners. Partners properly communicated with each other and no major conflicts were present during sprint. (up to a 20% deduction to overall sprint will be applied if necessary). These points cannot be regained.