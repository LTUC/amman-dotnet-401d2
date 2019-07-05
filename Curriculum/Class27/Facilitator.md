# Class 27

## How do I prep for today?
Now that the students have paired up and created their foundation of their project,
now we can start adding in Identity. 

Before Lecture:
   -  Scaffold out some "starter code" for your lecture. You will not have time during
lecture to have a complete code base that they can use as a reference. You will need to add the following
code off of Class 26's demo code:
        - Create an Interface (`IPostManager`)
        - Create a new service (`PostService`)
        - Seed some data into the BlogDbContext

- Refer to the provided demo code for assistance in scaffoldng out the files listed above. 
Lecture consists of:
1. [Intro to Identity](./Resources/Identity.md)
   - Register Identity in Startup File
   - Create a new DBContext for Identity
   - Register Action 
   - Account Controller with Login (This topic can get pushed to class 28 if needed)
   - Test that it works!
     - This can be done by looking in the DB for the new entry!


## What changed from yesterday? 
Building off of yesterday's demo. We will be adding Authentication and Authorization
to our application

## What might students struggle with today?  
The Login and register ViewModels can sometimes cause some confusion...nothing major thought...

## What bugs, issues, or surprises have come up in the past for this class?
Often students forget the `.UseAuthentication()` in the configure method in the startup file.

## General comments
Lots of moving parts. 