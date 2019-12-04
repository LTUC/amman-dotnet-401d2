# Authorize.NET Documentation

## What is it?
Authorize.NET is a commonly used payment provider used
by ecommerce site and small business owners. 

Auth.Net is similar to PayPal, except a little easier to use
and offers a sandbox account that will be utulized for student lab assignments.

## Why?
While in the industry, you will be required to use 3rd party tools often. 
It will be rare that you will not be utulizing someone else's too help
with the functionality of your site. 

For our Ecommerce site, we need a payment processor. It's hard to have an ecommerce
site without the electronic payment part. 

## How?
Auth.Net has great documentation. The trick is knowing how to look through it
and where to look. Let's break down the following scenario:

Let's pretend we were presented with the following user story:
```
I, as a user, want to utulize Auth.Net as the payment processor for my ecommerce site.
```

A few assumptions we can make:
1. Auth.Net is a requirement. 
2. It's a payment processing system for our ecommerce site

The first gut reaction from most developers would be, "What the heck
is AUth.NET....and how am i suppposed to integrate it into hte site".

This is where we research it. We start by looking at the website
[Developer AUTH.NET](https://developer.authorize.net/)

When looking at the developer site...where should we start?(Visit the API reference)
- Wow thats a lot of documentation. 

1. API Documentatation
    - Wow, that's a lot.
2. Hello World Link
   - Get Started seems safe

On the get started page, we immediatly see "C#" code.
this is a great place to get serious. Review the code with the class...
actually better yet...make them code review it!

Encourage the students to use the code review...in addition to the API documentation to udnerstand 
what is going on.


Once they have read through the code, let students know that 
most companies that offer services, such as auth.net (even paypal) offer sandbox
accounts. These sandboxes are available so that Developers can get comfrtable
and configure an environment for their appliction. That is what we will be using for our project....the sandbox account. 

Point the students to the [Testing GUide](https://developer.authorize.net/hello_world/testing_guide/)
This is where they can learn more about the bounds of Auth.NET and what they can and can't do while playing with the provider.

Have student review the testing guide for a bit. Talk to them about
what the capabilites are. This should expose them what types of actions they can do
with AUth.Net to force certain responses. 


## Demo Code

Now it's time to demo it.

Much like we have been doing, we will keep our payment process loosely coupled.
this means we will need to make an interface called `IPayment` that will be the data layer
between our web application and hte actual payment processor. We won't do that right away though.
let's jsut create the class first, then refactor from there. 

1. Create a class named `Payment`.
2. Take the code from the Documentaion and and implement into a `Run()` method in the `Payment.cs` class.
3. As a class...talk about how your can break the code down..is it possible?
    - What type of information do we need from the user to make the transaction possible?
    - Do thye see anywhere that could be exported to an external method within this Payment Class?
4. Slowly refactor the code out together.
5. Eventually we should be able to just call `Payment.Run()` from our approriate checkout controller and 
be able to process the paymnet...wait for a rseponse...and redirect to hte reciept page with the approrpriate information
6. Do we want to save this infromation anywhere in the database?
    - should we keep track of all the transactions?
    - what information should we save?
7. Can the students review the documentation and what was demo'd and relay bakc the work-flow and dataflow of
this 3rd party srevice provider? What information is the client actually saving? Is it secure? Safe?
8. to be clear **We will not be accpeting custom CC numbers, they are instructed to use a drop down menu of CC from the testing documentation**

9. To create a payment processor, what is the bare miniumum required for our payment to be utulized for dependency injection?
    - Should be just `Run` or `ProcessPayment`. 