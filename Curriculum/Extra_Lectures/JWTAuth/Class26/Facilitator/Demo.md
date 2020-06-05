# Intro to Identity Demo

The demo for this week will be a posts API that the user can:

1. Create their own personal posts
2. Share posts with other users

This is a stripped down version of what their lab will be.

Follow these steps to create the demo:

1. Create a brand new empty web project
1. Set your middleware to `services.AddControllers();` 
1. Create a basic Model for `Post`
1. Create a basic DbContext `BlogDbContext`
1. Register the Db in the Startup (don't forget to setup for DI)
1. Scaffold a basic API with read/write actions (don't scaffold from EF)
1. Create an interface and a service for the CRUD operations on your model
1. Integrate the Interface into your Controller

Next, Now that we have a baseline, let's add in identity:

1. Add the Identity DB Context (`UsersDbContext`)
1. Add the Application User
	- Add any additional info we need such as firstname or lastname. 
	- Show them the "tree" of how it is all derived.
1. Register the DbContext
1. Register Identity
1. Create a migration for the new database
	- notice the error of needing to knwo what context?
	- `add-migration -context usersdbcontext`
	- `update-dateabase -context usersdbcontext`
	- Notice the contents of the migration that got added. The tables?
1. Notice the 7 tables that identity gives us within the database. Explore them. 

1. If there is time, deploy the app to Azure.


The end result should be:
2 databases
1. model
1 controler
1 service
1 interface
