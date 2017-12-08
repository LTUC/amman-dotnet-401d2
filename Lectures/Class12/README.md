# ![cf](http://i.imgur.com/7v5ASc8.png) Lab 12 : Intro to Views


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
- Name the View in association with the Controller aciton (i.e. To create an About view for hte Home Controller, create /Views/Home/About.cshtml)


### Razor Syntax:
- Razor Code is donoted by: `@` symbol. 
- c# code is run within Razor code blocks set up by `{}` curly braces.

### Controllers & Views
- Views are returned in Controllers from as actions through `ViewResult`. 
- You action method can create and return a `ViewResult` direclty, but if your Controller inherits from `Controller`, you'll simply just use `View` helper method:

```csharp
return View();
```

1. In the above example, View Discovery is used to automatically find the matching view to the controller action.
2. The Views are search by the system in these locations first:
    - Views/<\ControllerName>/<\ViewName>.cshtml
    - Views/Shared/<\ViewName>.cshtml
3. You can explicitily tell it to go to another view by `return View("MyView") and it will look for a view named "MyView"
4. You can also explicity tell it to look in a specific location `return View("Views/Home/About.cshtml")`

### Passing Data to Views

1. The best way to pass data to your views is through a *model* type in the view (often referred to as a View Model).
	- An instance of this model type is then passed to the view from the action
	- Advantages of passing it through a view or view model is so that view can take advantage of the strong type checking. 
	- you specify a model for a view using the `@model` directive

	```csharp
	@model WebApplication1.ViewModels.Address
   <h2>Contact</h2>
   <address>
       @Model.Street<br />
       @Model.City, @Model.State @Model.PostalCode<br />
       <abbr title="Phone">P:</abbr>
       425.555.0100
   </address>
	```


	```csharp
		public IActionResult Contact()
	   {
		   ViewData["Message"] = "Your contact page.";

		   var viewModel = new Address()
		   {
			   Name = "Microsoft",
			   Street = "One Microsoft Way",
			   City = "Redmond",
			   State = "WA",
			   PostalCode = "98052-6399"
		   };
		   return View(viewModel);
	   }
	```


#### View Models
	1. Add a New folder - Name it ViewModels
	2. Add a new Class and put the name of the properties you want the ViewModel to contain in it.
	3. In your Controller, create a new viewmodel object
	4. set the values and pass that viewmodel to the View.

#### ViewData & ViewBag
	1. `ViewData` - dictionary object accessed through string keys
		- you can store and retrieve objects in it. If you need it other than a string you have to explicitly cast them. 
		- you can use `ViewData` to pass data from a controller to the views as well within views (partials or layouts)
	2. `ViewBag` - Provides dynamic access to the to the onjects stored in `ViewData`. 
		- Easier to work with since it doesn't require casting. 

		```csharp
		@ViewBag.Greeting World!

	   <address>
		   @ViewBag.Address.Name<br />
		   @ViewBag.Address.Street<br />
		   @ViewBag.Address.City, @ViewBag.Address.State @ViewBag.Address.PostalCode
	   </address>

		```


#### Dynamic Views
	1. Views that do not declare a model type but have a model instance passed to them can be referenced this instance dynamically/
	2. Example: An action passes an instance of Address, but the view doesn't declare @model, the view can still show:
		```csharp
			<address>
				@Model.Street<br />
				@Model.City, @Model.State @Model.PostalCode<br />
				<abbr title="Phone">P:</abbr>
				425.555.0100
			</address>
		``
	3. Disadvantes: No intellisense or compilation protection.


```csharp
<form method="post" action="/Home/Create">
    <div class="form-group">
        <label for="Name">Name:</label>
        <input class="form-control" name="Name" />
    </div>
    <div class="form-group">
        <label for="Country">Country:</label>
        <input class="form-control" name="Country" />
    </div>
    <div class="form-group">
        <label for="Population">Population:</label>
        <input class="form-control" name="Population" />
    </div>

    <button type="submit" bs-button-color="danger">Add</button>              
    <a class="btn btn-primary" href="/Home/Index">Cancel</a>
</form>

```
	
### **Demo**
	1. Add a Views Folder
	2. Add Home Folder in Views
	3. Add Action.cshtml to match action in HomeController
	4. Add html to the page
	5. Modify Action Controller to a return type "IActionResult"
	6. Return `View()`. 
	**Result -> View of the action gets returned**


#### Add a View Model
	1. Create a New folder named View Model
	2. Add a new class (Student)
	3. add properties to class
	4. instantiate the View Model Class in the Controller Action
	5. Return View(viewModel) (<- instanitated class object goes in ())
	6. In ViewPage, add `@Model.NAMEOFAPP.ViewModels.NAMEOFCLASS`
	7. Add `@Model.NAMEOFPROPERTY` to see the value be passed

#### ViewData
	1. Go to Controller Action
	2. Add `ViewData["MyStudent"] = new Student(){SET PROPERTIES HERE}` to the top of the Controller Action
	3. return View()
	4. Go to the View
	5. Add `@{ var student = ViewData["MyStudent"] as Student; }`
	6. add @student.Name (or any other Property you have) to the View.

#### ViewBag
	1. Modify (if you want) to remove the cast. ViewData and ViewBag can be used interchangibly
	2. Add @ViewBag.Student.Name or @ViewBag.Student.Age to show that it can also be outputted. 


#### Dynamic Views
	 1. Comment out the @model reference at the top
	 2. Pass the student from the controller into the view
	 3. target the student info by having @Model.Student.Name.
	 4. Disadvantages of this...

#### Sending A List</ Student>()
	1. In Controller Action, create a list of the Student Class
	2. Add a few students
	3. Return View(MyStudents.ToList())
	4. Go to View -> Modify declarative statement at top to this: `@model IList<ControllersAndRouting.ViewModels.Student>`
	5. Foreach loop can now be used to power through the list of students `@foreach(var s in Model)`

