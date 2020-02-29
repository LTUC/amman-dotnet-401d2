# Lab 12: Databases and ERDs

## Problem Domain

Today will the be the beginning of a multi-lab project where you will build out the API server for a Hotel Asset Management system.

The owners of "Async Inn" have approached you with plans to renovate their hotel chain. Currently they are tracking all the different locations and rooms in spreadsheets and binders. They currently have about 10 binders full of paperwork that consists of the difference between each location and the pricing for each room. The amount of time and paperwork it takes to manage the rooms and locations is costing the company both time and money. They are currently looking for a  "better way" to maintain their business model. 

They are currently looking for a RESTful API server that will allow them to better manage the assets in their hotels. They are anticipating the ability to modify and manage rooms, amenities, and new hotel locations as they are built. They have turned to you to assist them in persisting their data across a relational database and maintain its integrity as they make changes to the system. 

After your meeting with the team, you have extracted some basic requirements about the data and how it should be represented in a database. You are going to attempt a first draft at a database diagram to share with the team later on today. 

To the best of your ability, create a system design of a database ERD diagram that meets all of the requirements below. The diagram should take all of the requirements into consideration and allow a baseline for starting the creation of the web application. 

## Application Specifications

- You have been tasked with creating a web based API for a local hotel chain. Here are the requirements that you obtained from your client during your exploration and requirements meeting.

	- The hotel is named "Async Inn" and has many nationwide locations. Each location will have a name, city, state, address, and phone number.
	- Async Inn prides themselves on their unique layout designs of each hotel room. They advertise as it being your "apartment for the night". This means they have invested a lot of resources into how each room looks and feels. Some have one bedroom, others have 2 bedrooms, while a few are more of a cozy studio. The team mentioned that they like to label each room with a nickname to better tell the difference between each of the layouts and amenities each room has to offer. (for example, the Seattle location has two 2-bedroom suites, but one is named "Seahawks Snooze" while the other is named "Restful Rainier", each with their own amenities.) 
	- They also take pride in the amenities that each room has to offer. This can consist of features like "air conditioning", "coffee maker", "ocean view", "mini bar", the list goes on...They requested that they would like the amenities associated with each of the rooms as they do vary. 
	- The rooms vary in price, per location, as well as per room number. They also have a few rooms that they want to advertise as pet friendly.
	- The number of rooms for each hotel varies. Some hotels have only a few rooms, while others may have dozens.

## Guidance
Build your ERD (Entity Relationship Diagram) so that it has at least:
1. (1) Joint Entity Table with Payload
1. (1) Pure Join Table
1. (1) Enum 

Within your ERD identify/label the following as necessary:
1. Primary Keys
1. Foreign Keys 
1. Composite Keys (where they exist)
1. Navigation Properties (What other entities are related? Why?)
1. Relationships between tables (1:1, 1:Many, Many:1, Many:Many etc...)

In a external document, please provide an explanation of the components in your database ERD diagram. 

This assignment is **attempt based**. Submit, before the next class start, a healthy attempt on the database design. 

You may work together and collaborate on this lab, but everyone is responsible for turning in their own DB diagram and external file (this can be a link, please make sure names exist on the top). 2-3 sentences for each table is sufficient for an explanation. 

Your submissions must be digital. You may take a picture of your diagram from a white board, but if you decide to stick with your db diagram, and not use the solution provided for your web application, you will be required to transfer your white board image into a cleaner format. 

## Stretch Goals

## Additional Resources

## ReadMe

## Rubric

## To Submit this Assignment