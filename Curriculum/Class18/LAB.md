![cf](http://i.imgur.com/7v5ASc8.png) Lab 18: Finish up!
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
- Include a `README.md` (contents described below)

## Directions

Starting from an **empty MVC template**, Create an API that allows a user to Create individual ToDo tasks, and put them in a ToDoList. <br /><br/>

1. Watch this video with Daniel Roth [Here](https://binged.it/2v2AXFe){:target="_blank"}  (~60 min)
1. Read the tutorial located [Here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api){:target="_blank"} 

Using both of the resources above, create an API in .NET Core that conducts the standard HTTP verbs (Get,Put,Post,Delete) for a "To-Do" list.

Your "To-Do" list will consist of individual tasks that can be saved into the database and extracted as needed. You should also have the ability to 
get all of the tasks by a simple get request. 
<br />

*Use Postman (in addition to unit tests) to test your endpoints.* 

**Use a sql database instead of an in-memory database that is referenced in the tutorial**

**Deploy your API to Azure, provide a published link in your readme.**

### Application Components
You application should contain the following *at minimum*:
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

### Tests

Test the following functionality:
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

## README

**A Readme is a requirement. No Readme == No Grade.** <br /> 
Here are the requirements for a valid readme: <br />

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
- [Reference](https://github.com/noffle/art-of-readme) {:target="_blank"} 

## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements descibed above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |


