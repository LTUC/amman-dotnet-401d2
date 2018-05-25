# Garbage Collection

## Value Types

## Reference Types 

## GC Generations
   1. When you declare a variable in a .NET application, it allocates some chunk of memory in the RAM. 
   This memory has three things: 
        1. the name of the variable
        2. the data type of the variable
        3. the value of the variable.

## Stack/Heap
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


## Application/Demo
