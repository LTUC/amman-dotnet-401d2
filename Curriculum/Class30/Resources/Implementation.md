![cf](http://i.imgur.com/7v5ASc8.png) Implementation: Hashtables

## To Submit this Assignment
Within your `Data_Structures and Algorithms` repo:
1. Add a new directory named `Hashtables` inside of your `Data_Structures` directory, 
2. Add/Commit/Push your implementation to the new directory you just created. 
3. Inside the DSA readme doc, add on the your table of contents a link to the readme of your newly created DS. 

## Directions

Implement a Hashtable with
1. Add(key, value) - void return
1. Find(int key) - returns the value from key/value pair
1. Contains(int key) - returns bool
1. GetHash(key) - returns array index

## Specs

Upon completion, your Hashtable should be able to handle the following:
1. Add an item to a hashtable.(Method name: `Add(key, value)`)
1. Get a value from a key (Method name: `Find(key)`)
1. Make a hashing algorithm that will determine and set the Key of your Key/Value Pair(Method Name: `GetHash(key)`)
1. Handle collisions in the event that 2 keys equal the same


## Tests
Test the following:
1. Insertion
2. Contanins
2. 2 tests for collisions


### Main()

1. Your main method should contain an instantiation of your Hashtable. 
2. Add items to your hashtable
3. Force a collision
4. Prove that all keys added exist in the hashtable.

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


