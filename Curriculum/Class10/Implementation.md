![cf](http://i.imgur.com/7v5ASc8.png) Implementation: A Stack and a Queue

## To Submit this Assignment
Within your `Data_Structures and Algorithms` repo:
1. Add a new directory named `Stack and Queue`, 
2. Add/Commit/Push your implementation to the new directory you just created. 
3. Inside the DSA readme doc, add on the your table of contents a link to the readme of your newly created DS. 

## Directions

Review what a Stack and Queue is [HERE](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/Class10/Resources/STACKSQUEUES){:target="_blank"}

Implement a Stack and a Queue. Your `Stack` should meet the following criteria:

1. O(1) - .Push(Node node) - Add a node to the stack
2. O(1) - .Pop() - removes and return the top node of the stack
3. O(1) - .Peek() - returns the top node of the stack.

Your `Queue` should meet the following criteria:

1. O(1) - .Enqueue(Node node) - Add a node to the queue
2. O(1) - .Dequeue() - removes and return the front node of the queue
3. O(1) - .Peek() - returns the front node of the queue.

## Specs

Upon completion, your Linked List should contain the following:
1. `Node` class,
2. `Stack` class
	- This is where your methods such as `Push()`, `Pop` and `Peek()` will live 
3.  `Queue` class
	 - This is where your `Enqueue`, `Dequeue`, and `Peek` will live
3. `Program` Class.
	- This is where your `Main()` method will live
	- Instantiate your `Stack` and `Queue`
	- Add Nodes to each
	- Output a few of the nodes

## Tests
Test the following conditions:
1. Pushing a node onto your stack
2. Popping a node off your stack
3. Peeking at the top node of your stack
4. Enqueue a node into your queue
5. Dequeue a node off of your queue
6. Peek at the front of your queue.


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
