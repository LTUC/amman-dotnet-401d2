# Class 17

## How do I prep for today?


## Code Review
 Code Review
   - Expect to walk through the creation of a 2nd service and interface. Inject that interface into the controller and refactor the controller to use the interface instead of the DBContext.
   - Show what the "join table controllers" look like. They will be injecting more than one interface into that controller. Show them how to use both to get different pieces of data from different injected data. 

## Lecture

1. **Routing**
    - **Why** (5 minutes)
        - We don't always want to expose our controller endpoints when working with clients. We also want to keep our endpoints RESTful and clean. 
  - **What** (10 minutes)
        - We can change a the route specifically in ASPNET Core by adding the `Route()` to the HTTPAction tag. We control what the routes look like from the client side.
  - **How** (30 minutes)
        - Update the HTTP Action Tags above each controller action: `[HttpGet,Route('my/new/route`)]` (this will make the route `/api/[controller]/my/new/route). You can also add in special ids into the routes like so: `Route("route/{myId}")`, just make sure you accept an `int myId` as a parmater in the action so the modelBinding can bind.  

2. **Testing**
    - **Why** (5 minutes)
        - We need to make sure our code is reliable and behaves as we expect. 
  - **What** (10 minutes)
        - Testing allows us to make sure that our methods within our service work exactly as we expect. 
  - **How** (30 minutes)
        - Create a new Xunit project, similar to how you did it before with your console apps. Show how to explicietly test the service for the CRUD calls. 

3. **Deployment to Azure**
    - **Why**
        - we need our app to be globally accessible. to do this, we use Azure to host our database, and our server side application. 
    - **What**
        - 
    - **How**
         - In addition to "right click publish", we also need to deploy our database. Refer to the "deploy cheat sheet" doc on directions. (Resources/deployment), share this doc with the students

## What changed from yesterday? 

Use lots of visuals. Show physical code. Navigate around the code base with them so they know no "magic" is actually happening. 


## What might students struggle with today?  

They are just trying to understand DI and the Repo Design Pattern. 

## What bugs, issues, or surprises have come up in the past for this class?

## General comments
The students have until the night before project week starts to complete this assignment. They have some time to complete their tasks and add some CSS to the pages to make it look professional. 


