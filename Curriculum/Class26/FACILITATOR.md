# Class 26 Intro to Identity

## How do I prep for today?
Introduce the E-Commerce Project. If you have chosen to utulize the Canvas Pages, this is a good day
before lecture to turn on the "E-Commerce" Home landing page. 

The canvas landing home page usually consists of:
1. The intro to the project
2. A roadmap of each of the sprints and the assignments associated with them (only publish one sprint at a time)
3. Extra resources to have on hand during the course. 
4. Partners

Lecture will consist of:
1. Get familiar with Azure Dev OPS project management tool & VS extension 
   - [Cheat Sheet](../ECom_Project/VSTS_CheatSheet.md)
   - Walk through the creation of a repo and cloning it down to your Visual Studio extension 
   - Create a basic scaffolded MVC app w/ a database in class following the Azure Dev Ops work flow
        - The demo is using User Secrets, so don't forget to include the User secrets file and Connection String file! 
2. Introduce the ECom project by reviewing each week's expectations
   - Monday goals (to plan ahead)
   - Friday reflections (what did you complete that week? What would you do differently?)
   - Peer reviews at the end of each sprint
   - Show an example of Day 1's user stories and how they are split up
   - Everyone is responsible for their own submission (no "group" submissions)
3. Have student pairs ready to be posted in the class. Each group should:
	- Create a Dev Ops account
	- Think up a product to sell
	- Scaffold out an MVC application with a SQL database (w/o Identity)
	- Deploy the basic app to Azure (only on one of the accounts)

4. [Intro to Identity](./Resources/Identity.md)
   - Register Identity in Startup File
   - Create a new DBContext for Identity
   - Run migration scripts to show user tables. 

## What changed from yesterday? 
New Topic. Just coming off of Project week. Students should be refreshed and ready to start the second half.

## What might students struggle with today? 
Documentation. It is not always clear. This is usually because of updates to the .NET Core SDK. the docs for identity have specifically changed since 1.1. There is a lot of documentation out there that 
is outdated. There are some great docs out there, and many of them are shared through-out these facilitators guide.

Really encourage the students to troubleshoot and use what knowledge and information they have about the framework to solve any problems/issues they have. This
may include piecing bits and pieces from external documentation to come up with a solid solution. 

## What bugs, issues, or surprises have come up in the past for this class?
- Identity can sometimes be challenging to research. Documentation has gotten better over time, but this is not always
guaranteed. 

## General comments
This is a multi-week project broken up into 3 sprints. This is focusing mostly on half process and half code. At the end of every week, they will have a sprint due. After 3 sprints, the project is completed. 
