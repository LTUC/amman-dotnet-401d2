# Demos: Payment Processing

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Demo

Students will have recently completed the integration of SendGrid as a 3rd party service using a Facade, with the Repository Pattern.

Today, they will repeat that process using Authorize.net

> However, there will be no demo.

Following the same procedures as for Sendgrid, students will wire in Authorize.net into the payment workflow.  For your demo today, guide that process

## Repository Pattern Review

1. What do we need?
   - Interface
   - Service
     - Advise them to leave the logic here blank
     - If they can wire the whole thing up with a fake Response, they're 90% home!
   - DI Setup in Startup

## Data Models / DTOs
   - What models (DTOs) do we need to handle a Payment and a Response?

## Views

1. Razor Page for Payment Processing
   - Guide the students to use a "Payment" model to lead the generation of a form
   - This model will be submitted to the `OnPost()`
1. `OnPost()` will be where we call our payment service
   - It will expect a perfect `Payment` object
   - It must respond with a perfect `PaymentResponse` object

## Payment Processing

- Finally, walk them through the Authorize.net documentation
- How will we adapt the demo code into our service?


## Workflow

- Where does this fit into the customer's journey/workflow?
