# Authorize.NET Documentation

## What is it?
Authorize.NET is a commonly used payment provider used
by e-commerce site and small business owners. 

Auth.Net is similar to PayPal, except a little easier to use
and offers a sandbox account that will be utilized for student lab assignments.

## Why?
While in the industry, you may be required to use 3rd party tools often. 
It will be rare that you will not be utilizing someone elses tool to help with the functionality of your site. 

For our E-commerce site, we need a payment processor. It's hard to have an e-commerce site without the electronic payment part. 

## How?
Auth.Net has great documentation. The trick is knowing how to look through it and where to look.

Let's break down the following scenario:

Let's pretend we were presented with the following user story:
```
As a user, I want the ability to process payments for my e-commerce site.
```

Some feature tasks we can define:

1. Let's use Auth.Net as our gateway. 
1. It's a payment processing system for our e-commerce site

The first gut reaction from most developers would be, "What the heck is AUTH.NET....and how am I supposed to integrate it into the site".

This is where we research it. We start by looking at the website
[Developer AUTH.NET](https://developer.authorize.net/)

When looking at the developer site...where should we start?(Visit the API reference)

- Wow thats a lot of documentation. 

1. API Documentation
    - Wow, that's a lot. I'm not sure what to do...yet.
1. Hello World Link
   - Get Started seems safe

On the get started page, we immediately see "C#" code. This is a great place to get serious. Review the code with the class...actually better yet...make them code review it!

Encourage the students to use the code review...in addition to the API documentation to understand 
what is going on.

Once they have read through the code, let students know that most companies that offer services, such as auth.net (even PayPal) offer sandbox accounts. These sandboxes are available so that Developers can get comfortable and configure an environment for their application. That is what we will be using for our project....the sandbox account. 

Point the students to the [Testing GUide](https://developer.authorize.net/hello_world/testing_guide/)
This is where they can learn more about the bounds of Auth.NET and what they can and can't do while playing with the provider.

Have student review the testing guide for a bit. Talk to them about
what the capabilities are. This should expose them what types of actions they can do
with AUth.Net to force certain responses. 


## Demo Code

Now it's time to demo it.

Much like we have been doing, we will keep our payment process loosely coupled.
this means we will need to make an interface called `IPayment` that will be the data layer
between our web application and the actual payment processor. We won't do that right away though.
let's just create the class first, then refactor from there. 

1. Create a class named `Payment`.
1. Take the code from the Documentation and and implement into a `Run()` method in the `Payment.cs` class.
1. As a class...talk about how your can break the code down..is it possible?
    - What type of information do we need from the user to make the transaction possible?
    - Do they see anywhere that could be exported to an external method within this Payment Class?
1. Slowly refactor the code out together.
1. Eventually we should be able to just call `Payment.Run()` from our appropriate checkout controller and be able to process the payment...wait for a response...and redirect to the receipt page with the appropriate information.
1. Do we want to save this information anywhere in the database?
    - should we keep track of all the transactions?
    - what information should we save?
1. Can the students review the documentation and what was demo'd and relay back the work-flow and dataflow of this 3rd party service provider? What information is the client actually saving? Is it secure? Safe?
1.To be clear, **We will not be accepting custom CC numbers, they are instructed to use a drop down menu of CC from the testing documentation**

1. To create a payment processor, what is the bare minimum required for our payment to be utilized for dependency injection?
    - Should be just `Run` or `ProcessPayment`. 
    - Create your interface around these bare minimum requirements to allow for other payment processes in the future. 