# Stacks and Queues

## What is a Stack

A stack is a data structure that consists of `Nodes`. Each `Node` references the next node in the 
stack, but does not reference it's previous. 

Common terminology for a stack is 
1. *Push* - Nodes or items that are put into the stack are considered to be *pushed*
2. *Pop* - Nodes or items that are removed from the stack are *popped*
3. *Top* - This is the top of the stack.
4. *Peek* - When you `Peek` you will view the `Top` node in the stack. If the stack is empty,
and you don't `Peek`, you will recieve a `NullReferenceException` if you attempt to `Pop`. 

Stacks follow these concepts:
1. **FILO** concept: **F**irst **I**n **L**ast **O**ut.
This means that the first item in the stack, will be the last item out. 

2. **LIFO** concept: **L**ast **I**n **F**irst **O**ut
This means that the last item in the stack, will be the first item out. 

This is what a stack looks like:

![Singly Linked List](assets/stack1.PNG)

### Push O(1)

Pushing a node onto a stack will be an O(1) operation. This is because it takes the same
amount of time, no matter how many nodes you have in the stack.

When adding a node, you essentially want to `Push` it into the stack
and then re-assign the `Top` to newly added node. 

Let's walk through the steps:
1. First, You should have the node that you want to add. Here is an example of a Node that we want to add to the stack.

![Singly Linked List](assets/pushStack1.PNG)

2. Next, you need to assign the `Next` property of `Node5` to reference the same Node 
that `Top` is referencing. This will end up being `Node4`

![Singly Linked List](assets/pushStack2.PNG)

3. Technically at this point, your new node is added to your stack, 
but there is no indication that it is the first node in the stack. 
To make this happen, you have to re-assign our reference type `Top` to the newly added node, `Node5`.

![Singly Linked List](assets/pushStack3.PNG)

4. Congratulations! You completed a successful `Push` of `Node5` onto the stack. 


Here is the C# code to `Push` a node onto a stack:

```csharp
public void Push(Node node)
{
	node.Next = Top;
	Top = node;
}
```

 
### Pop O(1)

Popping a node off of a stack the action of removing a node from the top.
When conducting a `Pop`, the `Top` node will be re-assigned to the node
that lives below and the `Top` node is returned back to the user.

Let's try and `Pop` off `Node5` from the stack. Here is a visual of the current state of our stack:

![Singly Linked List](assets/popStack1.PNG)

1. The first step of removing `Node5` from the stack is to create a reference named `Temp` that points to the same node that `Top` points to. 

![Singly Linked List](assets/popStack2.PNG)

2. Once you have created the new reference type, you now need to re-assign `Top` 
to the value that the `Next` property is referencing. In our visual, we can see that the `Next` property is pointing
to `Node4`. We will re-assign `Top` to be `Node4`. 

![Singly Linked List](assets/popStack3.PNG)

3. We can now remove `Node5` safely without it affecting the rest of the stack. Before we 
do that though you may want to make sure that you clear out the `Next` property in your current `Temp` reference. 
This will ensure that no further references to `Node4` are floating around the heap. This will allow our garbage collector to cleanly
and safely dispose of the nodes correctly. 

![Singly Linked List](assets/popStack4.PNG)

4. Finally, we return the `Temp` node. 

![Singly Linked List](assets/popStack5.PNG)

Here is the C# code for a `Pop`

```csharp
public Node Pop()
{
	Node temp = Top;
	Top = Top.Next;
	temp.Next = null;
	return temp;
}
```



### Peek O(1)
When conducting a `Peek`, you will only be viewing the `Top` node of the stack.
Traditionally, you always want to `Peek` before conducting a `Pop`. This will ensure
that you do not recieve a `NullExceptionError` on your `Pop` action. 

Here is the C# code for a `Peek`

```csharp
public Node Peek()
{
	return Top;
}
```

We do not re-assign the `Next` property when we `Peek` because we want to keep the reference
to the next node in the stack. This will allow the `Top` to stay the top until we decide to `Pop`

## What is a Queue

Common terminology for a queue is 
1. *Enqueue* - Nodes or items that are put into the stack are considered to be *pushed*
2. *Dequeue* - Nodes or items that are removed from the stack are *popped*
3. *Front* - This is the front/first node of the queue.
4. *Rear* - This is the rear/last node of the queue.
4. *Peek* - When you `Peek` you will view the `Top` node in the stack. If the stack is empty,
and you don't `Peek`, you will recieve a `NullReferenceException`. 

Queues follow these concepts:

1. **FIFO** - **F**irst **I**n **F**irst **O**ut - This means that the first item in the queue will be the first item out of the queue.
2. **LILO** - **L**ast **In** **L**ast **O**out - This means that the last item in the queue will be the last item out of the queue. 

Here is what a `Queue` looks like: 

![Singly Linked List](assets/Queue.PNG)

### Enqueue O(1)
When you add an item to a queue, you use the `Enqueue` action. This is done with an O(1) operation in time because
it does not matter how many other items live in the queue, it takes the same amount of time to perform the operation. 

Let's walk through the process of adding a node to a queue:

![Singly Linked List](assets/Enqueue1.PNG)

1. The first thing we have to do assign the new node, `Node6`'s `Next` property to point to the same node that `Rear` points to. 
This means that we will be pointing `Node6.Next` to be `Node5`.

![Singly Linked List](assets/Enqueue2.PNG)

2. After we have set the `Next` property, we can re-assign the `Rear` reference to point to `Node6`.
By doing this, it allows us to keep a reference of where the `Rear` is, and we can continue to `Enqueue` 
nodes into the queue as needed. 

![Singly Linked List](assets/Enqueue3.PNG)

3. Congratulations! You have just successfully added a node to a queue by activating the `Enqueue` action.

#### Code

Here is the C# Code for the `Enqueue` method:

```csharp
public void Enqueue(Node node)
{
	node.Next = Rear;
	Rear = node.Next;
}
```

### Dequeue O(1)

When you remove an item from a queue, you use the `Dequeue` action. This is done with an O(1) operatiin in time because
it doesn't matter how many other items are in the queue, you are still always removing the `Front` node of the queue. 

Let's walk through the process of removing a node from a queue. 

1. The first thing you want to do create a temporary reference type named `Temp` and have it point to the same node
that `Front` is pointing too. This means that `Temp` will point to `Node1`

![Singly Linked List](assets/Dequeue1.PNG)

2. Next, you want to re-assign `Front` to the `Next` value that the node `Front` is referencing. In our visual, this would
be `Node2`. 

![Singly Linked List](assets/Dequeue2.PNG)

3. Now that we have moved `Front` to the second node in line, we can next re-assign the `Next` property on the `Temp` node to null. 
We do this because we want to make sure that all the proper nodes clear any unneccesary references for the garbage collector to come in 
later and clean up. 

![Singly Linked List](assets/Dequeue3.PNG)

4. Congratulations! You have just succesfully completed a `Dequeue` action on a queue!

![Singly Linked List](assets/Dequeue4.PNG)

#### Code

Here is the C# Code for the `Dequeue` method:

```csharp
public Node Dequeue(Node node)
{
	Node temp = Front;
	Front = Front.Next;
	temp.Next = null
	
	return temp;
}
```

### Peek O(1)

When conducting a `Peek`, you will only be viewing the `Frong` node of the stack.
Traditionally, you always want to `Peek` before conducting a `Dequeue`. This will ensure
that you do not recieve a `NullExceptionError` on your `Dequeue` action. 

#### Code

Here is the C# code for a `Peek`

```csharp
public Node Peek()
{
	return Front;
}
```

We do not re-assign the `Next` property when we `Peek` because we want to keep the reference
to the next node in the queue. This will allow the `Front` to stay in the front until we decide to `Dequeue`


### Constructors in your classes
You should include a constructor in both your `Stack` and `Queue` class to 
gaurantee that you have at least one node starting out. Don't forget to assign the proper 
properties to the correct locations in both the stack and the queue.