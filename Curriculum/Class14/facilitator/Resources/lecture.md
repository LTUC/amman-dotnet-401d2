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

Create additional controllers for the other models following the same process.


### Taghelpers
What are taghelpers? Why do we need them?

Review Taghelpers [Here](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro?view=aspnetcore-2.2)

Enable tag helpers in your view folder by adding a `_ViewImports.cshtml` file

```
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```

Review what tag helpers look like and how they are used in the "Edit" student view.

Look specifically at the `@model` coming in, and 
the input tags with the `asp-for` attribute.

### Data Annotations
1.[Review Data Annotations](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-2.2)

Show the user input from the "Create" page on the new Student controller.
Show that we want to make some of the fields "required".

Go to the model and add data annotations. Suggestions: Required, Display, Range, etc....

prove that they work by testing out the student intake form and see that the `Model.IsValid` comes back as false. 

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

We want the ability to take the enums we created and have them as drop down items. In our demo
we can do this in our "Courses" page. Either in our edit or our create (or both!)

In the `.cshtml` file...

```csharp
<label asp-for="Technology" class="control-label"></label>

<select asp-for="Technology" asp-items="@Html.GetEnumSelectList(typeof(SchoolDemo.Models.Technology))" class="form-control"></select>
```

OR

We can customize what is seen in the dropdown lists by modifying what the controller is sending to the view. 
Go to your `Enrollments` controller and modify the "Create" and "Edit" actions (both get and post)

You can map the arguments to specific properties. For example, for the student's name, you can make a new custom property
in students for "Full Name"

```csharp
public string FullName => $"{FirstName} {LastName}";
```

in the controller...
```csharp
ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name");
ViewData["StudentID"] = new SelectList(_context.Students, "ID", "FullName");
``` 

the .cshtml file:
```csharp
  <select asp-for="CourseID" class ="form-control" asp-items="ViewBag.CourseID"></select>
```


### Layouts
[Reference](https://docs.microsoft.com/en-us/aspnet/web-pages/overview/ui-layouts-and-themes/3-creating-a-consistent-look)

Create a master layout and attach it to all of the view pages. 
The `_Viewstart.cshtml` file is a good place to set these global settings.