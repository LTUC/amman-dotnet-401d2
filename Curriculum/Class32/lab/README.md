# Lab 32: Sprint 2 - Milestone # 2

Your whole workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. 

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.

## User Stories & Guidance:

Here are the user stories for Milestone 1:

1. (Developer 1 & 2) As a user, I would like dedicated location where I can see all the products I wish to purchase. 

1. (Developer 1) As a user, I would like to see the current items in my basket while browsing the site.

1. (Developer 2 & 3) As a user, I would like to quickly add items to my basket on the product details page


### Guidance

**User story 1:** You and your partner need to figure out how you are going to capture a user's cart items. This is going to required a database change. You will need to take into consideration that each user will have their own cart, and that they could potentially have a quantity of a specific product to be larger than 1. 

Refer to the Store DB ERD in your ECommerce assets as a suggestion on how to lay out your database. This is just a suggestion and you may chose to follow it if you are unsure how to restructure your database to handle cart items. 

After you have setup your database to handle the storage of items in a cart, create a dedicated route of `/Cart`. You may chose to have thi be a controller or a razor page. 

Within this dedicated cart page, make sure that you can edit the qty of the product, delete the item from the cart, or click on the product directly and be redirected to the product details page. 

Refer to the suggested checkout wireframe on how to layout your page. 

Your "Checkout" button on this page should not link to anything just yet. 

**User story 2:** This is where view components come in. Create a view component that queries the database for all the items/products that the user has in their cart, and displays it on more than one page of the site. Display your "mini-basket" on the individual product landing pages. 
	
**User Story 3:**  This is just adding a button to onto the product landing page. This button will have the text "Add to Cart". When this button is clicked, it will execute the post method and add that product to the user's cart. This should all take place on the database side. _**You will need**_ to setup your cart to use an interface for cart CRUD operations. Similar to how you are getting products...do the same for cart manipulation. 


### Tests
Test your serivces that are implementing your interface.


## To Submit this Assignment

Submit the answer to the following questions:
1. What suprised you most about this milestone?
1. How long did it take you to complete this milestone?
1. How long did you expect to take?
1. What did you find most challenging about this milestone?
1. What do you need to continue to work on during this project?
1. Any Concerns that the instructional staff should be aware of?