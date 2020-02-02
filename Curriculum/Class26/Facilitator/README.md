# Class 26 Intro to Identity

## Overview
This is the kickoff to the ECommerce Project. There is quite a bit of setup that is
required for this second half. Review the prep section below to confirm you are ready
for Classes 26 - 45.
 
By the end of lecture, students should have seen:
1. Introduction to Azure Dev Ops
2. A complete workflow using Azure Dev Ops and Azure Repos
3. Integration of Identity into an existing project

## Preparation
Here is checklist of items that you should complete before the start of lecture: 
1. If you have chosen to utilize the Canvas Pages, follow the instructions in the [Canvas file](./Canvas.md)
2. Become familiar with Azure Dev Ops project management tool & the VS Team Explorer Extension
    - [Azure Dev Ops](https://dev.azure.com/)
    - [Team Explorer Reference](https://docs.microsoft.com/en-us/azure/devops/user-guide/work-team-explorer?view=azure-devops)
3. Refer to the [Cheat Sheet](/../ECom_Project/VSTS_CheatSheet.md) as steps on how to complete some of the basic 
    tasks within ADO. Walk through the creation of a repo and with some basic tasks. You will do these steps in lecture as well. 
4. Review the [Intro to Identity](./Identity.md) lecture.
   - [Intro to Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-2.2&tabs=visual-studio)
5. Be Comfortable with the demo code and all of the different moving components 

### Lecture
1. Introduce the ECom project by reviewing each week's expectations (30min)
   - Monday goals (to plan ahead)
   - Friday reflections (what did you complete that week? What would you do differently?)
   - Peer reviews at the end of each sprint
   - Show an example of Day 1's (and 2's if they need to see the "guidance" section) user stories and how they are split up
   - Everyone is responsible for their own submission (no "group" submissions)
   - Show the grading rubric for sprint 1

2. Introduce Azure Dev OPS project management tool & VS extension  (max 1 hour)
   - Use the cheat sheet from the prep section as steps on how to create and complete tasks within ADO.
   - Walk through the creation of a repo and cloning it down to your Visual Studio extension 
   - Create a basic scaffolded MVC app w/ a database in class following the Azure Dev Ops work flow
        - The demo is using User Secrets, so don't forget to include the User secrets file and Connection String file! 
        - Your initial demo should match the `ADO_Scaffold_Demo` located in the Demo Folder. 

3. [Intro to Identity](./Identity.md) (max 90 min)
   - Register Identity in Startup File
   - Create a new DBContext for Identity
   - Run migration scripts to show user tables. 
   - End Result of Demo: CMSDEMO in Demo folder

### LAB Prep
Have student pairs ready to be posted in Canvas. For lab, each group should be expected to:
- Create a Dev Ops account
  - Only one person needs to do this. Have them invite their partner.
- Think up a product to sell
  - It's an ECommerce store...what will they sell? Make sure it's an appropriate product and that they
  can "seed" in at least 10 products
- Scaffold out an MVC application with a SQL database (w/o Identity) and with a default home page
- Deploy the basic app to Azure (only on one of the accounts)

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
