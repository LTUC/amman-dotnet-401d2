# Demos: Identity

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Installing and Configuring "Identity"

1. Add Dependency: **Microsoft.AspNetCore.Identity.EntityFrameWorkCore** (@version 3.1)
   - Installs libraries as well as models for identities

## Add an "Application User" Model

> Notice how this inherits from IdentityUser, which we "got for free" from the dependency, which is a default implementation for a user

1. Create the user model
```csharp
namespace SchoolDemo.Models
{
  public class ApplicationUser : IdentityUser
  {
  }
}
```
1. Add this to our `DbContext`
   - In our `Data/SchoolDbContext` class:
     - Change the class to inherit from `IdentityDbContext` instead of `DbContext`
       - This also inherits from `DbContext` as well as to bring in it's own requirements
  - We will also need to uncomment the `base` line, because Identity uses it to add it's own stuff
```csharp
...

  public class SchoolDbContext : IdentityDbContext<ApplicationUser>
  {
    public SchoolDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // This calls the base method, and Identity needs it
      base.OnModelCreating(modelBuilder);
...
```

## Migrate the data

What data? Our model is empty ... actually, we changed it to Inherit from Identity, so let's see what it did

`PM> add-migration identity`

Look all the tables it's about to create!

`PM> update-database`

Now, inspect your DB to see the users tables. They will all be prefixed with `dbo.AspNet`


## Register the identity services

Before we can do anything in our controllers, we need to register the proper services:

1. In `Startup.cs` in `ConfigureServices`
   ```csharp
    services.AddIdentity<ApplicationUser, IdentityRole>(options =>
    {
      options.User.RequireUniqueEmail = true;
      // There are other options like this
    })
    .AddEntityFrameworkStores<SchoolDbContext>();

   services.AddTransient<IUserService, IdentityUserService>
   ```
1. Note the last line. This is an interface and service we need to create ...

## User Service

1. Create an empty `IUserService` Interface
   - Think: What methods do we probably need to manage a user?
1. Create am empty `IdentityUserService` Service Class that implements the above interface
1. Create a new controller `UsersController` (Empty)
   - Use DI to have IUserService injected

Building out the API ... for the first route, work backward
1. Start in the controller and build out the `Register()` method
   - Use `HttpPost("register")` as the method
   - It should take in a specialized data shape as the POST BODY
1. Build a new DTO for this, called `RegisterUser` under `models/api`
1. Next, build the base method in `IdentityUserService` called `Register()` that takes in this DTO and (for now) doesn't implement it
   - Fix the bugs by adding that method signature to the Interface
   ```csharp
    public Task<ApplicationUser> Register(RegisterUser data)
    {
      throw new NotImplementedException();
    }
   ```

At this point, you should be able to post to the route from Swagger or postman, and see the "Not Implemented" error, which is good. We're "Hooked Up"

While here, debug the route and prove that the object is coming in as expected


## Identity: Register: Save the user to the database

1. Connect to Identity's "User Manager" to do the database work
   - The Service needs to implement `UserManager` in the constructor
   ```csharp
   private UserManager<ApplicationUser> userManager;

   public IdentityUserService(UserManager<ApplicationUser> manager)
   {
     userManager = manager;
   }
   ```
1. Next, build out the Register method in the service, using `UserManager`
   - Ref: `Services/IdentityUserService.cs`
   ```csharp
   public async Task<ApplicationUser> Register(RegisterUser data)
   {
     // throw new NotImplementedException();
     var user = new ApplicationUser
     {
       UserName = data.Username,
       Email = data.Email,
       PhoneNumber = data.PhoneNumber
     };

     var result = await userManager.CreateAsync(user, data.Password);

     if (result.Succeeded)
     {
       return user;
     }
     return null;
   }
   ```
1. Run this with simple usernames and passwords.
   - Debug. What does "result" say?
1. Get your data compliant, and try again
   - Result is good, so we get back a full user object with "EVERYTHING"
   - What's that hashed password? Great time to talk about how this actually works ...
1. What happens if you add the same user again?
   - Yep, more errors

How can we modify this entire process to be more user friendly?

  - For the Happy Path, Let's make a new DTO that returns a simplified new user
    - Ref: `Models/Api/UserDto.cs`
      ```csharp
      namespace SchoolDemo.Models.Api
      {
        public class UserDto
        {
          public string Id { get; set; }
          public string Username { get; set; }
        }
      }
      ```
    - Add another fake user to see that the below DTO is being returned right
  - For errors, we're going to use a feature of EF called a ModelStateDictionary
    - This allows us to create any number of key/value pairs to indicate the state of the data model.
    - We can use this to inform the user as to what's happening
    - Change the signature of the method in the Interface and Service:
    ```csharp
    public async Task<UserDto> Register(RegisterData data, ModelStateDictionary modelState)
    ```
    - In the service, create a dictionary of error keys if there's an error
      - Note: This is boilerplate ...
      ```csharp
      foreach (var error in result.Errors)
      {
        var errorKey =
            error.Code.Contains("Password") ? nameof(data.Password) :
            error.Code.Contains("Email") ? nameof(data.Email) :
            error.Code.Contains("UserName") ? nameof(data.Username) :
            "";
        modelState.AddModelError(errorKey, error.Description);
      }
      ```
## Identity: Login: Authenticate a user

To handle login/authenticate, repeat the above process, but with login methods/inputs

1. Create the route in the controller
   - Ref: `Controllers/UsersController.cs` - `Login`
1. Create in inbound DTO for user input
   - Ref: `Models/Api/LoginData.cs`
1. Create the handler in the service
   - Ref: `Services/IdentiryUserService.cs` - `Authenticate()`
1. Create the definition in the interface
   - Ref: `Services/Interfaces/IUserService.cs`
