# Linked Lists

## What is a Linked List
A Linked List is a sequence of `Nodes` that are connected/linked to each other. The most defining feature
of a linked List is is that each `Node` references the next `Node` in the link. 

## Terminology:
1. *Linked List* - A data structure that contains Nodes that links/points to the next node in the list. 
1. *Singly* - Singly referes to the number of references the Node has. A `Singly` linked list means that there is only one reference,
and the reference points to the `Next` node in a linked list
1. *Doubly* - Doubly referes to there being two (double) references within the node. A `Doubly` linked list means that there
is a reference to both the `Next` and `Previous` Node. 
2. *Node* - Nodes are the individual items/links that live in a linked list. Each node contains the data for each link
3. *Next* - Each node contains a property called `Next`. This property contains the reference to the next node. 
4. *Head* - The Head is a reference type of type node to the first node in a linked list.
5. *Current* - The `Current` reference is a reference type of type node that is currently being looked at. This node is traditionally used when 
traversing through a full linked list. When traversing, you typically reset the current to the head to guarantee you are starting
from the beginning of the linked list. 

## What does it look like

This is what a Singly Linked List looks like

![Singly Linked List](assets/LinkedList1.PNG)

### Adding a Node

Order of operations is exteremely important when it comes to working with a Linked List.
What I mean by this is you have to be careful that all references to each link/node is properly 
assigned. 

An example can be with adding a node to a linked list.
If we want to add a node with an `O(1)` efficiency, we have to replace the current `Head` of the linked list with the
new node, without losing the reference to the next node in the list. 

Here are the required steps to add a new node with an O(1) efficiency.

1. Set Current = Head. This will gaurantee us that we are starting from the very beginning. 
2. We can then instantiate the new node that we are adding. The values passed in as arguements into the `Add()` method
will define what the value of the Node will be. 

![Singly Linked List](assets/LinkedList2.PNG)

3. `newNode.Next` by default is set to `null`. We want to set the new node `Next` property to the Head Node.
Because `Head` is just a reference type, we will be assigining it to the same allocation in memory as the node it is pointing too. In this
case, it's `Node1`. 
![Singly Linked List](assets/LinkedList3.PNG)


4. At this point in the program. We now "techincally" have `newNode` at the beginning of the linked list, but we are not done yet. 
We now have to re-assign where Head is pointing too. Since `node1` is no longer the first node in the list, we want to re-assign `Head` to
point at `newNode`. 

5. While we are at it, let's just re-assign current as well to make sure should any further operation start at the new true start of the
linked list. 

![Singly Linked List](assets/LinkedList4.PNG)


#### Code

Here is the C# code for an `Add` method on a Linked list

```csharp
		public void Add(Node newNode)
		{
			Current = Head;
			newNode.Next = Head;
			Head = newNode;
			Current = Head;
		}
```

### Traversal

### Print Out Nodes
