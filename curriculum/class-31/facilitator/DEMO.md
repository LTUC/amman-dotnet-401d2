# Demos: Razor Pages

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Demo

1. Create a barebones MVC/Razor application
   1. Connect it to a database and create a DbContext
   1. Create a data model (Person/People) and seed some data
   1. Migrate/Update the database
   1. Create an Interface and Service to be used by a Controller or a Razor Page

> This should be a complete "review" for your students as this is the EF and MVC basics we've been building out each day

1. Modify the startup file to allow for "Razor Page Routing

   ```csharp
   // Above the MVC Mapping
   endpoints.MapRazorPages();
   ```

1. Create a new Razor Page
   - NOTES:
     - It automatically creates a `.cshtml.cs` file for you
     - Both automatically map a page model (live binding)
     - (There's not really a need for a "DTO" now)
     - The .cs carries both the business logic and routing
   - In the .cs file you can add a property and immediately see it on the page
   - `.cshtml` file
     - `@page` indicates that this is a razor page
       - Leave that alone!
   - `.cs` file methods
     - `OnGet()`
       - Handles GET Requests (Retrieves Information)
     - `OnPost()`
       - Handles POSTS (Creates Information)
       - No longer need `[HttpPost]` like we do in MVC

> Once you have a basic page created, take this time to showcase get, post, query params, form body, routing and linking with tag-helpers and so forth. This is a good time to experiment with the new system prior to hooking the models up to data.

1. Create additional pages, connected to your data service, using Dependency Injection
   - Account/Index (or, use the main index): List all people in the database
   - Accounts/Register: Add a person to the database
   - Accounts/Person: The details for a single person
