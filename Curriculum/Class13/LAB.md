![cf](http://i.imgur.com/7v5ASc8.png) Lab 13: Student Enrollment
=====================================

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- write your code
- push to your repository
- submit a link to your Repo in canvas
- Include a `README.md` (contents described below)

## Directions

You are responsible for creating a student enrollment system for a school for the school administration. We can assume that 
only admins will be accessing this site, so no need for authorization/authentication. Here are the requirements.

1. Students can only be registerd for one class at a time. 
1. the administration should be able to view all the students enrolled in a specific course. 
1. View all students enrolled all at once and the class they are registered for
1. View Course information independently. 
1. Remove specific students
1. Remove courses
1. Seach for specific students
1. Search for courses
1. Edit a student's profile
1. Edit a course's information

The workflow of the website should be:
1. Create a new course
1. Create a new student
	- In the registration process, the student will be enrolled into a specific course 
1. When viewing all the students, their course is visible
1. When viewing an individual course, all the students in that course should visible.
1. We can use the CRUD operations on both courses and students
1. You cannot remove a course if it has students enrolled in it. 

1. Add HTML and CSS to the site to make it 'client ready'

### Deploy
Deploy to Azure

### Tests
1. Create a Student
2. Craete a Course
3. Update a Student
4. Update a Course
5. Delete a Course
6. Delete a Student
7. Getters and Setters for all model properties

## README

**A Readme is a requirement. No Readme == No Grade.** <br /> 
Here are the requirements for a valid readme: <br />

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context, provide a summary)
2. show them what it looks like in action (Visuals)
3. show them how they use it (Step by step directions, "Happy Path" walk through)
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo `Resources` folder for an example. 
- [Reference](https://github.com/noffle/art-of-readme)

## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements descibed above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |


