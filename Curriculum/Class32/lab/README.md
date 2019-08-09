![cf](http://i.imgur.com/7v5ASc8.png) Lab 32: Sprint 2 - Milestone #2
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


## Directions:


## User Stories & Guidance:

1. (Developer 1 & 2 & 3) As a developer, I would like to use IEmailSender as my interface when configuring email functionality. 
2. (Developer 2) As a user, I would like an email confirmation to be sent to me after I have registered for an account on the site.
3. (Developer 1) As a user, I would like to have a designated basket page that will allow me to modify the items in my basket


### Guidance

**User Story 1:** Utilize the .Net Core's IEmailSender interface. 
Create a model that implements this interface that will create and send emails 
through SendGrid. You will need to implement the IEmailSender interface on a new 
class model and create the logic to conenct your SendGrid account and send out any
email that gets sent in  through the arguements. 

**User Story 2:** Building off of US1, Make an email get sent after 
registration of a new account. Have this email be a simple Welcome message to the user. 

**User Story 3:** This is a place that will eventually "kickoff" your 
checkout process. Besides seeing all the basket items through the view component 
from yesterday, you should also be able to view all the items the user has on a 
dedicated page. Make it so that the basket items can be modified (View the product 
landing page of that product, edit the product qty, delete the product from the 
basket). You may choose to make this either a Razor page or a controller. The route should
be `/Basket` at minimum. 


## Tests

No tests are required for today. 


## Rubric

The lab rubric can be found [HERE](../Resources/rubric){:target="_blank"} 
