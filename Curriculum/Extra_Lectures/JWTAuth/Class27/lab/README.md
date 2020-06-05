# Lab 27: Add Authentication


## Instructions:

Build off of your lab 26 and add:
1. An `AccountController`.
2. Routes within the new controller to register and login
	- Register: `api/account/register`
	- Login: `api/account/login`
3. Have both actions return an `Ok()` with the JWT token included

Within your JWT token, include the following information:
1. User's First Name
2. User's Last Name
3. User's UserId

### Additional

A few things to keep in mind:
1. Don't forget to create your DTOs for both Register and Login
2. Use the demo code as a resource
3. Test all routes wtih Postman and breakpoints to ensure you are receiving expected behavior. 


## Tests

No additional tests required for today


## To Submit this Assignment

