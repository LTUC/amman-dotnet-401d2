![cf](http://i.imgur.com/7v5ASc8.png) Lab 11 : Intro to Controllers
=====================================

### Setup
  1. Open up an Empty Core Web application.
  2. Go to NuGet package manager, browse and install Microsoft.AspNetCore.Mvc NuGet package
     - this will expose new middlware for our application, one of which is app.UseMvc();
     - This is used to map an HTTP request to a method in one of our Controllers. 
  3. Modify your code in the Configure() in your Startup.cs by adding `app.UseMvc()`
  4. Add `services.AddMvc()` to your `ConfigureServices()`   
     - You are registering your MVC services that the Mvc framework requires in order to function.
  5. Add a "Controllers" folder to your application
  6. Add a new class called "StudentController"
  7. Add a method in the class called `public string Find()`
     - return "found students"
  8. Add the following to the startup Class
        ```csharp
            app.UseMvc(route =>
            {
                route.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");

            });
        ```
  9. Save your program and Run. 

### Controller Defaults
1. When creating an empty web app in Core, you will automatically get a home page that says "Hello World"
    - This will run everytime it a controller isnt found. 
    - if you dont want this, just remove it.
    - This is through this section of code in the Startup Class:
    ```csharp
    app.Run(async (context) =>
    {
        await context.Response.WriteASync("Hello World!");
    });
    ```

2. If you want to set a default location modify your app.UseMvc():
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
2. Create an `ErrorController` class
3. add a `public string Support()` method that returns string "Error on page";
   - This will create the url /Error/Support url for us, but what if we don't wnat peole to know that our action is named "Support"?
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
4. Got to .../Error/Support and the error page will show


### Take it one step further...

1. So far we have a couple different controllers
   - Routing template set up
   - Default location
   - Custom student page
   - Error page with custom routing

2. We want a Controller to have what all/other controllers have:
   - Let's have these controllers inherit from the Controller class
   - Add ` : Controller` to the controller classes already created
     - When starting out with an empty application, you will need to manually add this. 


### Manipulate Data

1. Let's manipulate data from the browser in the controller.

2. "Actions" in Controllers can take paramters

Add this Code

  ```csharp
        public string Welcome(string name, int number)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Number is: {number}");
        }

   ```
#### How does it know?

- the MVC Model binding system automatically maps the named parameters from the query string in the address bar to parameters in your method. 

#### How Model Binding Works:
1. When MVC receives an HTTP request, it routes it to a specific action method of a controller.
2. It determines which action method to run based on what is in the route data, then binds it to the HTTP request to that action method's parameters.

3. Let's go back to the Route Template:
   - `{controller=Home}/{action=Index}/{id?}`

4. movies/edit/2 --> 
  - rotues to the Movies Controller
  - Edit is the Action
  - accepts an ID (of 2 in this case. )
  - It defaults to whatever is after the '/' to id, unless otherwise specified

**This is all you need to know about it for now, We will cover the other details of Model Binding later on**