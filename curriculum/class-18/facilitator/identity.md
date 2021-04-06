# Identity

## What is Identity

Identity is the ability to add Authentication and Authorization to your web application. This includes registrations, logins, restricted access to specific members, and authentication through Facebook, Google, Twitter, etc...

ASP.NET Core Identity was created to help with the security and management of users. It provides this abstraction layer between the application and the users/role data. We can use the API in it's entirety, or just bits and pieces as we need (such as the salting/hashing by itself) or email services. There is a lot of flexibility within ASP.NET Core Identity. We have the ability to take or leave whatever we want. Identity combines well with EFCore and SQL Server.

## Why

Identity is used primarily for user management. This includes the security and manipulation of users within the application. Within Identity, we can restrict access to specific parts of the site through policies, assign specific roles to users, and allow for 3rd party authenticaion using OAUTH.

## How

Open up with some basic definitions with the students and discuss the differences between them:

**Authentication**: the process of determining _who you are_

**Authorization**:  The ability to tell a user **what they are allowed to do** Example is permissions.

This demo assumes you have a very basic MVC app already created.
Use the *ADO_Scaffold_Demo* as starter code if needed. Your end result
should match the *CMSDEMO* project in the Demos folder.

1. Under `Configure()` in your Startup class, add `app.UseAuthentication();` after the `app.UseRouting()` middleware.
     - This is what actually allows us to authenticate users within identity.

After you've enabled Authentication in your Startup.cs file, you will need to create an actual user that will be used within the application.

1. Create an `ApplicationUser` Class that derives from `IdentityUser`.Talk about what `IdentityUser` is. Dive into the definition of what Identity user is:
    - Right click on the class and select "go to definition".
    - Dive one more step deeper into the definition of the `IdentityUser<TKey>` type to see all the props that are included in Identity user. Notice a few things about the Identity user in the `IdentityUser<TKey>`: Notice that any personal information is not included in the base Identity User. That means that if there is a requriement for more information to be included in on the Identity User than what is given, it has to be added manually.

2. Add some additional props to your `ApplicationUser` so that more information is included when using the Application User.
    - Note that the name of the class does NOT have to be `ApplicationUser` it can be anything, the only constraint is that it is dervived from Identity User.

```csharp
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

    }
```

3. Create an `ApplicationDbContext` that derives from `:IdentityDbContext<ApplicationUser>`
     - We want to create a new database to hold our Identity information. This will be a 2nd DB for our application, and it will teach students how to manage more than one database in a project. We will do this for "separation of concern" purposes, as well as "security" purposes.

```csharp
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {

    }
}
```

4. Since we have a new DB, we have to register it. Go to the Startup file and register your `ApplicationDbContext`

```csharp
services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(Configuration.GetConnectionString("UserConnection")));
```

5. Now, in your `Startup.cs` file add in Identity under your newly registered DBContext.

```csharp
 services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
```

You now will want to create a new migration for each ind. database.

Commands to run in PMC since you have 2 DbContext:

```
Add-Migration newMigration -Context ApplicationDbContext
```

```
Update-Database -Context ApplicationDbContext
```



