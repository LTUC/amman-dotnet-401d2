# Facilitators Guide: Azure Blob Storage

## Overview

Azure (and AWS) is a cloud provider that offers a storage medium where we can upload and store files. Much like a virtual, remote hard disk, we can use this safely and securely to store files for our web applications

### How does this topic fit?

**Where we've been**:
To this point, students have created a full CMS for their E-Commerce website. They've wired up a login/authentication system, administrator workflows, and fulL CRUD Operations for 2 data sources (products and categories)

**What are we focusing on today**:
Today, we'll be showing them how to upload files using multipart forms and save those files remotely in an Azure Storage Container. Following this, they will have a full CMS where an admin can upload product images for their store.

**Where we're headed**:
This completes "Sprint 1", which is the full CMS written using .NET MVC. The final sprint code and peer review will be due. We'll be switching over the customer side of the application in our next sprint, using Razor Pages as our rendering engine.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to understand multipart forms, binary uploads, and the notion of uploading files to a remote server

## Preparation

- Make sure your Azure account is open and online
- Practice the demo, making sure you can upload files to your own Azure storage account(s)

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

- Make sure that the student's CRUD functionality is work.
- Unblock any that are stuck -- generally, you'll find mis-wiring of services and/or DbContext
- Great opportunity to revisit the notion of Dependency Injection

### TOPIC 1: Multipart Forms and Binary Uploads

- **Why** (5 min)
  - Not all "POST" operations are created equal.
  - Because files can be enormous, we need to upload them in chunks
  - Also, all HTTP requests/body has to be done as a string, not binary, so we need to convert files to actual strings
- **What** (10 min)
  - `multipart/form-data` forms
    - These convert binary to string, break into small chunks
    - Servers must then assemble the chunks and convert the files back to binary form
- **How** (30 min)
  - `<form enctype-"multipart/form-data" method="post" />`
    - Engages the browser and the server to do the conversion and transfer
  - `<input type="file" />`
    - Allows you to pick a file from your computer to upload
    - Sends the raw bytes as well as file metadata to the server
  - `public async Task<IActionResult> Index(IFormFile file)`
    - The `IFormFile` interface converts the file back to binary, reads the metadata and allows us to "stream" it to another service
  - Stream the file from `IFormFile` to your local file system

### TOPIC 2: Azure Storage Containers and Blobs

- **Why** (5 min)
  - Not every website runs on a single computer/server
  - Large/Enterprise sites run in "The Cloud", so we need to store uploaded files there as well
  - We don't have to manage the file system, delivery system, CDN, etc.
- **What** (10 min)
  - Azure Storage Service
    - Container: Folder
    - Blob: File
  - AWS S3 (Simple Storage Service)
    - Bucket: Folder
    - Object: File
  - Both systems allow us to upload/store files of any type
  - Cloud systems will then distribute the files using a CDN or similar service so that they're easily accessible for browsers.
- **How** (30 min)
  - Alter the demo to upload to Azure instead of your file system
  - Create a storage container
  - Create a service in your system that talks to Azure
  - Call the service from the controller when we upload a file
- **Experimentation and Discovery Ideas**
  - You might build the entire system in the controller and then point out:
    - This is bad - controllers that do actual work are breaking the rules of MVC
    - But, now that we have working code, refactoring into a service is a great exercize

## Lab Notes

- Students might still be behind in their CRUD forms.
- Encourage them to stop that work, wire in the uploading, even if it's just an equivalent to the demo (upload and show a file on a random form)
- This way, they can go back to their CRUD forms and then easily hook in a working upload system to that.

## What might students struggle with today?

- Uploading a file as a separate operation from posting of the entire form

## Past bugs, issues or surprises...

## General Comments and Notes
