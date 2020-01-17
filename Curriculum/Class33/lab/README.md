# Lab 33: Sprint 2 - Milestone # 3

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.

## User Stories & Guidance:

1. (Developer 1 & 2 & 3) As an administrator, I would like the ability to send emails so that I can communicate with my users of the site
1. (Developer 2) As a user, I would like an email confirmation to be sent to me after I have registered for an account on the site. 
1. (Developer 1 & 2) As a user,  I would like to see a summary of my purchase after completing my checkout process.
1. (Developer 1) As a user, I would like a summary of my purchase to be emailed to me so that I can store the receipt for my records.


### Guidance

**User Story 1:** Utilize the .Net Core's IEmailSender interface. 
Create a model that implements this interface that will create and send emails 
through SendGrid. You will need to implement the IEmailSender interface on a new 
class model and create the logic to connect your SendGrid account and send out any
email that gets sent in  through the arguments. 

**User Story 2:** Building off of US1, Make an email get sent after 
registration of a new account. Have this email be a simple Welcome message to the user. 

**User Story 3:** Refer to the suggested wireframes as a guideline of how to format the receipt page. This page should be generated and presented to the user after they select the "Checkout" button on the Cart page. 

In the suggested wireframe, it shows order information. Don't worry about displaying that now, only show the actual products and the total cost. You will add order specific information in Sprint 3.

**User Story 4:** When the user selects "Checkout" on their cart page, this should trigger an email to be sent to the user with a summary of their purchases. 


## Tests

No tests are required for today. 


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