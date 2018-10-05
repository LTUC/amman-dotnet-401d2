![cf](http://i.imgur.com/7v5ASc8.png) Lab 19: Using your API 
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
**read all the directions (including the Readme section), in it's entirety before completing** <br />
Get creative, and surf the Bing.<br />
You will create an **empty** MVC web application that will consume a the deployed API that you created for lab 17.
  - You *must* deploy this API onto your azure account. 

using  `HttpClient` class, consume the external API using the following example as a baseline. 

```csharp
	using (var client = new HttpClient())
	{
		// add the appropriate properties on top of the client base address.
		client.BaseAddress = new Uri("http://mysite.com");

		//the .Result is important for us to extract the result of the response from the call
		var response = client.GetAsync("/api/route/id").Result;

		if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
		{
			var stringResult = await response.Content.ReadAsStringAsync();
		}
	}

```

Deploy your application to Azure. Provide your deployed link in your readme. 
<br />


## Specs
Upon Completion, the following should be true:

1. Front-end interface where the user can navigate and display the ToDo items and lists from your API
1. Your MVC APP does not need a database.
1. Your API and your web application must compliment each other
	- You must responsibly and intuitively integrate the api in with web application.  

## Tests
No Tests required

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
