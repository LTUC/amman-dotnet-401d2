# Demos: MVC Forms

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Forms Demo

### Scaffold out a basic, empty MVC application

1. Create a HomeController and Index View
1. Add Tag Helpers (we'll need this for partials later)
   - Add a new item - "Add ... Razor View Imports"
     - Add this to _ViewImports.cshtml
       - `@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers`

Now, we should be up and running with a basic application

### Add a "Dogs" model

We'll be doing some really basic CRUD Operations on this model

Ref: `Models/Dog.cs`

```csharp
public class Dog
{
  [Required]
  public string Name { get; set; }
  [Required]
  public string Breed { get; set; }
  [Required]
  public string Owner { get; set; }
}
```

### "Create" a Dog

In the Controller, we'll add a new action called `Add` which will render a basic View:

```csharp
[HttpGet]
public IActionResult Add()
{
  return View();
}
```

In the view itself (`Add.cshtml`), simply add a form, bound to the model. Notice that we're specifying a POST to the 'Add' action. We will be using an overload in the controller to handle this. Once for GET and one for POST

```html
@model FormsDemo.Models.Dog
<form asp-controller="Dog" asp-action="Add" method="post">
  <div>
    Name:<input asp-for="@Model.Name" />
  </div>

  <div>
    Breed:<input asp-for="@Model.Breed" />
  </div>

  <div>
    Owner:<input asp-for="@Model.Owner" />
  </div>
</form>
```

Here's our POST Method ... if the submission was good, then we'll simply return a happy message. If not, we'll redraw the form, with the entry re-sent, so the form will appear to simply re-draw itself.

Notice how the **POST** and **GET** action handlers both can render the same view ... use this to your advantage!

```csharp
[HttpPost]
public IActionResult Add(Dog dog)
{
  if (!ModelState.IsValid) { return View(dog); }
  return Content("Dog Added");
}
```

#### Show errors ...

Because we're using a model with some basic error checking, we can use a special renderer to show any errors that came up. Add this after your form in the Add View:

```html
<div asp-validation-summary="All"></div>
```

This will render any validation errors for you, with the text-danger class applied

### Update an existing Dog

Repeat the above steps for Update. The only real difference is that the form Action will need to POST to `Update` instead of `Add`

> Why? Aren't these the same? In theory, yes the form fields are the same. But in reality, the "Update" is going to be changing an existing record in the database, so it's going to need an ID, and will most likely call a different method in the Service that gets written to talk to the DbContext.  For this reason, let's keep them separate.

### Partials

Once you have the same basic workflow for both Add and Update, we can call out the obvious similarities between these 2. Let's make a partial that will pull in the similar parts, so that both of the view look like this:

Add.cshtml  (Edit.chtml will be the same except for the action):

```html
@model FormsDemo.Models.Dog

<h1>Add Dog</h1>

<form asp-controller="Dog" asp-action="Add" method="post">
  <partial name="_Form" />
</form>
```

... And the _Form.cshtml partial now has the common parts, with the model being  bindable.

```html
@model FormsDemo.Models.Dog

<div>
  Name: @Html.TextBoxFor(m => m.Name)
</div>
<div>
  Breed: @Html.TextBoxFor(m => m.Breed)
</div>

<div>
  Owner: @Html.TextBoxFor(m => m.Owner)
</div>

<input type="submit" value="Add Dog" />

@Html.ValidationSummary(false, "", new { @class = "text-danger" })
```

## Stage 2: Connecting to the Database and performing CRUD Operations

- Install Entity Framework
- Create a DogsService
- Wire up a DbContext and setup the Dependency Injection in the Startup

Once you have the wiring complete (that should be build socratically by the students, as it's all review from modules 3 & 4), call the service methods from the controllers as you add data to the forms.

In the controller method, we'll be calling methods in the PetsService now to do database operations
