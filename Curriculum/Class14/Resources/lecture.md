# Class 14 Lecture:

## Overview

Hour 1:
1. Scaffold a Controller
2. Review the pre-created code.
3. Add data to the DB from a user form

Hour 2:
1. Data Annotations
2. Seed the database

Hour 3:
1. Turn an enum into a DDL
2. Layouts

### Scaffold a controller
This is going to teach the students how to read
and work with code that they didn't write. The point
of scaffolding out a controller is to show them the shortcut
to making CRUD operations within a web app. 

Go and create a new "Student" controller by scaffolding out the controller
1. Right click on the `Controllers` folder
2. select `Controller`
3. select `MVC Controllers with Views using Entity Framework`
4. Select the appropriate model, select the existing DBContext, and adjust the Controller Name as needed

Once the scaffold is finished, you will notice some additions to the code:
1. New folder in the "Views" folder for the name of the new controller
2. New razor views for each of the CRUD operations
3. code in the new controller for basic crud operations

Dissect the code with the class. Explain the `DbContext` that is being
injected in. Go over a few of the actions and discuss how items are being added/manipulated in the DB.

### Data Annotations
1.[Review Data Annotations](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-2.2)

Show the user input from the "Create" page on the new Student controller.
Show that we want to make some of the fields "required".

Go to the model and add data annotations. Suggestions: Required, Display, Range, etc....

prove that they work by testing out the student intake form and see that the `Model.IsValid` comes back as false. 

### Taghelpers
What are taghelpers? Why do we need them?

Review Taghelpers [Here](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro?view=aspnetcore-2.2)

Enable tag helpers in your view folder by adding a `_ViewImports.cshtml` file

```
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```

Review what tag helpers look like and how they are used in the "Edit" student view.

### Seeding the Database

[Seeding the DB](https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding)

```csharp
modelBuilder.Entity<Student>().HasData(
        new Student
        {
	        ID = 1,
	        FirstName = "Jack",
	        LastName = "Shepard",
	        Age = 36
        });
```

### Enums into DDL

In the `.cshtml` file...

```csharp
 <label asp-for="Layout" class="control-abel"></label>

 <select asp-for="Layout" asp-tems="@Html.GetEnumSelectList(typeofAsyncInn.Models.Layout))"></select>
```

OR

the .cshtml file:

```csharp
  <select asp-for="CourseID" class ="form-control" asp-items="ViewBag.CourseID"></select>
```

in the controller...
```csharp
    ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", CourseEnrollmetn.CourseID);
``` 

You can map the arguments to specific properties. For example, for the student's name, you can make a new custom property
in students for "Full Name"

```csharp
public string FullName => $"{FirstName} {LastName}";
```

### Layouts
[Reference](https://docs.microsoft.com/en-us/aspnet/web-pages/overview/ui-layouts-and-themes/3-creating-a-consistent-look)

