# Roles

The ability to add specific roles within a web app is really useful for security purposes and
the ability to authorize specific users in certain parts of the site. 

Typically, a production site would use something like "Azure Active Directory" Unfortunately, Active Directory setup requires configurations that our 401 class doesn't quite
have the time or resources to support. To still emulate this behavior we implement a work around. 

With Roles, we have to load them into our database a bit different by injecting them into the Startup file and adding a new class inside "ApplicationUsers"

### Demo

1. In ApplicationUser.cs file, create a new class named "Application Roles". It should look like this:

```csharp
public static class ApplicationRoles
{
	public const string Member = "Member";
	public const string Admin = "Admin";
}
```

Next, Create a new class model named `RoleInitializer.cs`. Here is what that file will look like:

 ```csharp
public class RoleInitializer
{
    private static readonly List<IdentityRole> Roles = new List<IdentityRole>()
    {
        new IdentityRole {Name = ApplicationRoles.Admin,
            NormalizedName = ApplicationRoles.Admin.ToUpper(),
            ConcurrencyStamp = Guid.NewGuid().ToString()},
        new IdentityRole {Name = ApplicationRoles.Member,
            NormalizedName = ApplicationRoles.Member.ToUpper(),
            ConcurrencyStamp = Guid.NewGuid().ToString()}
    };

    public static void SeedData(IServiceProvider serviceProvider)
    {
        using (var dbContext =
            new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
        {
            dbContext.Database.EnsureCreated();
            AddRoles(dbContext);
        }
    }

    private static void AddRoles(ApplicationDbContext dbContext)
    {
        if (dbContext.Roles.Any()) return;
        foreach (var role in Roles)
        {
            dbContext.Roles.Add(role);
            dbContext.SaveChanges();
        }
    }
}
```

Walk through the code with the students and code it out in person. 

Finally, modify your `Program.cs` file:

```csharp
public static void Main(string[] args)
{
	var host = BuildWebHost(args);
	using (var scope = host.Services.CreateScope())
	{
		var services = scope.ServiceProvider;
		var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

		try
		{
			StartupDbIntitializer.SeedData(services, userManager);
		}

		catch (Exception ex)
		{
			var logger = services.GetRequiredService<ILogger<Program>>();
			logger.LogError(ex, "An error occurred seeding the DB.");
		}
	}

	host.Run();
}
```

Now that our code is complete, when a new user registers for our site, we need to assign them roles.
We can do that by adding the following code into our Register action:


```csharp
await _userManager.AddToRoleAsync(user, ApplicationRoles.Admin);
```

To check if a user is in a specific role, we can do that like this:

```csharp
await _userManager.IsInRoleAsync(user, ApplicationRoles.Admin)
```

The constants of "ApplicaitonRole" help us avoid user error and inconsistancies between spellings.
Having a constant reference will help keep conistency across the application.