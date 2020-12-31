# Lab 33: Sprint 2 - Milestone # 3

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.

## User Stories & Guidance:

1. (Developer 1 & 2 & 3): As a user, I would like to checkout with my purchases using electronic payment options on my site during the checkout process
1. (Developer 2) As a user,  I would like to see a summary of my purchase after completing my checkout process.
1. (Developer 1) As a user, I would like a summary of my purchase to be emailed to me so that I can store the receipt for my records.


### Guidance

**User Story 1:** This user story will require that you create a "checkout" page. This checkout page should appear after the user selects "Checkout" on their cart/basket page. 

 Using Authorize.Net, integrate payment into your application. Use the sandbox account to prevent usage of real credit card charges. Integrate the payment using the repository design pattern, and have it injected into your razor page. 

 When completing an order, capture the following information about the user:

 1. First Name
 2. Last Name
 3. Billing/Shipping Address
 4. Billing/Shipping City
 5. Billing/Shipping State
 6. Billing/Shipping Zip

 Generally, each order has it's own "Id", is connected to a specific user, and each order contains a number of order items. A user could potentially have many orders. 

 Keeping this in mind, expand your database to accept orders for the checkout process. In the next couple labs, we will be showcasing a specific user's order to them within their profile page. 
  

**User Story 2:** After the checkout process is complete, redirect the user to a "receipt" page that shows a summary of the items that they purcahsed, as well as the order number ,shipping/billing information, and anything else that may be relevant.  

**User Story 3:** When the user has completed the checkout process, email them a confirmation of their order. 

Hint: When creating the email, consider using the SendGrid design templates. Not required, but encouraged. 

Also consider using `StringBuilder` when creating the text for the email, this is much more efficient than concatinating a string together. 


## Tests

No additional tests are required for today. 


## Rubric

The lab rubric can be found [HERE](../Resources/rubric){:target="_blank"} 


## To Submit this Assignment

Submit the answer to the following questions:
1. What suprised you most about this milestone?
1. How long did it take you to complete this milestone?
1. How long did you expect to take?
1. What did you find most challenging about this milestone?
1. What do you need to continue to work on during this project?
1. Any Concerns that the instructional staff should be aware of?