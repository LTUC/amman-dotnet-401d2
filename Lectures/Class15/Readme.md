# ![cf](http://i.imgur.com/7v5ASc8.png) Lecture 15 : 


### Adding Search through Genre
- Add a ViewModel to your project and name it "MovieGenreViewModel"

```csharp
using Microsoft.ASPNetCore.Mvc Rendering;
using System.Collection.Generic;

namespace ClassDemo.ViewModels
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;  
        public SelectList genres
        public string movieGenre {get; set;}
    }
}

```


1.*Add/Modify the Index Method in the Movies Controller*
```csharp

public async Task<IActionResult\> Index(string movieGenre, string searchString)
{
    IQueryable<string> genreQuery = from m in _context.Movie
                                    orderby m.genre
                                    select m.genre

    var movies = from m in _context.Movie   
                 select m;

    if(!String.IsNullOrEmpty(searchString))
    {
        movies = movies.Where(x =>  x.Title.Contains(searchString));
    }

    if(!String.IsNullOrEmpty(moviegenre))
    {
        movies = movies.Where(x => x.Genre == movieGenre);
    }

    var movieGenreVm = new MovieGenreViewModel();
    moveGenreVM.Genres = new SelectList(await genre.Distinct().ToListAsync());
    movieGenreVM.movies = await movies.ToListAsync();

    return View(movieGenreVM);
}

```

**The View should look like this for the index action:

```csharp

@model MvcMovie.Models.MovieGenreViewModel

@{
    ViewData["Title"] = "Index";
}

<h2>Index</h2>

<p>
    <a asp-action="Create">Create New</a>
</p>

<form asp-controller="Movies" asp-action="Index" method="get">
    <p>
        <select asp-for="movieGenre" asp-items="Model.genres">
            <option value="">All</option>
        </select>

        Title: <input type="text" name="SearchString">
        <input type="submit" value="Filter" />
    </p>
</form>

<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.movies[0].Title)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.movies[0].ReleaseDate)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.movies[0].Genre)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.movies[0].Price)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in Model.movies)
        {
            <tr>
                <td>
                    @Html.DisplayFor(modelItem => item.Title)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.ReleaseDate)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Genre)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Price)
                </td>
                <td>
                    <a asp-action="Edit" asp-route-id="@item.ID">Edit</a> |
                    <a asp-action="Details" asp-route-id="@item.ID">Details</a> |
                    <a asp-action="Delete" asp-route-id="@item.ID">Delete</a>
                </td>
            </tr>
        }
    </tbody>
</table>
```

After we add the Custom viewmodel - We should be able to sort through a Select List.

## Layouts & Partials

- Add a new layout "_basicLayout.cshtml" to the shared folder
- Point out the "_" - this means that they will not be user facing. 
- add custom css to the layout
- Say layout = null if you do not want it to link to a layout.(better practice to specify)
- Notice "@RenderBody" and what happens when you add a layout to a view

### Partials
- Partial views ae just regular CSHTML files, and it is their use that differentiates them from regular Razor views. Visual Studio provides some tooling support for creating prepopulated partial views, but the simplest way to create a partial view is to create a regular view using the MVC View Page item template.
- @Html.Partial("MyPartial") specified within a regular View

## Deploy to Azure
1. Send site and database up to azure