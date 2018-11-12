# Hashtables

## What is a Hashtable?

Terminology:
1. *Hash* - 
2. *Buckets*
3. *Collisions*

## Why do we use them?
1. Hold unique values
2. Dictionary
3. Library
4. Finding any "unique" values

## What Are they
Hashtables are a data structure that utilize key value pairs. This means every entry has both a key, and a value. Here is an example of what a key: value pair looks like:

![Key/Value pair]()

The basic idea of a hashtable is the ability to store the key into this data structure, and quickly retrieve the value. This is done through what we call a `hash`. A `hash` is the ability to encode the key that will eventually map to a specific location in the data structure that we can look at directly to retrieve the value.

Since we are able to `hash` our key and determine the exact location where our value is stored, we can do a lookup in an O(1) time complexity. This is ideal when quick lookups are required. 


## Structure
How do you create a hashtable? 

A hashtable traditionally is created from an array of size 1024. *this is important for index placement*
After you have created your array of the appropriate size, do some sort of logic to turn that "key" into a numeric number value. Here is a possible suggestion:
1. Add all the ASCII values together
2. Multiply it by a large prime number such as 599
3. Divide the result by the total size of the array
4. Insert into the array at that index.

Example:

```
Key = "Cat"
Value = "Josie"

67 + 97 + 116 = 280

280 * 599 = 69648

69648 / 1024 = 68.xxx

Key gets placed in index of 68. 
```


We now know that our key `Cat` maps to index 68 of the array. We can view into this index and find "Josie", our value quickly. 

Let's dive a bit deeper into HOW the key/values are stored in the array. 

Each index of the array can hold many types of values. The trick is how the values are stored in comparison to efficiency. Each Index of the array contain, "buckets". Each of these "buckets" holds one key/value pair combination. Buckets can be represented as either a linked list or a tree. Each holding it's own advantages in efficiency. 

#### Binary Search Trees


### Collisions
A collision occurs when more than one key hashes to the same index in an array. As mentioned earlier, a "perfect hash" will never have any collisions. To put this into perspective, the worst possible hash is one that hashes every single key to the same exact index of an array. The more keys you have hashed to a specific index, the more "buckets" that index will contain. 

So how do we find a key in an index where a collision exists? Well, you iterate through that index in whatever data structure that is contained within that index. 

#### Linked List

One option to handle a collision is to have a linked list at each index and append `Nodes` as needed with the key value pair saved. When searching for a specific key/value in an index that could potentially have more than one bucket, all you do is traverse through the buckets in that index until you find the appropriate key and then extract the value. 

![]()


#### Trees
An alternative to a linked list, you can always use trees. If your keys will always be integers, it is possible to sort your data through a Binary Search Tree. The concept is similar to a linked list, except instead of traversing through a linked list, you would be finding a specific key dependent on the integer value inside the BST. 

![]()

### Internal Methods

#### Add()

#### Find()

#### Contains()

#### GetHash()

## Big O

## Use Cases

# HashSets

