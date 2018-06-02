# Garbage Collection

## Value Types
A data type is a value type.
1. Value types hold the data within its own memory allocation. 
1. Examples include `int`s, `float`,`double`, `long`
1. Enums are examples of value Types
1. Value types only live on the stack. 
1. A Struct is an example of a value type 
1. It is a copy, and can be changed/manipulated as want without it affecting anything else.
1. Created at compile time, and stored in stack memory. GC cannot access the stack.

## Reference Types 
A reference type is something that has a reference (address) to the object but not the object itself.
1. Because it only contains a reference, assigning a reference var to another var rather than the data itself doesn't copy the data.
Instead it creates a second reference, pointing to the same location on the heap.
1. reference types contains a pointer to another memory location that holds the real data.
1. Mostly strings and objects
1. arrays are reference types
1. Indexers, Interfaces are ref types.
1. Class is an example of a reference type
1. Ref types vars are stored in the HEAP.
1. Placed on the stack as a pointer and refers to a memory address in the heap. 

```csharp
int[] myArray = new int[10];
```

The space required for the 10 integers that make up the array is allocated on the HEAP

## Example/Anology
Digital Newspaper(reference type) vs Printed Newspaper (Value Type)

## Stack/Heap
Both are stored on computers RAM
    1. What is the Stack?
       1. Imagine it like a stack of shoe boxes 
       1. Keeps track of what is being executed in the code
	   1. Variables allocated to the stack are stored directly to the memory, making it very fast for access.
	   1. Allocated at compile time
       1. Holds value types
       1. Self-maintaining -takes care of it's own memory management
	   1. static memory allocation
    1. What is the heap?
	   1. Dynamic memory allocation 
	   1. have their memory allocated at runtime. Accessing is a bit slower than on the stack.
	   1. heap size is only limited by the size of virutal memory.
	   1. No dependencies on one another and can always be randomly accessed. 
       1. Imagine it like a bucket with a lot of 'things' in it
       1. Keeps track of objects / reference types / *sometimes* Value Types
       1. Relies on Garbage collection (GC) for memory management
       1. Reference Types usually go to the heap

You can use the stack if you know exactly how much data you need to allocate before 
compile time and it is not too big. You can use heap if you don't know exactly how much 
data you will need at runtime or if you need to allocate a lot of data

## GC Generations
   1. When you declare a variable in a 
   .NET application, it allocates some chunk of 
   memory in the RAM. 
   This memory has three things: 
        1. the name of the variable
        2. the data type of the variable
        3. the value of the variable.

The .NET Garbage Collector has 3 generations. Each
generation has it's own heap that is used for the storage of 
allocated objects. There is a basic principle that most objects
are either short-lived or long-lived.

#### Generation First(0)
1. Objects are first allocated at Generation 0
2. Objects don't typically live past the first gen since
they are no longer in use (out of scope) by the time the next
garbage collection occurs
3. Gen 0 is quick to collect because it's association with the heap is small.

#### Generation Second(1)
1. In Gen 1, objects have a second chance space
2. Obejcts are short-lived but servive Gen 0 collection
3. Gen 1 collections are also quick because of its assoc. heap is also small
4. The first two heaps remain small becaus ethe objects are either collected or promoted to
the next generation

#### Generation Third(2)
1. Gen 2, all long objects are lived and its heap can grow very large
2. the objects in this genertion can survive a long time and there is no next gernation heap
to further promote objects. 
3. The GC has an additional heap for large objects know as Large Object Heap(LOH)
4. LOH is reserved for obejcts that are 85k bytes or greater
5. Large obejcts are not allocated to the gernational heaps, but directly to the LOH
6. Generateion 2 and LOH collects can take noticable
time for programs that have run for a long time or operate over large amounts of data. 

### Advantages of GC
	1. You don't need to free up memory manually while developing your application
	2. It allocates objects on the managed heap efficiently
	3. When objects are no longer used then it will reclaim those objects by clearing their memory
	and keeps the memory available for future allocaitons
	4. Managed objects automatically get clean content to start with, so their
	constructors do not have to initialize every data field.
	5. It provides memory safely by making sure that an object cannot use the contnet
	of another object.

### GC Conditions
	Garbage Collection occurs when one of the following conditions becomes true:
	1. System has low physical memory
	2. the memory that is used by allocated objects on the managed heap surpasses an acceptable
	threshold. This threshold is continuously adjusted as the process runs.
	3. The `GC.Collect` method is called.
