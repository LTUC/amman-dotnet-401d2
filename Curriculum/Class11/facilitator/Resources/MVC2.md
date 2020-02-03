### Setup
1. Walk through creating empty MVC app
1. Add Middleware

### Controller Defaults
1. When creating an empty web app in Core, you will automatically get a home page that says "Hello World"
    - This will run every time it a controller isn't found. 
    - if you don't want this, just remove it.
    - This is through this section of code in the Startup Class:
    ```csharp
    app.Run(async (context) =>
    {
        await context.Response.WriteASync("Hello World!");
    });
    ```

1. If you want to set a default location modify your app.UseMvc():
    ```csharp
      app.UseMvc(route =>
            {
                route.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");

            });

     ```

### Routing
1. What if we want special Routing? 
1. Create an `ErrorController` class
1. add a `public string Support()` method that returns string "Error on page";
   - This will create the url /Error/Support url for us, but what if we don't want people to know that our action is named "Support"?
   - Change the name of the method to "Index" and add routing:
    ```csharp
        [Route("Error")]
        public class ErrorController
        {
            [Route("Support")]
            public string Index()
            {
                return "Content not found. Contact Support";
            }
        }
    ```
1. Got to .../Error/Support and the error page will show


### Manipulate Data

1. Let's manipulate data from the browser in the controller.

1. "Actions" in Controllers can take parameters

Add this Code

  ```csharp
        public string Welcome(string name, int number)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Number is: {number}");
        }

   ```
#### How does it know?

- The MVC Model binding system automatically maps the named parameters from the query string in the address bar to parameters in your method. 

#### How Model Binding Works:
1. When MVC receives an HTTP request, it routes it to a specific action method of a controller.
1. It determines which action method to run based on what is in the route data, then binds it to the HTTP request to that action method's parameters.

1. Let's go back to the Route Template:
   - `{controller=Home}/{action=Index}/{id?}`

1. movies/edit/2 --> 
  - routes to the Movies Controller
  - Edit is the Action
  - accepts an ID (of 2 in this case. )
  - It defaults to whatever is after the '/' to id, unless otherwise specified

**This is all you need to know about it for now, We will cover the other details of Model Binding later on**


## Views

### What are Views?

- Views encapsulate the presentation detail of the user's interaction,
- Views are HTML templates are embedded code that generate content to send to the client
- Views use Razor Syntax - this allows code to minimally interact with the HTML
- extension is .cshtml pages
- Layout structure:
  - Each "Controller" has it's own folder in the Views that holds the different Views. 
- Partial Views and Layouts can be used to avoid repetition of code for views throughout a site. 

### Creating Views

- Views that are specific to a Controller are created in 'Views/[Controller Name] folder. 
- Views that are shared amongst multiple controllers are in /Views/Shared folder.
- Name the View in association with the Controller action (i.e. To create an About view for hte Home Controller, create /Views/Home/About.cshtml)


### Razor Syntax:
- Razor Code is denoted by: `@` symbol. 
- c# code is run within Razor code blocks set up by `{}` curly braces.

### Controllers & Views
- Views are returned in Controllers from as actions through `ViewResult`. 
- You action method can create and return a `ViewResult` directly, but if your Controller inherits from `Controller`, you'll simply just use `View` helper method:

```csharp
return View();
```

1. In the above example, View Discovery is used to automatically find the matching view to the controller action.
1. The Views are search by the system in these locations first:
    - Views/<\ControllerName>/<\ViewName>.cshtml
    - Views/Shared/<\ViewName>.cshtml
1. You can explicitly tell it to go to another view by `return View("MyView") and it will look for a view named "MyView"
1. You can also explicitly tell it to look in a specific location `return View("Views/Home/About.cshtml")`
