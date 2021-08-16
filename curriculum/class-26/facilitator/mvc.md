# MVC

## Three Take-a-ways

1. MVC is an architectural pattern used in web applications.
1. MVC is extremely helpful when it comes to separation of concerns.
1. This allows us to make changes to the front-end (view) without
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
