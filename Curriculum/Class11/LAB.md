![cf](http://i.imgur.com/7v5ASc8.png) Lab 11: My First MVC App
=====================================

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- Include a `README.md` (contents described below)

## Directions

**Read the instructions and website components, in it's entirety, before beginning** <br />

Today you will be creating your first ASP.NET Core MVC web application. Provided is a csv file of all the "Time" Persons of the year from 1927 - present. 
Create a web app that will allow a user to put in a span of 2 different years, and a list of all the winners will be returned. 

An example of the **functionality** of your site can be found [here](https://lab11.azurewebsites.net/){:target="_blank"} .

## Website Components
Your MVC Web Application should contain the following:

1. Add the MVC Middleware and include template routing (the route must be explicitly defined)
1. Only 1 controller. The home controller, with 3 actions (2 Index, and 1 Results)
	1. Remember the difference between HTTPGET and HTTPPOST
	1. Upon posting back to the server, call the `Results` action to redirect to the results view. 
1. Views to generate the home page and search results
	1. Use a form tag to accept user input
	1. Use Tag Helpers to help transfer data from the view to the controller
1. Include HTML/CSS in your final product. **This is required.** 
	1. It doesn't have to be fancy, but make it look nice.
1. Enable use of Static Files in your website and create a stylesheet and incorporate some creativity into your application. 
1. A model class that contains the following properties(these are the headers of the csv file):

	```csharp
	 	public int Year { get; set; }
		public string Honor { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public int Birth_Year { get; set; }
		public int DeathYear { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Context { get; set; }
	```
1. Using what you know about reading in external files, and the `System.File` library, convert the CSV file provided into readable data that can be used within the program. CSV files are delimited using commmas, this should be a good start to how to parse out your data. <br />

	Here is my code. Feel free to use it, but if you do **comment every single line** and make sure you know what is going on. 
	This code lives in my `TimePerson.cs` model. 

	```csharp

		public List<TimePerson> GetPersons(int begYear, int endYear)
		{
		    List<TimePerson> people = new List<TimePerson>();
		    string path = Environment.CurrentDirectory;
		    string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot\personOfTheYear.csv"));
		    string[] myFile = File.ReadAllLines(newPath);

		    for (int i = 1; i < myFile.Length; i++)
		    {
			string[] fields = myFile[i].Split(',');
			people.Add(new TimePerson
			{
			    Year = Convert.ToInt32(fields[0]),
			    Honor = fields[1],
			    Name = fields[2],
			    Country = fields[3],
			    Birth_Year = (fields[4] == "")? 0 : Convert.ToInt32(fields[4]),
			    DeathYear = (fields[5] == "")? 0 : Convert.ToInt32(fields[5]),
			    Title = fields[6],
			    Category = fields[7],
			    Context = fields[8],
			});
		    }

		 List<TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();
		 return listofPeople;
		}
	```

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
- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"} 

## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements described above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements described above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // method and variable names are appropriate // Selective and iterative statements are used appropriately, Fundamentals are properly executed // Clearly and cleanly commented // Frequent Commits |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments // minimal or no commits |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |



