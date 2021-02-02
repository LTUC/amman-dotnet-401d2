# Demos: Testing and Swagger and Deployment

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Tests

Questions:

Where do we test?
- Local Computer?
- What about on Github actions?
- What about somewhere else?

You can't just pull in a DbContext, which is the actual connection...

Let's create and use an Abstract "Mock Database Test Class", which lets use setup and tear down a testing database in memory for each test.

- DB is "created"
- DB is "used" by the tests
- DB gets destroyed

This can run agnostically in any environment!

- Start by creating the Mock
- Notice how we implement the Test Base Class!
- Need to add a test student and a test course before we can test
- Doing this in the test base?

```csharp
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SchoolTests
{
  public abstract class Mock : IDisposable
  {
    private readonly SqliteConnection _connection;
    protected readonly SchoolDbContext _db;

    public Mock()
    {
      _connection = new SqliteConnection("Filename=:memory:");
      _connection.Open();

      _db = new SchoolDbContext(
          new DbContextOptionsBuilder<SchoolDbContext>()
              .UseSqlite(_connection)
              .Options);

      _db.Database.EnsureCreated();
    }

    public void Dispose()
    {
      _db?.Dispose();
      _connection?.Dispose();
    }

    protected async Task<Student> CreateAndSaveTestStudent()
    {
      var student = new Student { FirstName = "Test", LastName = "Whatever" };
      _db.Students.Add(student);
      await _db.SaveChangesAsync();
      Assert.NotEqual(0, student.Id); // Sanity check
      return student;
    }

    protected async Task<Course> CreateAndSaveTestCourse()
    {
      var course = new Course { CourseCode = "test", TechnologyId = 1, Price = 1000 };
      _db.Courses.Add(course);
      await _db.SaveChangesAsync();
      Assert.NotEqual(0, course.Id); // Sanity check
      return course;
    }
  }
}

```

Now, your tests can use this mock instead of SQL Server and can create/delete records

```csharp
using SchoolDemo.Models;
using SchoolDemo.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SchoolTests
{

  public class CourseTests : Mock
  {
    [Fact]
    public async Task Can_enroll_and_drop_a_student()
    {
      // Arrange
      var student = await CreateAndSaveTestStudent();
      var course = await CreateAndSaveTestCourse();

      var repository = new CourseRepository(_db);

      // Act
      await repository.AddStudent(course.Id, student.Id);

      // Assert
      var actualCourse = await repository.GetOne(course.Id);

      Assert.Contains(actualCourse.Enrollments, e => e.StudentId == student.Id);

      // Act
      await repository.RemoveStudentFromCourse(course.Id, student.Id);

      // Assert
      actualCourse = await repository.GetOne(course.Id);
      Assert.DoesNotContain(actualCourse.Enrollments, e => e.StudentId == student.Id);
    }
  }
}
```

### Automating Test Runs at Github

Create a GitHub action (there are templates provided) to auto-run your tests when you check in  your code.


## Swagger

The following steps help us to create live documentation using Swagger definitions.


1. Install Dependency: Swashbuckle.AspnetCore
1. In `Startup.cs`, configure a new service dependency
   ```csharp
   public void ConfigureServices()
   {
     ...
      services.AddSwaggerGen(options =>
      {
        // Make sure get the "using Statement"
        options.SwaggerDoc("v1", new OpenApiInfo()
        {
          Title = "School Demo",
          Version = "v1",
        });
      });

   }
   ```
1. Create the new routes so that swagger "works"
1. In `Startup.cs`, add this to `Configure()`
   ```csharp
   app.UseSwagger( options => {
    options.RouteTemplate = "/api/{documentName}/swagger.json";
   });
   ```
  - `documentName` is the `version` you gave in the previous step


Now ...

https://localhost:PORT/api/v1/swagger.json

Boom! You get a fully configured Swagger compatible JSON definition.

You can plug this directly into Swagger.io and see your live API


### Even better, let's serve our own docs...

```csharp
app.UseSwaggerUI( options => {
  options.SwaggerEndpoint("/api/v1/swagger.json", "Student Demo");
  options.RoutePrefix = "docs";
});
```

Now ...

http://localhost:PORT/docs is the actual documentation for your API.

You can set `RoutePrefix` to "" to make your API Documentation the Home Page for your API


## Azure Deployment

1. Create an Azure Account
1. Create a "Subscription"
1. Right click your app, and choose "Publish"
1. Follow the wizard
  - Database Creation
  - Username/Password
  - Deployment Slots, etc

Things to focus on:

- App Services
- App Components at Azure
- Deployment Process

When you're all done, hit the website given.

The basics will work, API will not because of Migration.

This is a good time to show students how to add an Env Variable to the app. Notice that the 500 error gives no information. If we add this env var, we can see the developer page:

`ASPNETCORE_Environment=Development`


### Auto-Migrate on start

Change your `Program.cs` file from this:

```csharp
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }
```

To This:

```csharp
public static void Main(string[] args)
{
  var host = CreateHostBuilder(args).Build();

  UpdateDatabase(host.Services);

  host.Run();
}

private static void UpdateDatabase(IServiceProvider services)
{
  using (var serviceScope = services.CreateScope())
  {
    using (var db = serviceScope.ServiceProvider.GetService<SchoolDbContext>())
    {
      db.Database.Migrate();
    }
  }
}

/*
 * The above can also be written like this, which is far cleaner, yet less explicit, without the nesting
 *
 * using var serviceScope = services.CreateScope();
 * using var db = serviceScope.ServiceProvider.GetService<SchoolDbContext>()
 * db.Database.Migrate();
 *
 */

```

### What are those `using` statements?

At the top of file, we have `using` declarations, which declare the dependencies our module needs to "use"

Using statements say "I have a thing I want you to clean up when you're done" ... essentially, here we are creating a temporary scope in which to run our Migration and then have that temp DbContext go away in favor of what the app will actually use.
