![cf](http://i.imgur.com/7v5ASc8.png) Lab 31: Sprint 2 - Milestone #1
=====================================

## To Submit this Assignment
Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.


## Directions:

Each milestone will be worth 10 points within the sprint. The grading rubric is specified at the bottom.
 

## User Stories & Guidance:

Here are the user stories for Milestone 1:
1. (Developer 1) As a user, I would like a product landing page for each product, so that I can view individual details about the product.
2. (Developer 1 & 3) As a user, I would like to add individual items to may basket through an "Add to Basket" button located on each product landing page 
3. (Developer 1 & 2 & 3) As a user, I would like a basket to hold the products I wish to purchase. 
4. (Developer 2) As a user, I would like to see the current items in my basket while browsing the site.


### Guidance

**User Story 1:** This page should exist for every product, and it can be done dynamically through views. 
Have a new Razor Page in your "Shop" directory that will allow you to see product specific information. This page should contain:
1. Image of the product
2. Name of Product
3. Description
4. Price
	
**User Story 2:**  This is just adding a button to onto the product 
landing page. This button will have the text "Add to Basket". When this button is 
clicked, it will execute the post method and add that 
product to the user's basket. This should all take place on the database side. 
_**You will need**_ to setup your basket to use an interface for Basket CRUD operations. 
Similar to how you are getting products...do the same for basket manipulation. 

**User story 3:** You and your partner need to figure out how you are going to 
capture a user's basket items. This is going to required a database change. At the 
very least, your Basket should contain a collection Basket Items or Products...
depending on your structure. You should be able to call a user's basket and view all 
the items/products associated with it. Remember that it possible that a user can have 
more than one item in their basket AND more than one type of item (example: I have 
2 blankets in my basket).

Here is a _possible_ example structure that you can keep into consideration as you 
build out your basket: 
1. Basket Table:
   - ID (primary key)
   - UserID
2. BasketItems Table
    - ID
    - BasketID (FK)
    - ProductID (FK)
    - Qty

The above will give us the specific basket for each user and then give us a table to hold all
of the individual basket items. If we ever want to find out what items a user has in their 
basket, we can figure out what the user's basket id is, and then query all the items in the basketitems 
table that share that basket id. 


**User story 4:** This is where view components come in. Create a view component 
that queries the database for all the items/products that the user has in his/her 
cart, and displays it on more than one page of the site. Display your "mini-basket" 
on both the individual product landing pages and the home page. 
	
