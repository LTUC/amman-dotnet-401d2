# Lab 36: Sprint 3 - Milestone #1

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.

## User Stories & Guidance:

1. (Developer 1) As a user, I would like to use AUTH.NET as my automatic payment processing system
1. (Developer 2)As a user, I would like a fake Credit card drop down to be used for every transaction that occurs in my site.
1. (Developer 2, 3) As a User, I would like to have a checkout page that captures basic information before being redirected to my order summary page. 


### Guidance

**User Story 1**: Use the Auth.NET docs located in today's readings. This is going to be your key to accomplishing this user story. Also be sure to use the demo code and the demo code provided in the docs. There are many resources (including the auth.net GH repo) for this to be accomplished. Be sure that you know exactly what is going on. 
Don't forget to  update your code to the new .NET Core SDK syntax for ApiOperationsBase:
ApiOperationBase<ANetApiRequest, ANetApiResponse>

**User Story 2:** This user story ties very closely into US1. Do not ask for a real credit card number. Your dropdown should consist of card types. Do not allow the user to put in any numbers into a text box. Make sure to refer to the Testing Guide of Auth.NET as a reference to the different test cards you can use.   

**User Story 3:** On the checkout page, This is where you will capture the information about the order in order for it to process. This includes the payment dropdown from the above user story. Upon completion of this user story, the user should be able to go from their Basket >> Checkout >> Receipt.  When the user submits their information for the order, make a call out to the Auth.NET Api, process the payment, and then redirect to the receipt page. Your Receipt page should indicate if the transaction was successful or not. When implementing your `Payment.cs`, be sure to incorporate the repository design pattern by creating an `IPayment.cs` interface and registering it in your Startup.cs.

## Tests

Write tests for your services against your database. Make sure the basic CRUD operations are possible. 

You do not need to test the Identity components. Only the CRUD operations on the Product and Cart

Don't forget about the getters and setters.


## To Submit this Assignment

Submit the answer to the following questions:
1. What suprised you most about this milestone?
1. How long did it take you to complete this milestone?
1. How long did you expect to take?
1. What did you find most challenging about this milestone?
1. What do you need to continue to work on during this project?
1. Any Concerns that the instructional staff should be aware of?

