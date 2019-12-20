# .NET-gram!

## Instructions
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Merge your PR back into master
- Submit your repo link
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)

** No Submission required for Part 1. Part 2 will be a submission for both parts, and worth 20points


## Directions

### Part 1

Build a ".NET-gram"! 

This is part 1 of 2 of our Razor Pages Web Application. 

1. Create a brand new empty web application within .NET Core 2.2 
2. Set up your web application to use the Razor Pages architectural pattern. 
3. Integrate the repository design pattern into your application
4. Seed you database with approx 5 posts with pre-populated information
5. Ensure your application is utilizing User Secrets.

Create a Razor Pages web application (starting from an empty web app) that holds posts of images and details. 

Your first part of the app should have all of the above, as well as...
1. Home page that shows all of the posts created
	- Have placeholders for images for now, since we don't quite know how to upload images yet!
2. A landing page for each post that shows all the details of the post. 
3. The ability to edit the details of a post.
4. Capability to add and delete posts. 

Don't worry about user accounts. For now, each user will just input their name as the author of the post. 

### Stretch
1. Add the ability to comment on posts! 
2. Work ahead on Part 2!


### Part 2
Keep building off of your existing razor page app:

1. Add some CSS! Make it look nice!
2. Enable the capability to upload files and store them in to Azure Blob Storage. 
3. Use Azure Blob Storage to store all of your images.
4. Capture the link of each Blob and store it's location with each post in the DB.
4. Deploy your application to Azure.

Your README should contain:
1. Introduction to the app (3 -5 sentences)
2. How to use
3. Screenshots of the application (2 or 3 good images with captions/explanations)
3. Deployment link (top of the README, please)
4. Technologies used
5. Architectural Design
6. Any additional important information...

## Tests
Test each method within your services data layer. 

## Rubric
- 14pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	14       | Program runs as expected, no exceptions during execution |
	10       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	8       | Program meets most of the functionality requirements descibed above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	6       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	4       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 6pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 10/14 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	6       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	4       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	2       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |


