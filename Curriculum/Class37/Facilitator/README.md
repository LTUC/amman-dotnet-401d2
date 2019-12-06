# Class 37: File Uploads and Azure Blob

## Overview
Today, the students get a look at how to conduct file uploads and storage using Azure Blob Storage. They will implement this functionality into their Ecommerce project to allow for prodcut details manipulation.

## How do I prep for today?
1. Review the readings
2. Review the demo code
3. Have access to Azure Storage Account
4. Have a pre-created Razor Page web app with a basic home route and enabled user secrets. No database is required for this app. 

## Lecture Outline
1. Code Review any standing issues with students in their ECom project
2. Code review the pre-created code from your prep (or build it in class with the students)
3. Introduce File uploads
   - Why
     - It is pretty popular to have the ability for file management within a web application. This can be due to something as small as uploading a profile picture, or a bit more complicated such as uploading a resume or cover letter to a potential job opportunity. Web applications should be setup to handle these types of functionality quickly and efficiently so that users can share and upload documents as needed.
   - What
     - File upload is the ability for a user to take a document or file from their personal machine and transfer it to the web server hosting the site. Ideally, this document should be accessible in the future within the application. 
   - How
     - When implementing file upload capabilities, you have to take into consideration security of the types and sizes of files that are being uploaded to your server. Review the demo code on implementing a basic file upload app. 

    Implement for the students a very basic file upload app using Razor Pages. This application isnt' going to "do" anything with the file that was uploaded just yet, that we will showcase that when introducing Azure Blob Storage. Utulize breakpoints when demoing with the students when proving that the file was accepted by the web app. 

4. Introduce Azure Blob Storage
   - Why
   - What 
   - How

## Lab Notes
In lab, they will add file upload capabilities to their Products manipulation in their Admin dashboard. They should be able to create or update product images. They will store their images in Azure Blob Storage, and save the URL references in the database attached to the product. 