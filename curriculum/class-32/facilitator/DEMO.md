# Demos: View Components

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Demo

We will use a View Component to add some dynamic content to the header of a site (the user's name) as well as to toggle the view mode from light to dark.

While view components can be data-backed by SQL or Identity ... in today's demo, we're simply going to use cookies. Focus your demo on the wiring and the use cases vs "yet another" database wiring demo. Our intent in this demo is to show the students why they should use components and some basic wiring to inspire them.

1. Scaffold out a basic, empty Razor Pages application
   - Startup.cs
     ```csharp
     // ConfigureServices...
     services.AddRazorPages()
     ....

     // Configure
     endpoints.MapRazorPages();
     ```
  - Create This Directory Structure:
    ```
    /Pages
      /Index.cshtml
      /Index.cs
      /Settings
        /Index.cshtml
        /Index.cs
    ```
1. Add "Layout" to your application so that we can do some basic styling, and have access to the _Layout.cshtml where we will add components to the header
1. Edit the layout, adding links to `/` and `/settings` to the header so that we can navigate eaier
1. In the `/Index.cshtml`, simply add some "Hello World" style text

### Save Settings to Cookies

1. In `Settings/Index.cshtml`, create a form bound to a model in `Settings/Index.cshtml.cs`
1. In `Settings/Index.cshtml.cs`
   - Create a View Model to store Username and DisplayMode
   - `OnGet()`
     - Read the Username and DisplayMode from cookies
     - Create an instance of the view model so the view will render properly
   - `OnPost()`
     - Take the contents of the Form Post and save them to cookies
1. While you can show these values in the Settings view, what we really want to do is to use these values in the header

### Make a view component

1. Create a folder called `Components` at the root, and add this file:
   - `LoggedInUser.cs`
   - In this file, wire up the `InvokeAsync()` method:
     - Read in the user cookie
     - Create a view model instance
     - Render the view
   - **NOTES**
     1. View Components support dependency injection.
     1. Our View Component requires that we have an action named "Invoke" or "InvokeAsync".
        - This is what we will call on our View Pages to activate the View Component.
     1. Our return for our Invoke is similar to what we have with a Controller.
        - We return a `View` directly and then send to the view the direct data that we want to display.

### Wire the view component into the header

1. Open the `Pages/_Layout.cshtml` file and add the following to the header:
   1. @await Component.InvokeAsync("LoggedInUser")
   1. <vc:logged-in-user></vc:logged-in-user>
1. Note that only the first one will work. The second, a custom tag helper needs to be wired into the `_ViewImports.cshtml` file, by adding a line
   - `@addTagHelper *, ComponentsDemo` (change the 2nd param to your namespace)

#### Now, you should see the welcome message in the header on all pages
