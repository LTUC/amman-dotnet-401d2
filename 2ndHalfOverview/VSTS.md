# Visual Studio Team Services

## Setup
Have one person from each group create a new project.

Invite the following:
1. Assiged TA
2. Partner
3. Instructor

## Workflow
1. Create a Project

1. Create a User Story/Work item
   - Go to Work Items
   - select "Add Work Item" and select "Product Backlog Item"
   - Fill out the title with the name of the user story (I, as a ..., want to ..., so that...)
   - Select the iteration you are assigning this task too
   - Fill out the description
   - Add Acceptance criteria (min 2, max 3)
   - Add your "effort" (how much time will this user story take?)
   - SAVE your Story

1. Add Tasks to a User story
    - Under "Related Work" select "Add Link"
    - select "New item"
    - Link Type: Child
    - Work item type: Task
    - Title: Name of your taks (i.e. create Register Action)
    - Select OK
    - Fill out the description with more information about the task
    - Select the appropriate Activity (Development, documentation, Design, testing etc... )
    - Set your priority
    - Set your remaining work
    - Save and close
    - Follow the above steps for each task required for the user story

1. If you and your partner are ok with the user story created, go to the "boards" view and drag/drop the user story to "Approved"


4. Assign a user story to a developer
    - You can either assign a whole user story to a developer
    - OR you can assign the main user story to a developre and the individual tasks to different developers

5. Under each sprint, move the tasks for each user story from "todo" to "in progress" to "done" appropriately.

5. When you are ready to start working on a User Story
   - Open up the user story that you want to start working on...
   - Select a specific task you are going to work on first
   - in the top right hand corner of the popup you will see an elipses (...) 
   -  Upon selection choose the option that says "New Branch"
   - Name your new branch in the following format `UserStory:##-ShortNameOfFeature`
   - link the Branch to the task you are building
   - Select create Branch
   
6. Go to your Visual Studio Code base and be sure to Sync your changes first
    - Go to your branches >> Manage Branches
    - See your newly created branch
    - select your branch and do your development
    - Commit often
 
7. Upon completion, Push your code up to VSTS
    - Go back to VSTS
    - Select "Code"
    - You will see a notification at the top that says "yuou updated {BranchName} just now -- create a pull request"
    - select the Pull Request link in that message
    - Fill out the required details of the PR
    - Select Create
    - Assign  your partner as a reviewer (they should get an email)
 

1. Reiew and approve a pull request
    - When reviewing a PR, Review the code, make notes as needed, and complete/approve as necceasry
    - Select the approriate action from the approve menu
    - Complete once approved (Blue Button top right corner)
    - complete the merge (make sure the top 2 boxes are checked)
    - Wait for merge to complete
    - Your old branch will delete and confirm that your code has the changes
 
1. Completing a task
   - When you complete a PR for a task, that completes the task
   - Go back to the task, and in the discussion, say how long it actually took you (in comparison to the remainig work that you estimated)

1. Go to the Sprints view - and move the task to "Done"

1. Push to GitHub (final step of project)