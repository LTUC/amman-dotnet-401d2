![cf](http://i.imgur.com/7v5ASc8.png) Lab 19: Create an API
=====================================

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)


## Application Specifications
- Your application should include the following:
1. 2 Controllers with CRUD endpoints (You may use an empty API controller template for this if you wish)
1. 2 Models (ToDo and ToDoList)
1. 2 database tables (one database table for each model)

We can make the assumption that a ToDo can **only be a part of one ToDoList**

The following actions must also be true:

1. when accessing the Get action on `\api\ToDo`, it should output all the individual ToDos
1. when accessing the Get action on `\api\ToDo\{id}`, it should output the details of the individual tToDo AND the ToDoList it is a part of.
1. when accessing the Get action on `\api\ToDoList`, it should output all the ToDoLists
1. when accessing the Get action on `\api\ToDoList\{id}`, it should output the individual ToDo list AND the individual tasks associated with it
1. If you choose to delete a ToDoList, it should delete the list AND all of the associated ToDos associated


## Guidance
- Starting from an **empty MVC template**, Create an API that allows a user to Create individual ToDo tasks, and put them in a ToDoList. 

- Using both of the resources below, create an API in .NET Core that conducts the standard HTTP verbs (Get,Put,Post,Delete) for a "To-Do" list.

- Your "To-Do" list will consist of individual tasks that can be saved into the database and extracted as needed. You should also have the ability to 
get all of the tasks by a simple get request. 
<br />

*Use Postman (in addition to unit tests) to test your endpoints.* 

**Use a sql database instead of an in-memory database that is referenced in the tutorial**

**Deploy your API to Azure, provide a published link in your README.**


## Unit Tests
- Test your application for the following functionality:
1. Create a ToDO item
2. Read a TODO Item
3. Update a ToDo item
4. Delete a ToDo Item
5. Create a List
6. Read a List
7. Update a List
8. Delete a list
9. Add Items to a List
10. Remove items from a list


## Stretch Goals
- There are no Stretch Goals for this assignment.


## Additional Resources
  1. Watch this video with Daniel Roth [Here](https://binged.it/2v2AXFe){:target="_blank"}  (~60 min)
  1. Read the tutorial located [Here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api){:target="_blank"} 



## README

**A README is a requirement. No README == No Grade.** <br /> 
Here are the requirements for a valid README: <br />


A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context, provide a summary)
2. show them what it looks like in action (Visuals)
3. show them how they use it (Step by step directions, "Happy Path" walk through)
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo `Resources` folder for an example. 
- [sample-README](https://github.com/noffle/art-of-readme){:target="_blank"}

## Rubric

The lab rubric can be found [HERE](../Resources/rubric){:target="_blank"} 

