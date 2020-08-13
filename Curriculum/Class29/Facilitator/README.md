# Class 29: Policies

## Overview
This is is a catch up day. 

Spend lecture 

## Preparation
Here is a checklist of items that should be completed by the instructor
before lecture:

1. Review the day's readings. The "minimum age" policy that is in the MSFT docs is the same demo code you are writing (or reviewing) in class. The reason for this reuse of the example is because the students already had an opportunity to review the content and you can talk about it in class. If you want an additional policy to review, the demo code contains an "email claims" policy that you can review.
 
1. Review the demo code and the adding of roles to the project. This bit of code is our way of injecting roles into the identity database. Traditionally, a normal team would use Azure Active Directory, but that is out of scope of this curriculum. After discussion with various developers on the asp.NET Core team, this approach of creating an model to inject roles into the database was our workaround. 

1. This is the last lecture of Sprint 1. Review the grading rubric for sprint 1, and the "Peer Review" assignment. You will want review this content with the students at the end of lecture. 

## Lecture
1. Code Review (any of the following to fill the hour)
    - Review Class 28 claims. Review how to add or view a claim
    - Give an in class data structure challenge! - 45 min max
      - Have the students do it independently on a piece of paper in class. 
      - Either go over the solution as a class, or have one student whiteboard their solution and in front of the class. 
1. [Add Roles to a user](./roles.md) - 45 minutes
   - Create a new model to hold the `IdentityRole`
   - Inject roles into the database
   - Assign Roles to specific users upon registration
1. [Custom claim based policy](./policies.md) - 1 hour
   - Create a custom policy based claim
   - Attach the policy to one of the pages and prove it works.
1. Remind students this is the *this is the end of Sprint 1*. The following assignments will be due to close out Sprint 1:
    1. Sprint 1 submission (review the rubric with the class)
    2. Peer Review for Sprint 1 (review the assignment requirements) 
    3. See the "General Comments" below for more information

## What might students struggle with today?  

Historically, it's been a struggle for students to create their own custom policy. The curriculum has
been reworked now so that instead of doing a custom claims based policy, they are simply adding Roles to the app, and having policies for `HasClaim` and `IsInRole`. These get the point across, and is less complex to understand.

If you really want to show them how to create a new custom claims based policy, the documentation on the microsoft docs for minimum age is easy to follow and a good demo. 

## General comments

This is the end of Sprint 1! Remind the students of a few things:
1. Submission of a deployed Azure Website
1. Completed Azure DevOps Kanban Board (with the proper sprint label)
1. User Stories need to be properly filled out. 
1. Peer reviews close 48 hours after the Sprint is due.
1. Sprint Canvas assignment closes 48 hours after it's due. 
1. Keep communicating with partners!


The topic for today is only partially completed in the lab. Instead of having 
the students create a custom policy, the student is just required to 
create an admin panel and crate an "Admin Only" policy. 

Historically having the student create their own custom claims based policy
has not produced good results and it usually holds the student up
from moving forward in the project. You should still show the students 
how to do so in class...but it is not required for implementation. 