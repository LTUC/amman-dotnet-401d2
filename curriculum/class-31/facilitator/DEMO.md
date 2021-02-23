# Demos: Razor Pages

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Demo

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

