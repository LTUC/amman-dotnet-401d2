# MVC

### Three Take-a-ways


1. MVC is an architectural pattern used in web applications. 
2. MVC is extremely helpful when it comes to separation of concerns. 
3. This allows us to make changes to the front-end (view) without 
affecting the business logic or the routes. 

### Model
The model holds the business logic. This is where
we will create new classes and "models" for any objects
we wish to use within our web application

### View
This is our front-end. HTML and CSS is displayed on 
the views. In addition, on the View, we reference the "Model"
that was sent to the view from the controller. 

A really cool feature in Views is that we can display the information
from the model on the .cshtml page by using very basic C# syntax.
This "Razor Syntax" allows us to use foreach loops and if statements
to manipulate how to display the information sent from the controller. 


### Controller
The controller is the routing part of MVC. A controller contains
Actions, that maps to specific views. Each unique action is it's own 
view page. 

## Demo

### Empty Site

### Program Class
The program class should look familiar with what you have seen in the older Console application. 
If you take a look in this class, you will see the familiar `Main()` method. Indirectly, this main method is calling the 
startup class to get the program running with all the proper middleware and requirements. 
You will make very little changes to the Program.cs class. 

### Startup Class
The startup class is where you will be putting in a majority of your changes and configuration in code. The startup class consists 
of where we register any required middleware of dependencies that required for our application to run the way we expect.
, in addition to changes or settings to the HTTP pipeline. 

Get comfortable with the startup class, because you will be spending a lot of time in here. 

#### Middleware

Start the demo out by adding `.AddMVC`to the Configure() method. This will add the MVC dependencies to the application. 
Talk about how the alternative to this is to go into NuGet directly and find MVC and install the dependency from there. 

#### HTTP Pipeline
Within the http Pipeline we also have to tell the pipeline to expect the MVC model. what this means is we 
want to make sure that it knows it's looking for a "controller" (versus looking for a /page for Razor Pages). We do this by
addin the `.AddMVC` to the  ConfigureServices() method. 

In addition to actually letting the HTTP pipeline know about MVC, we also need to tell it what our default template will be. For example,
we have to tell it what is the default location to look for if no page, other than the root domain, is specified. 

we do this by adding a "Route Map". to the ConfigureServices. Set your Default route template to be a Home controller with an 'index' action.
and a nullable id. 

Make sure you break down each step of the template and confirm that the students understand why the template is there. 
They will be required to write out the template by hand for every lab assignment the first half and midterm. After the midterm, they
can use the pre-created default template if they wish. 

### Controller
Now that they have the default template created in the Startup class, this is a great segway into creating an actual controller. 
Start out the demo by walking through how to create a controller. 
1. Start by creating a class
2. Make the class inherit from `Controller`
3. Talk about how "methods" in controllers are called "Actions"
2. Create a nwe action, with the return type of string
5. return a string from the method. 
6. Go to the appropraite page on the site and see the string outputted

Pretty cool huh? 

Now play with the query strings in the url. Go back to your action and require that the action take in a string or an int. 
go to the url, and append to it the proper parameters and values using the url query syntax. Make the action within the controller
relay back out to the user the values they put in. 

Now show them what it looks like when you append a url, they should be able to see the values that are being brough in. 

This is called "Model Binding." the model is able to see the values it is supposed to accept, and then associates them to the correct paramters
from the query, assuming the names are exactly the same. 

It is important for the students to know that Controller are in charge of the routing. I like to put in the analogy of the "Traffic Cop".
They tell any requests coming in exactly where they need to go (which controller). 

### View
Now that we know how to output data back to the user, let's add a view into our 3 part cycle.
AS you can see, a View is not required to output data to our user, because we were able to do just that with just strings. 
But what if we want to give the user more than just a string? How about a list of strings, or objects, or misc data that
needs to be viewed? This is where views come in. We have the ability to not only output complex data to the user, but also 
style and design it with HTML, CSS, and JavaScript. 

Before we can get to designing our view page, we have to do some small changes to our controller action to allow the view page
to render. First, we need to change the return type, we are no longer returning a string to the user, but a View. Within the base
`Controller` class, we do this by making the return type "View Result"


### Model