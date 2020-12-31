# Demo for class 27


## Registering an Account

1. Create a new controller named "Account Controller"
2. Create a new action named "Register" with a Post
3. Update the Route to be "Register"
3. Create a RegisterDTO that will hold all req info for registeration
4. Within the register action create a new Applicaiton User and populate it with the basic information needed (FirstName, Lastname, userName, email). Username and Email are the only required fields that need to be populated for AppUser to fully work. 
5. Don't forget to also add in any "additional" information you added to your application USer
6. Once the application user is created, Introduce and talk about the `UserManager` and how that creates the account
7. Capture the result in a result variable and ensure that it is a success before signing the user in.
8. To sign the user in, introduce the concept Identity's "SignInManger"


## Test it out
1. Use Postman
1. Register a user and set the breakpoints to follow the register logic
1. Confirm in the Databse that the user was created

## Login to an Account
1. Create a new POST action called "Login". Update the Route so that it points to `/api/login`.
2. Make a LoginDTO that captures the basic information required for a login
3. Within the Login action, use SignInManager to valide the credentials. 
4. if it's a success, send back an OK,
5.  If it's not, send back a bad requestion with an "Invalid credentials" error.

## Test it Out
1. Log in user you created earlier. 
1. use breakpoints to follow the request
1. Expect a success
1. Do it again to show a bad request


## Introduce JWTs

1. Add the ability to use JWTs in the startup file by registering the JWT Authenticaiton Scheme
2. Next, add the JWTBearer configurations directly
3. JWT token tellsus who you are and what can do
4. is this verifyable?
5. 
