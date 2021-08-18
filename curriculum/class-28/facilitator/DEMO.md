# Demos: Authentication, Authorization, Cookies

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## HTTP Cookies

Create 2 routes in the Home Controller -- one to set a cookie, one to read it, along with 2 views that will show the cookie value

1. `Remember` will look for a `name` query string and store it as a cookie
   - Create this route and view first. Load it up, and add `?name=Your+Name` to the url
   - Once you do this, open the Browser Inspector and then the "Application" tab and see that the cookie called `name` is present
   - Repeat the process, proving that you can change the cookie value
   - Note that you can also change the key as well, by altering the Controller
1. `Iam` will read that cookie, add it to `ViewData` and render it out.
   - Build this route and the associated view
   - When you visit `/home/me` in the browser, it'll show the users name
   - NOTE: ViewData is a "global" and default dictionary that you can use to feed unstructured data to the view.
1. Close the application and restart
   - You can now go back to the `/home/me` page and it'll remember you

HomeController.cs

```csharp
public IActionResult Remember(string name)
{
  if (name != null)
  {
    CookieOptions cookieOptions = new CookieOptions();
    cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
    HttpContext.Response.Cookies.Append("name", name, cookieOptions);
  }
  return View();
}

public IActionResult Iam()
{
  string name = HttpContext.Request.Cookies["name"];

  ViewData["name"] = name;

  return View();
}
```

Iam.cshtml

```html
<h1>Welcome Back, @ViewData["name"]</h1>
```

Index.cshtml

> This seems silly and simple, but we'll use this later to prove authentication

```html
<h2>Welcome!</h2>
```

### Cookie Security

Cookies are only valid for a certain time and can only be read by their creator domain.

1. You can prove this by going to the `properties\launchsettings.json` file and changing the port, and then re-opening the application.
   - The cookie is no longer there!
   - This is because the domains don't match (yes, the port number is relevant)
1. Change it back and prove that the "right" domain can see it.

But there are ways around this ... Discuss!

## Authentication

Internally, the Identity authentication scheme uses Cookies.

For this part of the demo, we'll be focusing on the MVC aspects of Authentication and Authorization. As we've previously built out an entire Identity system, we'll be bringing in the bulk of that

### Auth Folder

This folder contains all of the Auth Models and services pre-wired. Note that students are permitted to use this as they pseudo-library as they build their own stores. Note that the namespace in the files might cause them issues, so warn them to change appropriately.

> Differences and talking points are noted below

### Getting Started

- Install Identity
- Install EntityFrameworkCore, Tools, SqlServer

### Startup.cs

In your startup file, we'll want to add the services for Identity and Authentication in the `ConfigureServices()` method:

> Note, we're specifying `<AuthUser>` as a type ... we'll need to create this, as well as our `DbContext`

```csharp
  services.AddDbContext<DemoDbContext>(options =>
  {
    string connectionString = Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
  });

  services.AddIdentity<AuthUser, IdentityRole>(options =>
  {
    options.User.RequireUniqueEmail = true;
  })
  .AddEntityFrameworkStores<DemoDbContext>();

  // Invalid user redirects
  services.ConfigureApplicationCookie(options =>
  {
    options.AccessDeniedPath = "/auth/index";
  });

  // Alternative to JWT, use the built-in authentication system
  services.AddAuthentication();
  services.AddAuthorization();
  services.AddTransient<IUserService, IdentityUserService>();
  services.AddMvc();

```

In the `Configure()` method, add the following middleware, after `use.Routing()`

```csharp
app.UseAuthentication();
app.UseAuthorization();
```

### DbContext

Ref: `data\AuthDbContext.cs`

The DbContext is the same as it was for our previous project.

### Users Model and DTO's

Note that we're putting the "Auth" specific stuff in a sub-folder here to keep it as segregated as we can from the core sytem.

The models, other than no longer referencing Tokens are unchanged from previous implementations

Ref: `Auth\Models\AuthUser.cs`

Ref: `Auth\Models\Dto\LoginData.cs`, `RegisteredUserDto.cs`, `UserDto.cs`

### AuthUser Interface/Service

Ref: `Auth\Services\Interfaces\IAuthUser.cs`

Ref: `Auth\Services\IdentityUserService.cs`

> Note the constructor now brings in SignInManager and not the JWT that they used previously

```csharp
private UserManager<AuthUser> userManager;
private SignInManager<AuthUser> signInManager;

public IdentityUserService(UserManager<AuthUser> manager, SignInManager<AuthUser> sim)
{
  userManager = manager;
  signInManager = sim;
}
```

Additionally, the Login Method is slightly changed to use this service, and we're no longer adding a token to the Dto as this is not needed

```csharp
    public async Task<UserDto> Authenticate(string username, string password)
{

  var result = await signInManager.PasswordSignInAsync(username, password, true, false);

  if (result.Succeeded)
  {
    var user = await userManager.FindByNameAsync(username);
    return new UserDto
    {
      Id = user.Id,
      Username = user.UserName,
      Roles = await userManager.GetRolesAsync(user)
    };
  }

  return null;
}
```

### Register and Login

To build out this part of the demo, you need a few parts:

1. A form that lets a user type credentials and login
1. A page that you can redirect them to after a good login or registration
1. A page that only a user that has credentials can see
1. A "post" route for Register that calls the Register method in the Service and Redirects
1. A "post" route for Login that calls the Register method in the Service and Redirects

These files can be found in:

Ref: `Views\Login`

Ref: `Controllers\LoginController.cs`
