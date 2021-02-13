# Facilitators Guide: Razor Pages


# Class 31 : View Components

## How do I prep for today?
This is the start of Sprint #2.

You can start the demo for today by extending the Demo from class 29. Don't forget to setup user secrets!

## Lecture Outline:
1. Code Review
   - Review Sprint 1
   - Request one or two students showcase their sprint 1 with the class and discuss what they are proud of and what they struggled with.
1. [View Components](./viewComponents.md)
   - What:
     - View Componenets are often referred to as "mini controllers" that can be inserted/injected into an cshtml page. This means that we can use these "mini controllers" to access data and manipulate objects as needed.
   - Why:
     - Reusability of specific components to be inserted on cshtml pages is fairly common. This can be something as simple as a login screen, or interactive such as a mini cart within an e-commerce project.
   - How:
     - View Components are created by creating individual components often located in a "Components" folder within the models. These compents then act as mini controllers where you can access and return specific data from models. To insert a specific component into a page, call the component direclty onto the .cshtml page.
    - Review the demo code for implementation details

## What changed from yesterday?
Building off of yesterday's demo

## What might students struggle with today?
The lab is requiring they start to build out the architecture of their database
to hold the Basket items and basket for the user.

## What bugs, issues, or surprises have come up in the past for this class?


## General comments

### Guidance / Questions

- On your indivual product landing page that showcases a single product, add an "Add to Cart" that will place that individual product to the user's cart.
- Create the view component that will show all the current items in the cart. Place this on the individual product page, and later to be put in the checkout page.
- Create a specific basket/cart page that shows all the items the user wishes to purchase. Remember to include the qty and the ability to do basic CRUD operations. Add a "Checkout" button at the bottom of this page. Don't have it link to anything yet. We will do that tomorrow.
