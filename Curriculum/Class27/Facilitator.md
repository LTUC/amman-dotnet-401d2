# Class 27

## How do I prep for today?
Now that the students have paired up and created their foundation of their project,
now we can start adding in Identity. 

Be sure that you read the "readings" for the day as well as the sources for each of the lecture
topics in the resources folder. These are great introductory articles to the 2 new concepts we are introducing today. 

Before Lecture:
   -  Scaffold out some "starter code" for your lecture. You will not have time during
lecture to have a complete code base that they can use as a reference. You will need to add the following
code off of Class 26's demo code:
        - Create an Interface (`IPostManager`)
        - Create a new service (`PostService`)
        - Seed some data into the BlogDbContext

- Refer to the provided demo code for assistance in scaffoldng out the files listed above. 
Lecture consists of:
2. [Razor Pages](./Resources/RazorPages.md)
   - Register Page
     - Page Model
     - OnGet and OnPost
   - Login Page (Can be pushed to Class 28 if needed)
   - Test that it works!
     - This can be done by looking in the DB for the new entry!


## What changed from yesterday? 
Building off of yesterday's demo. We will be adding Authentication and Authorization
to our application

## What might students struggle with today?  
Razor pages are new and a little different than what they are used to. Ideally, after
creating a Register and Login page, they should get the idea of what a Razor Page is. 

## What bugs, issues, or surprises have come up in the past for this class?
Often students forget the `.UseAuthentication()` in the configure method in the startup file.

## General comments
Lots of moving parts. 