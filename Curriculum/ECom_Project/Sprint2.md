# Sprint 2 Requirements

These are the expectations for Sprint 2.

Identify, beween your partner and yourself, who is Developer 1, and who is Developer 2. 
The appropriate developer will complete the stories assigned to him/her as noted next to each user story. 

As a team, you will submit the following into Canvas as a text entry:

1. A deployed link to your azure website
2. User Story breakdown - Who did what....
3. Collaborate with each other and come up with 
    - What you did well
    - What you will do differently next sprint
4. Do you need anything from the instructional staff?
5. What do you want re-graded from sprint 1. (**Be Explicit**)

The instructional staff will review your current master branch in VSTS and evaluate you accordingly.

**Only push to master on sprint checkins**

## Workflow
**For each** user story given for each milestone, you must follow the following process:

**Use the VSTS Cheat Sheet as a reference on how to do each requirement**

1. Create a new user story/work item for each provided user story.  
2. Add tasks to your user story (have at least 2, but no more than 4)
3. Approve the user story that you just created
4. Assign the user story to yourself or your partner
5. Set that user story as "in progress" in your kanban board
6. create a branch for each task that you created and attached to the user story
7. Work on your user story
8. Submit a PR
9. Have your partner approve your pr (with notes possibly?)
10. Complete the task
11. Rinse and repeat for all user stories.

### Milestone 1:

#### Sprint 2 User Stories Part 1
1. (Developer 1 & 2) As a user, I would like a basket to hold the products i wish to purchase. 
1. (Developer 1) As a user, I would like to add individual items to may basket through an "Add to Basket" button located on each product landing page 
2. (Developer 2) As a user, I would like to see the current items in my basket while browsing the site. 
3. (Developer 1) As a user, I would like to have a designated basket page that will allow me to modify the items in my basket
4. (Developer 2) As a user, i would like to quickely navigate to my basket from the home page. 


### Milestone 2

#### Sprint 2 User Stories Part 2
1. (Developer 1) As a user, i would like my ecommerce site to support the use of external service providers to allow me to register and log into my ecommerce site. 
1. (Developer 1 and 2) As a user, I would like at least 2 OAUTH options of 3rd party tools to signin into or register for the ecommerce site. 
2. (Developer 1) As a user, I would like to capture the user's email and save it after they have chosen OAUTH authentication 
3. (Developer 2) As a user, i would like the icons of the 3rd party OAUTH options to display on the login page.

### Milestone 3

#### Sprint 2 User Stories Part 3
1. (Developer 1) As a user, i would like to complete my order through a checkout page on the site. 
2. (Developer 1) As a user, i would like to be directed to an "order summary" page after completion of checkout. 
3. (Developer 2) As a developer, I would like to use IEmailSender as my interface when configuraing meail functionality. 
4. (Developer 2) AS a user, I would like an email confirmation to be sent to me after i have registered for an account on the site.
5. (Developer 2 ) As a user, I would like a receipt of my purchases to be emailed to me after completing the checkout process.


## Checkin

Upon completion of this sprint, Your Ecommerce site should contain the following:
1. Home Page
   - Introduction to your site
   - Anonymous accessibility
2. Login Page
   - Login to an existing account
   - Anonymous accessibility
   - Option to login with at least two 3rd party service providers (OAUTH)
3. Registration Page
   - Create an account
4. Admin Dashboard - 
   - Only accessible by users who hold the role of admin
   - Manage Inventory (Full CRUD)
5. Shopping Page
   - Shows all products in inventory for users to browse
6. Product Landing Page
   - Displays individual information about each product
7. Basket Page
   - View all items in the basket. Allow ability to edit/remove the item.
8. Checkout page
   - Must be logged in/Authorized
   - Capture user information about their order (NO Personal Identifiable information please)
   - Transfer products from their "basket" to an "Order"
9. Recipt/Order Confirmation Page
   - Must be logged in/Authorized
   - Summary of the order that the user just completed. 

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
5. Checkout Page/Process exists (capture order information and then include order confirmation page) - 10pts
6. HTML/CSS both polished from Sprint 1 and exists in new sprint 2 pages - 10pts
7. Deployed and functional w/ readme. Meets all the requirements listed above in required pages - 10pts
9. Each Partner participated in a fair share of the work - 30 pts
    - i.e. One partner did not only do front end while the other only did back end
    - User stories are approx. distributed evenly between both students (roughtly, does not have to be exact)
  

**If you are missing all or part of your readme documentation,  you will lose an additional 20%**. 
- The readme is important becasue it helps the instructional team grade your site. it is their guide/map
to your configuration and settings of your web application. 

Total: 100 pts

### Rubric (Per requirement)
## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements descibed above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |



