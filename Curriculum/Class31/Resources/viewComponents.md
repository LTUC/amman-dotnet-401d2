# View Components

The documenation for View Components is actually pretty good. You should read the documentation in it's
entirety before the lecture to get familiar with the content: [Documenation Here](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-2.1)

View Components are super useful and are utulized for many different reasons in asp.net core sites. 

Some use cases for View Compnents:
1. Login Panels
2. Mini Baskets
3. Sidebars

Essentially, if there is a section of the page that requires rendering and logic manipulation, then a VC is a good choice. 
View Components can process logic and make calls to a database, external APIs, or really just be viewed as a "mini controller" 

We will use a View Component to create a panel on our homepage of the last 3 articles created. To do that, start by
creating a new folder in your project called "Components".

Within this folder, create a new class file named `TopPosts.cs`

The contents of this file will be:

```csharp
    public class TopPosts : ViewComponent
    {
        private BlogDbContext _context;

        public TopPosts(BlogDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var posts = await _context.Posts.OrderByDescending(x => x.ID)
                                      .Take(number)
                                      .ToListAsync();
            return View(posts);
        }
    }
```


There are quite a few things going on in the View Component that we can talk about:

1. Much like a controller, we can tell that a class is a view component through it's base class `ViewComponent`. This will allow us to use
the other methods and behaviors available to us that View Component would traditionally have. 
2. View Components support dependency injection. Regardless what we are injecting (in this case, our DBContext), we can utulize DI within our
within our VC.
3. Our View Component requires that we have an action named "Invoke" or "InvokeAsync". This is what we will call on our View Pages to activate
the View Component. 
4. Our return for our Invoke is similar to what we have with a Controller. We return a view.

The View structure for a View Component is similar to the one of a controller. 