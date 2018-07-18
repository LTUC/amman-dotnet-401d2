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

Upon completion of this sprint, Your Ecommerc site should contain the following:
1. Home Page
2. Login PAge
3. Registration Page
4. At least 1 Shopping page to view all products
5. Product landing pages for each product
6. Admin Dashboard
7. Product Page for CRUD operations
8. Basket Page
9. Checkout PAge
10. Order Confirmation Page


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
Total: TBD pts

### Rubric (per page)
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


