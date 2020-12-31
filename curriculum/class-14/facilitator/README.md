# Class 14: Controllers and Seeding

## How do I prep for today?
Review the `lecture.md` file for an outline of the lecture.

The demo for today is rather large. Get through as much as you can. You may want to
provide for them the official demo code if you don't get all the way through. The minimum highlights that you should cover are in the outline below.

## Lecture Outline

## Lecture
1. APIs
    - **Why**
        - APIs (Application Programming Interfaces) allow us to utulize external code without having to interact with an interface.
    - **What**
        - 
    - **How**
        - In Core, we build API Servers by defining the API tags in the controller and adjusting the routing.
1. **Routing**
    - **Why** (5 minutes)
        - We don't always want to expose our controller endpoints when working with clients. We also want to keep our endpoints RESTful and clean. 
  - **What** (10 minutes)
        - We can change a the route specifically in ASPNET Core by adding the `Route()` to the HTTPAction tag. We control what the routes look like from the client side.
  - **How** (30 minutes)
        - Update the HTTP Action Tags above each controller action: `[HttpGet,Route('my/new/route`)]` (this will make the route `/api/[controller]/my/new/route). You can also add in special ids into the routes like so: `Route("route/{myId}")`, just make sure you accept an `int myId` as a parmater in the action so the modelBinding can bind.  
1. Navigation Properties
    - **Why**
        - Navigation properties help the simple models that you create identify the connections and relationships between the entities. When we are using one of the models, we also have to know who else is using it or where else it should go to get all of the data.
    - **What**
         - 
    - **How**
        - To include Navigation Properties in a LINQ call, use the `.Include()` external method



## What changed from yesterday? 

Building off of yesterday's demo, pick up where you left off. 
The "code review" today should be a review of Dependency Injection and the Repository Design Pattern, how to create and register it, and how to create the scripts.

Keep repeating these concepts over and over again...

## What might students struggle with today?  
Concept of Nav properties are a bit trickey to grasp at first.

## What bugs, issues, or surprises have come up in the past for this class?

## General comments
- N/A