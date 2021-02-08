# Facilitators Guide: Roles, Claims and JWT Tokens

## Overview

Topic summary ...

### How does this topic fit?

**Where we've been**:
In the previous class we covered Identity and the basics of creating and validating an account (Register() and Login())

**What are we focusing on today**:
Today, we'll be expanding on the user system by providing JWT tokens that will allow the users to login with a Bearer header, as well as to restrict access to the routes based on multiple factors: Identiy, Role, and/or Permissions

**Where we're headed**:
This is the last class for this module.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are ... (use this pull quote to call out any instructor facing notes/outcomes that need toe highlighted)

## Preparation

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Notes here


### TOPIC 1: ROLES

- **Why** (5 min)
  - Roles are a pretty integral part of web applications.
  - They allow us to differentiate between users and provide elevated privileges to specific types of users
  - Roles give us the capability to group together users and provide them with a specialized customized experience.
  - They specify "What you can do", given your user type
- **What** (10 min)
  - Three Levels of Authorization
    - You are logged in
    - You are logged in and are a specific user type
    - You are logged in and have the correct capability
  - Role Based Access Control
    - Typically, a production site would use something like "Azure Active Directory"
    - Unfortunately, Active Directory setup requires configurations that our 401 class doesn't quite have the time or resources to support.
  - With Roles, we have to load them into our database a bit different by injecting them into the Startup file and adding a new class inside "ApplicationUsers"
- **How** (30 min)
  - Users are associated with roles either upon registration
  - Alternatively, an administrator specifically assigning it to them.
  - When a user access a specific page that is only allowed by a specific role, the user will be validated against the database to confirm that they are a subject of that role before being admitted.
- **Experimentation and Discovery Ideas**

### TOPIC 2: Claims

- **Why** (5 min)
  - It is not uncommon for pages to be restricted to specific types of users outside the user holding a specific role.
    - For example, an e-commerce site may have a special page with exclusive products that is dedicated just to users with a specific email domain.
      - Instead of attaching a claim to the user that they are in this special group, the policy can simply check their email address and determine if they are allowed access.
  - The ability to base access off of more than just user role allows us to modify and customize our site to better personalize the experience of our users.
- **What** (10 min)
  - Policies are important for us to be able to manage who accesses what parts of our site through certain "Rules" that we have in place.
  - Much like a policy being a specific rule that must be followed within a business, a policy within a .NET Core Web App can be implemented on specific pages to restrict access to specific users given some claim or defining feature (for example: email address or age of user).
- **How** (30 min)
  - Custom policies are implemented through the creation of Handlers and Requirement.
  - You register both the policy requirement, and the handler with the service provider for the use with Dependency Injection in the Startup file.
- **Experimentation and Discovery Ideas**

## Lab Notes

## What might students struggle with today?

## Past bugs, issues or surprises...

## General Comments and Notes
