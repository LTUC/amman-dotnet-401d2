![cf](http://i.imgur.com/7v5ASc8.png) Class 00: Prework Introduction
=====================================

## Agenda

1. Validate Software Requirements
	- Visual Studio 2017 Community (v. 15.9)
	- .NET Core SDK 2.1
		- `dotnet --version`

2. Introduction to Team Explorer
	- Visual Studio git extension

3. How to create a project
	- Through Visual Studio
		- File >> New Project >> .NET Core >> Console
		- Select New Git repo if you want it as a repo
	- Through PowerShell or Command Prompt
		- Resources:
			- [Opening Visual Studio with PowerShell](https://www.developerbackpack.com/code-snippets/opening-visual-studio-with-powershell/)
			- [Creating and editing SLN files with .NET CLI](https://andrewlock.net/creating-and-editing-solution-files-with-the-net-cli/)
			- [DotNet CLI Tools](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x)
		- Commands to create
			- `dotnet new sln <name>`
			- `mkdir <nameOfProject>`
			- `cd <nameOfProject>`
			- `dotnet new console`
			- `dotnet sln add path/to/csproj`
			- `vs <NameOfSln>`

	- (optional)Using VSCode
		- Same commands as above
		- use `code` cmdlet to see it open in VSCode

4. Tour of a console app
	- Namespace
	- Program.cs
	- Main()
	- Methods/functions
	- External Methods

5. Data Types
	- different data types
	- declaring variables

6. Selective Statements
	- if..else..
	- switch

7. Arrays
	- Instantiation

8. Iterative Statements
	- for loop
	- while loop

9. Code challenge 
	- reverse an array 2 ways
		- in place
		- new array

10. Push code up using Team Explorer git extension
