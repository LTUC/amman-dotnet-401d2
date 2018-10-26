# Class 14: Seeding the Database

## How do I prep for today?
1. Review DbContext setup. 
2. Review Scaffolding of Controller
3. Go through the Create and Edit actions to see what is happening
	- point out what _context means

3. Introduce Data Annotations (required, Display Name, Enums, phone number, etc...)
4. Seed the Database
5. Run application and make adjustments with data extraction (DDL, db queries. )
4. How to turn an Enum into a DDL

```csharp

 <label asp-for="Layout" class="control-abel"></label>

 <select asp-for="Layout" asp-tems="@Html.GetEnumSelectList(typeofAsyncInn.Models.Layout))"></select>

```

OR

```csharp
  <select asp-for="CourseID" class ="form-control" asp-items="ViewBag.CourseID"></select>

```

```csharp
in the controller....
    ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", courseEnrollments.CourseID);
```

5. Shared Layouts
6. Taghelpers


## What changed from yesterday? 

## What might students struggle with today?  

## What bugs, issues, or surprises have come up in the past for this class?

## General comments