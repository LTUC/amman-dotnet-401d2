# ![cf](http://i.imgur.com/7v5ASc8.png) Lecture 15 : 


## Layouts & Partials

- Add a new layout "_basicLayout.cshtml" to the shared folder
- Point out the "_" - this means that they will not be user facing. 
- add custom css to the layout
- Say layout = null if you do not want it to link to a layout.(better practice to specify)
- Notice "@RenderBody" and what happens when you add a layout to a view

### Partials
- Partial views ae just regular CSHTML files, and it is their use that differentiates them from regular Razor views. Visual Studio provides some tooling support for creating prepopulated partial views, but the simplest way to create a partial view is to create a regular view using the MVC View Page item template.
- @Html.Partial("MyPartial") specified within a regular View

## Deploy to Azure
1. Send site and database up to azure