# Demos: Intro to MVC

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## MVC Demo


1. Scaffold an empty MVC app
   - Folders for controllers, models, views, wwwroot
   - Configurations in the Startup.cs file
   - Basic Controller (Home)
     - What does `return View()` do?
     - What is `View` (it's just a string) ... `View()` must return a string ...
     - Demonstrate model binding by messing with the query string right in the controller
     - `?name=whatever` binds the QS data to the controller (Model Binding)

Where do things go? Why? How do URLs map to these files?

--------------

### Empty Site

### Startup Class
The startup class is where you will be putting in a majority of your changes and configuration in code. The startup class consists of where we register any required middleware of dependencies that required for our application to run the way we expect. In addition to changes or settings to the HTTP pipeline.

Get comfortable with the startup class, because you will be spending a lot of time in here.

#### Middleware

Start the demo out by adding `.AddMVC`to the Configure() method. This will add the MVC dependencies to the application.

#### HTTP Pipeline

In addition to actually letting the HTTP pipeline know about MVC, we also need to tell it what our default template will be. For example, we have to tell it what is the default location to look for if no page, other than the root domain, is specified.

We do this by adding a "Route Map". to the ConfigureServices. Set your Default route template to be a Home controller with an 'index' action, and a nullable id.

```csharp
app.UseEndpoints(endpoints =>
  {
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
  });
```

Make sure you break down each step of the template and confirm that the students understand why the template is there.

They will be required to write out the template by hand for every lab assignment the first half and midterm. After the midterm, they can use the pre-created default template if they wish.

### Controller

Now that they have the default template created in the Startup class, this is a great segway into creating an actual controller.

Start out the demo by walking through how to create a controller.

**Wizard Method:** Add Controller - MVC ... Empty

**By Hand ...**

1. Start by creating a class
1. Make the class inherit from `Controller`
1. Talk about how "methods" in controllers are called "Actions"
1. Create a new action, with the return type of string
1. return a string from the method.
1. Go to the appropriate page on the site and see the string outputted

Pretty cool huh?

Now play with the query strings in the url.

Go back to your action and require that the action take in a string or an int. go to the url, and append to it the proper parameters and values using the url query syntax.

Make the action within the controller relay back out to the user the values they put in.

Show them what it looks like when you append a url, they should be able to see the values that are being brought in.

This is called "Model Binding." the model is able to see the values it is supposed to accept, and then associates them to the correct parameters from the query, assuming the names are exactly the same.

It is important for the students to know that Controller are in charge of the routing. I like to put in the analogy of the "Traffic Cop". They tell any requests coming in exactly where they need to go (which controller).

### View

Now that we know how to output data back to the user, let's add a view into our 3 part cycle.
AS you can see, a View is not required to output data to our user, because we were able to do just that with just strings.

But what if we want to give the user more than just a string? How about a list of strings, or objects, or misc data that needs to be viewed? This is where views come in. We have the ability to not only output complex data to the user, but also style and design it with HTML, CSS, and JavaScript.

Before we can get to designing our view page, we have to do some small changes to our controller action to allow the view page to render. First, we need to change the return type, we are no longer returning a string to the user, but a View. Within the base `Controller` class, we do this by making the return type `ViewResult` or `IActionResult`.

Next, set your return statement of your action to be `return View()`. This will allow us to call the
appropriate view to get rendered. The `View()` request flow does the following:

1. Looks for the "Views" folder
1. Finds the folder name of the matching controller
1. Finds the `.cshtml` file with the same name as the action

Create an appropriately named Razor View in the views folder
- i.e. `Views/Home/Index.cshtml`
- Add a new Entity (Razor View - Empty)

> How can we add more views and controllers? Where do the files go and what are the methods called? This is a good time to do a short exercise in "mapping out" a big website structure.

In addition to raw HTML ... within the view page, you can write c# by indicating a `@model` directive at the top of the page.
This directive will define for us what type of data will be displayed on our view. the `@model` will declare the value of `Model` when used within the page.

Let's send some data into our view. To do this, we'll create a simple Model class, instantiate it in the controller and pass it to the `View()`

> NOTE: You only need to declare the @model directive if you are bringing information in. If you are only obtaining information with no presentation, you do not need the directive.

### Model

1. What is a Model?
  - The model in an MVC application represents the state of the application and any business logic or operations that should be performed by it.
  - Business logic should be encapsulated in the model, along with any implementation logic for persisting the state of the application.
  - Strongly typed views will typically use ViewModel types specifically designed to contain data to display on that view. The controller will create and populate these ViewModels from the model.
1. The model classes you'll create are known as POCO classes (from "plain-old CLR objects") because they don't have any dependency on EF Core. They just define the properties of the data that will be stored in the database.

Create a new folder named `Models` (The name of the folder doesn't actually matter, but convention tells us to call it Models).

Here you can create any class you want...standard to how you have been creating classes so far. For the demo, create a class named `Person`, and give it some generic properties.

```csharp
public string FirstName { get; set; }
public string LastName { get; set; }
public int Age { get; set; }
public string FavoriteColor { get; set; }
```

This model can be accessed from the controller to instantiate individual students or even create
a list of students.

#### A Single Student:

In the Controller, add this:

```csharp
public IActionResult Index()
{
  Person person = new Person()
  {
    Name = "John",
    Advice = "Drink lots of milk"
  };

  return View(person);
}

```

In the index.cshtml:

```csharp
@model MVCDemo.Models.Person

<h1>Welcome Home ... @Model.Name</h1>
<h2>@Model.Advice</h2>
```

#### A list of people:

Within your Controller, make one of your actions send a `List<Student> students` and have your view accept  a list of students as it's model directive via `http://localhost:PORT/home/folks`

```csharp
public IActionResult Folks()
{
  List<Person> people = new List<Person>()
  {
    new Person() { Name="John", Advice="Eat"},
    new Person() { Name="Cathy", Advice="Walk"},
    new Person() { Name="Allie", Advice="Study"},
    new Person() { Name="Zach", Advice="Work"},
  };

  return View(people);
}
```

You can now traverse through the `Model` within the view:

```csharp
// declare "little model" as a list of Person as it's inbound data
@model IEnumerable<MVCDemo.Models.Person>

<ul>
  @foreach (var person in Model)
  {
    <li>@person.Name</li>
  }
</ul>
```

### View Models

We can even make multiple models and combine them into a "View Model". In this example, we can make a Blog an Article Model, and then a View Model (under `Models/ViewModels/BlogPostVm.cs`) that composes these 2 models into something for the view, like a DTO, but for the View.

#### Controller

```csharp
public IActionResult Article()
{
  Blog blog = new Blog()
  {
    Title = "The World According To John",
    Description = "Wisdom from the bald one..."
  };

  Post post = new Post()
  {
    Title = "Broccoli should be banned",
    Author = "John Cokos",
    Article = "It's gross, just get rid of it.",
    PostTime = new DateTime(2021, 2, 8)
  };

  BlogPostVm blogpost = new BlogPostVm()
  {
    Blog = blog,
    Post = post
  };

  return View(blogpost);
```

#### View
```csharp
@model MVCDemo.Models.ViewModels.BlogPostVm

<h1>@Model.Blog.Title</h1>
<div>@Model.Blog.Description</div>

<article>
  <title><h2>@Model.Post.Title</h2></title>
  <aside>@Model.Post.Author on @Model.Post.PostTime</aside>
  <p>@Model.Post.Article</p>
</article>
```

### Tag Helpers

Tag Helpers allow us to dynamically generate HTML tags from the back end. These look, act, and feel like HTML tags, but are technically rendered as markup only in the final process. For all intents and purposes, these are raw C# code, and using the `asp-` attribute prefix, we can engage in some special renderings

We can use these to link between views given dynamic information (like an ID)

1. Add a new file by going to add ... Razor View Imports, which adds `_ViewImports.cshtml` to your views folder
   - This will now be a part of all your view files
2. Add the helper enabler to this file
   ```csharp
   @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
   ```
3. Now, in the file where you're rendering the list of people, we can show a detail view by creating a tag helper that links to a person. In this example, we're literally sending all of the data back to the controller action just to prove that we can...Change the simple `<li>` from the earlier example to this:
   ```csharp
   @model IEnumerable<MVCDemo.Models.Person>

   <ul>
     @foreach (var person in Model)
     {
       <li>
         <a asp-controller="Home" asp-action="Person" asp-route-name=@person.Name asp-route-advice=@person.Advice>@person.Name</a>
       </li>
     }
   </ul>
   ```
4. Once you've done that, add a new Action in the controller to receive `name` and `advice`, create a new `Person` and send it to a `Person` detail view.


### Using a FORM to POST data back to a view

1. Create a new controller action, `Add` with the following view:

```csharp
<form method="post" action="/Home/Create">
  <div class="form-group">
    <label for="Name">Name:</label>
    <input class="form-control" name="Name" />
  </div>
  <div class="form-group">
    <label for="Country">Advice:</label>
    <input class="form-control" name="Advice" />
  </div>
  <button type="submit" bs-button-color="danger">Add</button>
  <a class="btn btn-primary" href="/Home/Index">Cancel</a>
</form>
```

This intake form maps the name attribute and model binds that to the appropriate property for our model
1. If you did bring in a `@model`, then the for will bind to the property
1. If you did not, then the for will bind to the parameter that you have set in the controller within the `[HTTPPOST]` action.

Once you add the submit button, you will need to make an additional action in the controller that has an
`HttpPost` flag at the top.

### Redirects


Finally, add the new user and then show the redirect capability from one action to another

```csharp
// Show the add user form
public IActionResult Add()
{
  return View();
}

// Accept a new user and then show their details
[HttpPost]
public IActionResult Create(string name, string advice)
{
  Person person = new Person()
  {
    Name = name,
    Advice = advice
  };

  return RedirectToAction("Person", person);
}
```

