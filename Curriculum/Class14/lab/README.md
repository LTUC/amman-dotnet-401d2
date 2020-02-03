# Lab 14: Entity Framework & Seeding

## The Problem Domain
To continue with your AsyncInn Hotel Management System, you need to seed hotel data to display in your application. 
For Today's branch, focus on working within the existing code base that was scaffolded out (If you chose to scaffold). Practice learning and understanding a code base that you didn't write, but need to make modifications too.

## Application Specifications

##### Design
Think about the design of your website. What will it look like? What pages will exist? How do the pages interact and link to each other? For our website, we will have the following pages:
1. Home Page to greet the Hotel Admin. This page will also serve as a dashboard for the other locations of the site.
1. Hotels page that will allow the Admin to create and edit new or existing hotels
1. Rooms page where the Admin will be able to create or edit new or existing rooms
1. Amenities page that will allow the Admin to add to their list of existing amenities
1. A page where they can link the Amenities to the rooms that currently exist
1. A page where they can add existing rooms to hotels

Following the design, Create a controller for each of the pages listed above. You should "Add >> Controller" on the controllers folder and scaffold out the basic CRUD operations.


Your application should include the following:
1. Seed your database with at least 
	- 5 default Hotel Locations
	- 6 Room Types
	- 5 Amenities. 
1. *Do not* make any seeded associations with `HotelRoom` or `RoomAmenities`.
1. Update the dropdown lists to include the `Layout` enum, and associations between the `Room` and `Hotel`, as well as the `Room` and `Amenities`. Be sure to display user friendly information in your views (example: display string names instead of ids).
1. Based off of the readings from day 14, either utilize bootstrap (download it into your project from NuGet), or remove all bootstrap specific classes in your HTML. (clean it up!)
1. Add your own styling to the Hotel creation page, Room Creation Page, and Amenities creation page.
1. On the Home Page, create a navigation to the Hotel, Room, and Amenities pages that display all of the contents in the database respectively. 
1. On the Rooms, Hotels, and Amenities landing page, be sure to include a link that allows you to create a new room within the overall lists. 
1. Create a page named "HotelRooms: that allows you to associate a specific Room with a specific hotel. Refer to the Wireframes `HotelRooms/Update/id&rn=201` wireframe as an example
1. Refer to the provided wireframes as examples of what these pages should look like and function. Feel free to use the automatic scaffolding. Don't forget to modify/remove any extra code that is not needed. 

## Guidance
- There is no extra guidance for this assignment.


## Unit Tests
- There are no Unit Tests required for this assignment.

I **strongly** encourage you to research how to write tests for a .NET Core MVC application. Attempt to write some tests, as they will eventually be required.  Research, start here: [Testing a Controller](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing){:target="_blank"}. 

## Stretch Goals
These goals will be required in an upcoming lab, but feel free to start a bit "early":
1. Update/Edit your `RoomAmentities` page to not allow edits. 
	- You should only have the option to create associations, and delete associations.
	- If you scaffolded the controller, this will require the removal of the actions and view pages from the scaffold code, as well as existing links. 
1. Leverage the use TagHelpers and View Models to identify the correct association to remove.
1. Modify the existing code to edit a `HotelRoom`.
	 - Allow a user to edit a `HotelRoom` combination. 
	 - Remember that a Hotel cannot have more than one of the same RoomNumber. Be sure to either implement error handling or some other way to prevent the user from doing so. 
	 - View Models and TagHelpers will be required to send the data back and forth from the server

## Additional Resources
- There are no additional resources provided for this assignment.

## README
**A Readme is a requirement. No Readme == No Grade.** 
Here are the requirements for a valid readme:

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.

Your job is to

1. tell them what it is (with context, provide a summary)
1. show them what it looks like in action (Visuals)
1. show them how they use it (Step by step directions, "Happy Path" walk through)
1. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

Refer to the README templates in the class repo `Resources` folder for an example. 
- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"} 


## Rubric

The lab rubric can be found [HERE](../../Resources/rubric){:target="_blank"} 


## To Submit this Assignment
- Create a new branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)


