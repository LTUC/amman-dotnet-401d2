![cf](http://i.imgur.com/7v5ASc8.png) Implementation: Tree

## To Submit this Assignment
Within your `Data_Structures and Algorithms` repo:
1. Add a new directory named `Trees` inside of your `Data_Structures` directory, 
2. Add/Commit/Push your implementation to the new directory you just created. 
3. Inside the DSA readme doc, add on the your table of contents a link to the readme of your newly created DS. 

## Directions

Review what Trees are [HERE](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/Class14/Resources/Trees){:target="_blank"}

After you have reviewed, implement your own Binary Tree and Binary Search Tree that achieve the following traversals:
   1. PreOrder()
   2. InOrder()
   3. PostOrder()
   4. BreadthFirst()

Also allow your `BinaryTree` to:
- Search()

In addition, Include the following functionality on a Binary Search Tree:
1. Search()
2. Add a Node()  

## Specs
Your final project should include the following classes:
1. Program.cs
2. BinaryTree.cs
3. BinarySearchTree.cs
3. Node.cs

Your BinaryTree.cs should have the following methods:
1. PreOrder(Node root)
2. InOrder(Node root)
3. PostOrder(Node root)
4. BreadthFirst(Node root)
5. Search(Node root, int value)

Your BinarySearchTree.cs should have the following methods
1. Search(Node root, int value)
2. Add(Node root, Node newNode)

## Tests
Test the following functionality on your Tree:
1. Successfully Add a node to your BST
2. Successfully Find a node in your BST
2. Successfully Find a node in your BT


### Main()

In your main method:
1. Make both `BinaryTree` and a `BinarySearchTree`. 
2. Add nodes to both the `BinaryTree` and `BinarySearchTree`.
3. Output the traversals to the main console.
4. In your comments above each traversal call, write out what the order should be for each tree.  

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


