![cf](http://i.imgur.com/7v5ASc8.png) Lab 12: Relational Databases
=====================================

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- Include a `README.md` (contents described below)

## Directions

### Requirements
You have been tasked with creating a web based application for a local hotel chain named the "Async Inn". Here are the requirements that you obtained from your client during your exploration and requirements meeting.

#### Hotel Requirements
1. The hotel can hold many guests at any given time, in fact guests can come and go as the please.....asyncronously :) 
2. The hotel is named "Async Inn" and has many nationwide locations. Each Hotel will have a City, State, Address, and phone number.
3. Each hotel room can be one of three types, A master suite, Luxery suite, or studio.
4. The price varies for each room.
5. To follow local regulations, you must also indicate if a room is ADA accessible.
6. The number of rooms for each hotel varies. Some Hotels have only a few rooms, while others may have dozens.

#### Customers
1. The first time a customer calls in for a reservation, they give their First Name, Last Name, and phone number
2. Whenever they make a new reservation, they have to provide the check in date, checkout date, What hotel they are booking at, and what room they are reserving.
3. A customer can only reserve one room from one hotel for each reservation. If they wish to reserve multiple rooms, they must submit multiple reservations. 

Generally speaking, a Customer can have any number of reservations at any number of hotels. The client has requested that a customer could potentially view all of their previous reservations, as well as a singe hotel being able to tell how many reservations they currently hold. 


### Assignment
To the best of your ability, create a system design of a database schema that meets all of the requirements above. The schema should take all of the requirements into consideration and allow a baseline for starting the creation of the web application. 

Build your schema so that it has at least:
1. (1) Joint Entity Table with Payload
2. (1) Pure Join Table (Composite keys!)
3. (1) Enum 

Within your Schema identify/label the following as necessary:
1. Primary Keys (for each table)
2. Foreign Keys (for each table as necessary)
3. Composite Keys (where they exist)
4. Navigation Properties
5. Relationships between tables (1:1, 1:Many, Many:1, Many:Many etc...)


This assignment is **attempt Based**. Submit, before the next class start, a healthy attempt on the system design. 

You may work together and collaborate on this lab, but everyone is responsible for turning in their own DB Schema. 

Your submissions must be digital. You may take a picture of your schema from a white board, but if you decide to stick with your db schema, and not use the solution provided for your web application, you will be required to transfer your white board image into a cleaner format. 

Submit your schema in canvas as an image, or a link to an image. in the text, or in an external doc of some sort, provide the explanation for the relationship between each table and why. (1-2 sentences for each table is sufficient. ) 

## Tests
No tests are required for this lab. 

