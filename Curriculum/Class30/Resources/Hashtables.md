# Hashtables

## What is a Hashtable?

Terminology:
1. *Hash* - 
2. *Buckets*
3. *Collisions*
4. 

## Why do we use them?
1. Hold unique values
2. Dictionary
3. Library

## Structure
How do you create a hashtable? 

1. Create an array of size 1024. *this is important for index placement*
2. Do some sort of logic to turn that "key" into a numeric number value
   - Add all the ASCII values together
   - Multiply it by a large prime number such as 599
   - 
3. Determine the index of the array
4. Insert into the array at that index

Example:

```
Key = "Cat"

67 + 97 + 116 = 280

280 * 599 = 69648

69648 / 1024 = 68.xxx

Key gets placed in index of 68. 
```



### Internal Methods
#### Add()

#### Find()

#### Contains()

#### GetHash()

## Big O

## Use Cases

# HashSets

