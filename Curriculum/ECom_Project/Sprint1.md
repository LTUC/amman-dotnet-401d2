# Sprint 1 Requirements

These are the expectations for Milestone 1.

As a team, you will submit the following into Canvas as a text entry:

1. A deployed link to your azure website
2. User Story breakdown - Who did what....
3. Collaborate with each other and come up with 
    - What you did well
    - What you will do differently next sprint
4. Do you need anything from the instructional staff?

The instructional staff will review your current master branch in VSTS and evaluate you accordingly.

**Only push to master on sprint check-ins**

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

#### Sprint 1 User Stories Part 1
1. (Developer 1) As a Developer, I want to build out the skeleton of an MVC site with a Home Controller
2. (Developer 2) As a Developer, I want to use SQL Server as my database
3. (Developer 1 and 2) As a Developer, I want to deploy both my database and web app to Azure
4. (Developer 1) As a Developer, I would like to utilize Dependency Injection when setting up my data layer so that I can
easily switch between production and development environments. 
5. (Developer 2)As a Developer, I would like to have 10 products in my database on initial launch of my site. 


### Milestone 2

#### Sprint 1 User Stories Part 2
1. (Developer 1 & 2) As a Developer, I would like to utilize and enable ASP.NET Core Identity API to set up my site for the use of Identity.
2. (Developer 2) As a user, I would like to register for an account on the site, so that I can have a personalized experience
3. (Developer 1) As a user, I would like to login to my website on a custom secure login page.
4. (Developer 2)As a user, I would like to be greeted by a custom home page visiting the site. 
5. (Developer 1)As a user, I would like to be able to either login or register easily through a link on the home page. 

### Milestone 3

#### Sprint 1 User Stories Part 3
1. (Developer 1) As a user, I would like to be greeted, after login, with my first and last name
2. (Developer 2) As a user, I would like custom claims to be captured upon registration to the site.
4. (Developer 1)As an Admin, I would like a custom dashboard that is only accessible by other admins
5. (Developer 2) As an admin, I would like to be redirected to the admin dashboard upon login
// 6. As an admin, I would like to manage my product inventory from the admin dashboard. 


### Milestone 4

#### Sprint 1 User Stories Part 4
1. As a user, I would like to implement a custom claims-based policy
2. As a user, I would like part of my site to only be accessible to those who hold a certain claim 
3. As a user, I would like to have a page where I can view all the products I have in my inventory
4. As a user, I would like a product landing page for each product, so that I can view individual details about the product.


## Checkin

### Milestones - End of Sprint 1
1. Home Page
   - Introduction to your site
   - Anonymous accessibility
2. Login Page
   - Login to an existing account
   - Anonymous accessibility
3. Registration Page
   - Create an account
4. Admin Dashboard - 
   - Only accessible by users who hold the role of admin
   - Manage Inventory (Full CRUD)
5. Shopping Page
   - Shows all products in inventory for users to browse
6. Product Landing Page
   - Displays individual information about each product


### Shared
- All pages should have CSS/HTML
- Web app and Databases should be deployed to azure
- Readme should contain the following:
  - What is the product you are selling?
  - What claims are you capturing? Why?
  - What Policies are you enforcing? Why?
  - Link to your deployed website

**End of Sprint 1:** 
  - **A readme is required**
  - Milestone points 60pts. (10 pts for each page outlined above)
  - Deployed and Functional: 10pts

Total: 70 pts

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



