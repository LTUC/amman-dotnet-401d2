# ![cf](http://i.imgur.com/7v5ASc8.png) Lecture 14 : EF Core, Migrations

## Review
1. What is a controller
2. What is a View
3. What is a Model

## What is Entity Framework Core?
1. Entity Framework Core is a lightweight extensible, and cross platform version fo the popular Entity Framework data access technology
2. EF Core is an object-relational mapper(O/RM) that enables .NET developers to work with a database using .NET objects.
3. It eliminates the need for most of the data-access code that developers usually need to writ.
4. EF Core supports many database engines.

## Refactor our Code
1. Let's change the "Date" field in our Model to be a bit more user friendly. 

```csharp
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
```

1. Right click oln squiggly lkine > Actions & Refactoring
2. Using `System.ComponentModel.DataAnnotations`
3. Remove the usings we don't need/aren't using

### [BIND] Attribute
1. one way to protect against over-posting. 
2. Only include items in the BIND that you want to change. 
3. View Models are an alternative way to protect against over-posting

### HTTPGET & HTTPPOST
1. The HttpPost attribute specifies that this Edit method can be invoked only for POST requests. 
2. You could apply the [HttpGet] attribute to the first edit method, but that's not necessary because [HttpGet] is the default.


### Adding Search
1. Modify your Index Method of your controller

```csharp
      public IActionResult Index(string id)
        {
            var movies = from m in _context.Movie
                           select m;

            if (!String.IsNullOrEmpty(id))
            {
                movies = movies.Where(s => s.Name.Contains(id));
            }
            return View(movies);
        }
```

1. This adds search functionality with "?Id=Ghost" query append. 

1. Add TagHelper to Index View

```csharp
<form asp-controller="Movies" asp-action="Index" method="get">
    <p>
        Title: <input type="text" name="SearchString">
        <input type="submit" value="Filter" />
    </p>
</form>

```

### Adding new field // Updating Migration
1. Add a new field to the Movies Model
2. Updte the [BIND] n the create and edit actions
3. Add new field in the index.cshtml page in the table
4. Add a new form group with the new field in the create.cshtml page

If you try and visit the Movies page, it will SQL error because of the new field.

#### There are a few approaches to resolving the error:
- Have the Entity Framework automatically drop and re-create the database based on the new model class schema. This approach is very convenient early in the development cycle when you are doing active development on a test database; it allows you to quickly evolve the model and database schema together. The downside, though, is that you lose existing data in the database — so you don't want to use this approach on a production database! Using an initializer to automatically seed a database with test data is often a productive way to develop an application.
- Explicitly modify the schema of the existing database so that it matches the model classes. The advantage of this approach is that you keep your data. You can make this change either manually or by creating a database change script.
- Use Code First Migrations to update the database schema.

### Update the Migration
1. open up the Package Manager Console
2. run this command:

```csharp
Add-Migration Rating
Update-Database
```

### Add Validation
1. Let's add validation to the Movies
1. The `ModelState.IsValid` is what does the validation
3. 
```csharp
public class Movie
{
    public int ID { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    [Required]
    [StringLength(30)]
    public string Genre { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    [StringLength(5)]
    [Required]
    public string Rating { get; set; }
}

```