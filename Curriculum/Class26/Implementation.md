![cf](http://i.imgur.com/7v5ASc8.png) Implementation: Graph

## To Submit this Assignment
Within your `Data_Structures and Algorithms` repo:
1. Add a new directory named `Graphs` inside of your `Data_Structures` directory, 
2. Add/Commit/Push your implementation to the new directory you just created. 
3. Inside the DSA readme doc, add on the your table of contents a link to the readme of your newly created DS. 

## Directions

Review what Graphs are [HERE](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/Class26/Resources/Graphs){:target="_blank"}

After you have reviewed, implement your own Graph, ***as an adjacency list*** that implements the following:
   1. AddEdge()
      - Adds a new vertice to the graph
   2. GetNodes()
      - returns all of the nodes in the graph as a collection
   3. GetNeighbors()
      - returns a collection of nodes connected to the given node
   4. Size()
      - returns the total number of nodes in the graph
   5. BreadthFirst()
      - Takes in a root node, and returns a collection of all the nodes visited in order


## Specs
Your final project should include the following classes:
1. Program.cs
2. Node.cs
3. Graph.cs

## Tests
Test the following functionality on your Tree:
1. `Size()` returns the correct number of nodes back
2. `GetNeighbors()` returns the correct nodes given a vertice
3. Successfully able to Add an Edge


### Main()

In your main method:
1. Implement `Graph`. 
2. Add vertices to your `Graph`.
3. Call each of the methods you created with `Console.WriteLines()` of what is going on
4. Conduct a `BreadthFirst` traversal

## ReadMe

**A Readme is a requirement. No Readme == No Grade.** <br />
Here are the requirements for a valid readme: <br />

Create your own technical documentation for your new implementation.
	1. Explain to your audience what the data structure is (in your own words) 
	1. Visuals of what it looks like
	1. How you implemented it
	1. What type of uses you would use this for (provide 2 examples)

## Rubric
- 7pts: Program meets all requirements described in implementation directions.

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
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  // Missing Summary Comments |
	0       | No Submission or incomplete submission |


