![cf](http://i.imgur.com/7v5ASc8.png) Lab 11 : Intro To Controllers
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a directory named `lab-#`; + `<your name>` **e.g.** `lab10-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas

## Directions
You will be creating a web appliction for a student enrollment center. 

1. Using everything you've learned so far about controllers, MVC, and Core - build out:
   1. Start out with a new Empty web application
      1. Add appropriate NuGet packages
      1. Add proper Middleware and Services
      1. Set up the routing template <br />
      1. Set up Controller folder structure
      
**Create** <br />
*Note: Do NOT add a Controller class when adding controllers, only add a "Class"*
   1. Home Controller
   1. Students Controller
   1. Error Page Controller.
2. Home and Student Controller should have at least 2 actions each.
3. Error controller can only have 1 (at least)
4. Add Custon/Attribute routing to the Error page and one of the Student Actions.

### Contents of the Application
- The application needs to have a page to register students
- another page to view all students who have registered so far.
- One of the Student Actions should take in 2 parameters --> Output manipulated data to the browser (i.e. Name & Age, Name & Class Level, etc...  )
- Be sure to have a default controller set in the configuration.

*For now, just output text to the browser, we will build onto views on day 12*

**Note**: We are only practing using controllers in this lab assignment. 
there is no need to create views or models just yet. 

## ReadMe
- Your readme should include the following information:
	- How long did it take you to complete this assignment?
	- What did you struggle with? Why? How did you solve?
	- What did you learn during this assignment?
    - What resources did you utilize for this assingment?

## Rubric
- 2pts: Application runs without any errors
- 3pts: 2 Controllers and 3 Actions
- 1pt: Attribute Routing
- 1pt: Query Strings used to transfer information
- 1pts: Readme included with answers to questions
- 2pts: Student enrollment information persisted in external file