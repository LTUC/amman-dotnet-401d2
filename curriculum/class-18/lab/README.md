# Lab: Identity

## Assignment Specifications

Building off of your Async Inn API, integrate identity by completing the following:

1. Create an Applicaiton User `ApplicationUser:IdentityUser`
2. Update your `DbContext` to derive from `IdentityDbContext<ApplicationUser>
3. Update your database to integrate in the Identity database tables
4. Register Identity into your Startup file `services.AddIdentity....`
5. Create an Account Controller and add both Register and Login actions
6. Confirm that you can register a user successfully in the database
7. Confirm that you can login with the credentials of an existing user


## README

Update your README with description of what identity is and attach a full report (including images) explaining the process flow surrounding User Registration and Login

This should be conceptual (steps followed) as well as practical (UML)


## Rubric

The lab rubric can be found [Here](../../resources/rubric){:target="_blank"}

## To Submit this Assignment

- Create a new branch named `NAME-Lab#` in your `AsyncInn` repository
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
