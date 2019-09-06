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
            return View(posts);
        }
    }
```


There are quite a few things going on in the View Component that we can talk about:

1. Much like a controller, we can tell that a class is a view component through it's base class `ViewComponent`. 
This will allow us to use the other methods and behaviors available to us that View Component would traditionally have. 
2. View Components support dependency injection. Regardless what we are injecting (in this case, our post service), we can 
utulize DI within our within our VC.
3. Our View Component requires that we have an action named "Invoke" or "InvokeAsync". This is what we will call on our 
View Pages to activate the View Component. 
4. Our return for our Invoke is similar to what we have with a Controller. We return a `View` directly and then send to the view
the direct data that we want to display. 
5. The logic within the `InvokeAsync` method is doing something different we haven't seen before.
It is getting the full dataset from the posts table, ordering it by descending (a form of sort), taking the top posts equivelant to
the number provided.  It is then taking those posts and sending it to the view. 

The View structure for a View Component is similar to the one of a controller.  Here is where we make the `.cshtml` file:
  1. Go to the Views folder
  2. Go to the Shared folder
  3. Create a new folder named `Components`
  4. Create a new folder that matches the name of the VC (TopPosts)
  5. Create a new `.cshtml` file named "Default". Default is what we lok for as our default view component page
  6. Much like regular controller views, we can create other view files, we just have to specify the name of the file directly (View("NAMEOFVIEW",data))
 
The `Default.cshtml` file should look like this:

```csharp

@model IEnumerable<CMSDemo.Models.Post>
    <!DOCTYPE html>

    <html>
    <head>
        <meta name="viewport" content="width=device-width" />
        <title>Default</title>
    </head>
    <body>
        Hello! This is my View Component.
        @foreach(var post in Model)
        {
            <h2>@post.Title</h2>
            <p>@post.Content</p>
        }
    </body>
</html>
```


To attach a View component to a page, go to the page that you want the VC to appear (for example, our home page) and add
the following code to invoke the VC:

```csharp
 @await Component.InvokeAsync("TopPosts", 3);
```

The above:
1. await is required since we are making an external call to the VC.
2. Invoke the component off the of `Component` class
3. Specify the name of the VC in the first arguement
4. send your arguement as the second argument. 

Run your app, and assuming you have data seeded in your database, you should see the View Components displayed!






