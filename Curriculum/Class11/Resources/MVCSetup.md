# Default MVC Application

Below are the directions to scaffold out a bare minimum MVC project for class 11. Each project you create will be different given the problem domain, but most of them should start with these steps to get started. 

### Set up MVC
1. File >> New Project
2. ASP.NET Core Web Application
3. Create a project name (Do not use dashes, only use underscores if needed)
4. Select Empty for the type of web application
5. Go to Startup.cs
6. In `ConfigureServices()` add the appropriate middleware `services.AddMVC()`
7. In `Configure()` add HTTP Pipeline route requirements

```
app.UseMvc(routes =>
{
	routes.MapRoute(
	name: "default",
	template: "{controller=Home}/{action=Index}/{id?}");
});
```

8. Add app.UseStaticFiles() under `Configure()` after mapping the route to allow the use of static files, such as css and js files.
9. Create a new folder in solution called "Controllers"
10. Create a new folder in solution called "Models"
11. Create a new folder in solution called "Views"
12. Create a new class named HomeController in the Controllers Folder
13. Derive HomeController from base class Controller (`HomeController:Controller`)
14. Import the appropriate namespace (`Microsoft.AspNetcore.MVC`)
15. Create new action in HomeController named "Index" with a return type of IActionResult
16. Make the return of the `Index()` action `return View()`
17. Create a new folder named "Home" in our Views Folder.
18. Create a new .cshtml page in the Home folder that you just created
	a. Right click on Home Folder
	b. Add -> New Item ->
	c. search for "View" 
	d. select "Razor View"
	e. Name the View the same page as your action (Keep it Index for this example)
19. Add Text to your Index.cshtml file
20. Run the app and make sure it loads your Home page.
21. If it runs -> YAAY!, if not troubleshoot steps 1-20.

### Next Steps

Your next steps are to add the appropriate additional routes and view pages given the problem domain of the lab.
