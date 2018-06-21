# Trees

There are three most common types of trees
1. Binary Trees
2. Binary Search Trees
3. K-ary Trees

We will revieww some common terminology that is shared amoungst all of the trees
and then dive into specifics of the different types. 

### Common Terminology
1. *Node* - an item or piece of data in a tree. 
2. *Leaf* - a node is considered a leaf if it does not have any children.
3. *Root* - The root node is the very first node in a tree
4. *Left Child* - a left child is the node that is located to the left of root
5. *Right Child* - a right child is the node that is located to the right of the root. 

This is what a tree looks like:

![DepthFirst Traversal](/tree.PNG)


### Traversals

There are two categories of traversals when it comes to trees. 
1. Depth First
2. Breadth First 

We will conduct 4 different traversals on this tree:

![DepthFirst Traversal](assets/depthTraversal.PNG)


#### Depth First
Depth first is a traversal that traverses the depth of the tree. 

The different traversals determine at which point the `Root` is looked at. 
Here are the three different different depth first traversals broken down:

1. Preorder
   - Root, Left, Right
2. Inorder
   - Left, Root, Right
3. Postorder
   - Left, Right, Root


- ***Preorder:*** A, B, D, E, C, F
- ***Inorder:*** D, B, E, A, F, C
- ***Postorder:*** D, E, B, F, C, A


#### Breadth First
The breadth first traversal iterates through the tree by
going through each level of the tree node by node. 

***Output:*** A, B, C, D, E, F

## Binary Trees

Binary Trees are trees that only contain numbers. This is not restricted
to just `ints`, but can extend out to other numeric types such as `decimal`, `double`, `float`, etc...

There is not a specific sorting order for a binary tree. When adding a node to a binary tree,
you are not restricted on the node's location. 

Here is an example of a binary tree:

![DepthFirst Traversal](/Breadth.PNG)

### Adding a node

//Big O


### Finding a node

// O(log n)


## Binary Search Trees
A binary search tree


### Adding a node


//Big O

### Finding a node 

// Big O


## K-ary Trees

//Add

//Find

//Big O


