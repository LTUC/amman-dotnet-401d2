# Lab 17: Searching, Sorting & View Models

## Assignment Specifications

Building off of your Async Inn web application, include the following:
1. Add data annotations to your existing models to validate basic user input fields as appropriate.
1. Add a layout that will be inherited/utilized on all of your pages (if you haven't already). 
2. Implement a "search box" or filter on all of your model landing pages (Hotels, Rooms, and Amenities) 
	- Use [this resource](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-2.1){:target="_blank"} for assistance
3. While adding partials is not required, see if you can find a way to utilize them within your layouts

4. Allow the functionality on your `HotelController` to display the total number of hotels that exist in the database, as well as the number of Rooms that each hotel has. 
5. Allow the functionality in your `RoomController` to see the number of Amenities that each room has
6. At the top of all 3 of your base controllers (`Hotel`, `Room`, `Amenities`) include a total count of the asset. 
	- Example: if you have a total of 5 Hotels, the top of your Hotel home page should say that you have 5 total hotels in the system.

## Guidance
- There is no additional guidance for this assignment.

## Unit Tests

There are no additional Unit Tests required for this assignment.

I **strongly** encourage you to research how to write tests for a .NET Core MVC application. Attempt to write some tests, as they will eventually be required.  Research, start here: [Testing a Controller](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing){:target="_blank"}. 

## Stretch Goals
- There are no Stretch Goals for this assignment.

## Additional Resources
- There are no additional resources provided for this assignment.

## README

You're README should include:
1. Introduction to your application
2. Database ERD

## Rubric

The lab rubric can be found [HERE](../../Resources/rubric){:target="_blank"} 

## To Submit this Assignment

- Create a new branch named `NAME-Lab#` in your `AsyncInn` repo
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)