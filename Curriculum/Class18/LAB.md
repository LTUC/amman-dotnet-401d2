![cf](http://i.imgur.com/7v5ASc8.png) Lab 18: Finish up!
=====================================

## To Submit this Assignment
- Create a branch named `NAME-FINAL`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)


## The Problem Domain
Finish up your `Async Inn` Hotel Management project.


## Application Specifications
- Your application should include the following:
1. Deploy to Azure (reference link in your Readme)
	- application *MUST* be deployed to Azure. No grade will be given to non-deployed apps.
2. Implement User Secrets instead of the default configurations
2. CSS/HTML should be present on **all** pages of the project.
	- Utilize "layouts"
	- Use "partials" as needed
3. Update/Edit your `RoomAmentities` page to not allow edits. 
	- You should only have the option to create associations, and delete associations.
	- This will require the removal of the actions and view pages from the scaffold code, as well as existing links. 
4. Leverage the use TagHelpers and View Models to identify the correct association to remove.
5. Modify the existing code to edit a `HotelRoom`.
	 - Allow a user to edit a `HotelRoom` combination. 
	 - Do not create a new service for the modification of HotelRoom, instead, refactor your existing interfaces and and services to include this functionality.
	 - Remember that a Hotel cannot have more than one of the same RoomNumber. Be sure to either implement error handling or some other way to prevent the user from doing so. 
	 - View Models and TagHelpers may be used to send the data back and forth from the server
6. Add/Confirm functionality that if you "remove" a room or a hotel, all of it's associations are also removed
	- If you delete a Hotel, all of the `HotelRoom` associations with that hotel should be removed.
	- If you delete a Room template, all of the `HotelRoom`s that have that room template need to be removed as well as the RoomAmenity associations

7. Write Tests (listed below)
8. The site should be functional, with no errors being thrown. Exceptions handled appropriately, and redirects occurring where they are needed. 


Overall, the look and feel of your site should provide a good client experience.


## Guidance
- There is no extra guidance for this assignment.


## Unit Tests
- Test your application for the following functionality:
1. Test Getters/Setters on all Models
2. Test Standard CRUD operations on all tables (test your services!)


## Stretch Goals
- There are no Stretch Goals for this assignment.


## Additional Resources
- There are no additional resources provided for this assignment.


## README

**A README is a requirement. No README == No Grade.** <br /> 
Here are the requirements for a valid README: <br />


A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context, provide a summary)
2. show them what it looks like in action (Visuals)
3. show them how they use it (Step by step directions, "Happy Path" walk through)
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo `Resources` folder for an example. 
- [sample-README](https://github.com/noffle/art-of-readme){:target="_blank"}

## Rubric

The lab rubric can be found [HERE](../Resources/rubric){:target="_blank"} 