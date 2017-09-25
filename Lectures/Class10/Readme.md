![cf](http://i.imgur.com/7v5ASc8.png) Lab 10 : Azure Deployment
=====================================

## Azure Deployment

1. Right click on project
2. Publish
3. sign into your MS account you created for your DevEssentials
4. Create a new resource group
5. a link is provided: [My Link](http://myfirstapp20170922101850.azurewebsites.net/)




### **Stack/Heap & Garbage Collection**
   1. When you declare a variable in a .NET application, 
         it allocates some chunk of memory in the RAM. This memory has three things: 
        1. the name of the variable
        2. the data type of the variable
        3. the value of the variable.
    1. What is the Stack?
       1. Imagine it like a stack of shoe boxes 
       1. Keeps track of what is being executed in the code
       1. Holds value types
       1. Self-maintaining -takes care of it's own memory management
    1. What is the heap?
       1. Imagine it like a bucket with a lot of 'things' in it
       1. Keeps track of objects / reference types / *sometimes* Value Types
       1. Relies on Garbage collection (GC) for memory management
       1. Reference Types usually go to the heap


***Demo***

```csharp
    Public void MyMethod()
    {
        int x= 5;
        int y= 10;
        MyClass objName = new MyClass();
    }   
```

**Breakdown the Code above**
1. ***Line 1:*** the comiler allocates a small amount of memory on th stack for this variable declaration. (the stack is responsible for keeping track of the running memory needed in your application)
1. ***Line 2:*** This is the next step, and it then 'stacks' the next memory allocation on top of the previous one. Think of this as 2 boxes stacked on top of each other. 
   1. Memory Allocation works like this: LIFO (last in first out) - meaning memory is allocated and de-allocated at only one end fo the memory (top of the stack)
1. ***Line 3:*** Here, we created an object, when this is executed, it creates a pointer on the stack to the actual object stored in the "Heap". 
   1. Heap does not track running memory, its just a pile of objects that can be reached at any moment in time. Heap is used for dynamic memory allocation. 

1. ***Exiting the Method***: When the exectution meets the end of the method, it will start 'exiting' meaning it will clear the memory variables that are assigned in the stack. This de-allocaiton happsn in a "LIFO fashion of the stack.
    1. this leaves the heap still with the object reference. Garbage Collection will take care of this by removing the object ***as long as there are no pointers or references to it***


**Stack/Heap Before Exiting**

|Stack           |Heap           |
|----------------|---------------|
|objName(ref -->)|ObjName(object)| 
| y=10 |               | 
|  x= 5  (first in last out)  | | 


**After Exiting**

|Stack           |Heap           |
|----------------|---------------|
||ObjName(object)| 
||               | 
| | | 


- Static Memory ==> Stack
- Dynamic Memory ==> Heap

- Value Types: are types whch hold both data and memory on the same location

```csharp
int x = 5;
int y = x;
```

|Stack           |Heap           |
|----------------|---------------|
|y = 5|| 
|x = 5|| 

- Reference Type: has a pointer which points to the memory location

```csharp
MyClass obj = new MyClass();

MyClass obj2 = obj;
```

|Stack           |Heap           |
|----------------|---------------|
|obj2(reference)->| Object| 
|obj(reference) ->|(same object w/ 2 pointers)| 



## Stacks && Queues