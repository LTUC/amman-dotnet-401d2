# VSTS CheatSheep

The documentation on how to work with VSTS is located [HERE](https://docs.microsoft.com/en-us/vsts/git/share-your-code-in-git-vs-2017?view=vsts){:target="_blank"} 

The expectation is that you will get comfortable with VSTS and use this documenation as reference for questions you may have.


### Create a User Story/Work item
   - Go to Work Items
   - select "Add Work Item" and select "Product Backlog Item"
   - Fill out the title with the name of the user story (I, as a ..., want to ..., so that...)
   - Select the iteration you are assigning this task too
   - Fill out the description
   - Add Acceptance criteria (min 2, max 3)
   - Add your "effort" (how much time will this user story take?)
   - SAVE your Story

### Add Tasks to a User story
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

### Approval

1. If you and your partner are ok with the user story created, go to the "boards" view and drag/drop the user story to "Approved"


### Assign a user story to a developer
   - You can either assign a whole user story to a developer
   - OR you can assign the main user story to a developre and the individual tasks to different developers

### Kanban
 Under each sprint, move the tasks for each user story from "todo" to "in progress" to "done" appropriately.

### Branching a user story
When you are ready to start working on a User Story
  - Open up the user story that you want to start working on...
  - Select a specific task you are going to work on first
  - in the top right hand corner of the popup you will see an elipses (...) 
  -  Upon selection choose the option that says "New Branch"
  - Name your new branch in the following format `UserStory:##-ShortNameOfFeature`
  - link the Branch to the task you are building
  - Select create Branch
   

### Work on your User Story
Go to your Visual Studio local code base and be sure to sync your changes first
   - Go to your branches >> Manage Branches
   - See your newly created branch
   - select your branch and do your development
   - Commit often
 
### Submit a PR
Upon completion, Push your code up to VSTS
  - Go back to VSTS
  - Select "Code"
  - You will see a notification at the top that says "yuou updated {BranchName} just now -- create a pull request"
  - select the Pull Request link in that message
  - Fill out the required details of the PR
  - Select Create
  - Assign  your partner as a reviewer (they should get an email)
 

### Review a PR
Reiew and approve a pull request
  - When reviewing a PR, Review the code, make notes as needed, and complete/approve as necceasry
  - Select the approriate action from the approve menu
  - Complete once approved (Blue Button top right corner)
  - complete the merge (make sure the top 2 boxes are checked)
  - Wait for merge to complete
  - Your old branch will delete and confirm that your code has the changes
 
### Complete a Task
Completing a task
 - When you complete a PR for a task, that completes the task
 - Go back to the task, and in the discussion, say how long it actually took you (in comparison to the remainig work that you estimated)

Go to the Sprints view - and move the task to "Done"


### Change Remote URL Origin
On your final submission of your project, you will be required to change the remote URL to point to a GH 
repository. Here are the steps to complete this process:

#### Add Alternative Credentials
1. Login
2. select your project
3. select your avatar in top right
4. select "security"
5. Seelct Alternate Creds
6. set up the alt name and password

### Changing Repos

1. Go to your local git repo on you machine
2. Confirm the current origin with the following command: `git remote show origin`
3. You will be prompted for the credentials you specified above in the setup
4. confirm that you see `fetch` and `push` url to point to VSTS. 
5. Run this command `git remote set-url origin {Github Repo URL}}` (
**Example:** `git remote set-url origin https://github.com/Aiverson1011/DotNetBusMall`)
6. Conduct a `git push` on your local repo
7. Confirm your GH repo has updated,

Source: [Changing a remote url](https://help.github.com/articles/changing-a-remote-s-url/)
