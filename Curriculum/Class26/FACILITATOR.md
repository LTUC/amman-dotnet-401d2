   # Class 26 Intro to Identity

## Overview
This is the kickoff to the ECommerce Project. There is quite a bit of setup that is
required for this second half. Review the prep section below to confirm you are ready
for Classes 26 - 45.

## How do I prep for today?
Introduce the E-Commerce Project. If you have chosen to utulize the Canvas Pages, this is a good day
before lecture to turn on the "E-Commerce" Home landing page. 

The canvas landing home page usually consists of:
1. The intro to the project
2. A roadmap of each of the sprints and the assignments associated with them (only publish one sprint at a time)
3. Extra resources to have on hand during the course.  (example: Syllabus)
4. Partners for the project

To enable the new default home page, follow these directions:
1. Go to to your current "Home"
2. select the "Choose Home Page" button on the top right hand corner
3. Select "Pages Front Page" and make sure that the "Build an E-Commerce Store" is selected
4. Select Save
5. You can easily edit this page by selecting "Edit" located in the top right corner of the page.
6. You will need to also confirm that each of the assignments posted on this homepage are properly mapping
to the correct assignments. 
   - To link the assignments, highlight the text (example: "Sprint 1"), and select the "Assignmentes" box on the 
   - right hand side. Once you "select" the correct assignment, Canvas will link that to texgt to that assignment.

**For grading purposes, you should have the same TA/Grader for each person in a group.** You
may need to re-allocate grading groups so that the same TA/Grader is grading BOTH partners
for their project. Grading for each Sprint is explained in the Sprint 1 submission instructions.

### Lecture
1. Get familiar with Azure Dev OPS project management tool & VS extension  (max 1 hour)
   - Use this [Cheat Sheet](../ECom_Project/VSTS_CheatSheet.md) as steps on how to complete some of the basic tasks within ADO.
   - Walk through the creation of a repo and cloning it down to your Visual Studio extension 
   - Create a basic scaffolded MVC app w/ a database in class following the Azure Dev Ops work flow
        - The demo is using User Secrets, so don't forget to include the User secrets file and Connection String file! 
        - Your initial demo should match the `ADO_Scaffold_Demo` located in the Demo Folder. 
2. Introduce the ECom project by reviewing each week's expectations (30 min)
   - Monday goals (to plan ahead)
   - Friday reflections (what did you complete that week? What would you do differently?)
   - Peer reviews at the end of each sprint
   - Show an example of Day 1's (and 2's if they need to see the "guidance" section) user stories and how they are split up
   - Everyone is responsible for their own submission (no "group" submissions)

4. [Intro to Identity](./Resources/Identity.md) (max 90 min)
   - Register Identity in Startup File
   - Create a new DBContext for Identity
   - Run migration scripts to show user tables. 

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
