# E-Commerce Sprint 1 - Milestone 2:  Authentication

Work together with your partner(s) to complete this lab.

> NOTE: Your team workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. [Azure DevOps CheatSheet](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/ECom_Project/AzureDevOps_CheatSheet)

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.

## Admin Dashboard

Using Identity, Roles, and Policies, "protect" every screen and feature within the **Admininistrative Dashboard** so that only properly authenticated and authorized users have access to it.

### User Stories and Tasks

Divide your work evenly amongst your team members.

1. As the site owner, I would like to secure the admin dashboard so that only users with an administrative role can access it
1. As an administrator I would like to ensure that only users with **create** permissions can add categories or products
1. As an administrator I would like to ensure that only users with **update** permissions can modify categories or products
1. As an administrator I would like to ensure that only users with **update** permissions can add a product to a category
1. As an administrator I would like to ensure that only users with **delete** permissions can delete categories or products

### Guidance

- You'll need to wire up Identity, Roles, Policies and JWT within your application
- **Seed** your admin users with phony passwords.
  - Remember, we don't want to let people just register as administrators
- Store a cookie in the browser on login.
- Read the token from that cookie on every inbound request so you can protect your routes

## Tests

1. Test the Login capabilities of your interface.
1. Test the ability to set and receive a Browser Cookie

## To Submit this Assignment

- Continue to work in your `E-Commerce-App` repository
- Create a branch named `sprint-#-milestone-#`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
