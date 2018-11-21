# Insertion Sort

Insertion sort is one of the three a simple sort.
Simple sorts consist of:
1. Bubble Sort
2. Selection Sort
3. Insertion Sort.

All the "simple sorts" are brute force algorithm and have quadratic approach. Insertion is what we call "stable". It starts at the left most element in the array and moves right, sorting everything behind the initial pointer as it moves through the list. 

A stable sort means that it can effectively handle and keep the original order of the input set. A stable sort can guarantee that the original order will stay true, while an unstable cannot. Both bubble and insertion sort are stable while selection sort is not. 

Insertion sort can also be done in place, giving us an O(1) space. 

An advantage to insertion sort is if you are incrementally building a list, you can do it as items are received. Insertion sort is really only beneficial on small lists. The threshold for this is approx. 50 items in an array.

## Approach and Algorithm

At a very high level, an insertion sort has the following algorithm:

1. At each iteration, insertion sort removes one element from input data
2. Finds it's location from the values up until that index
3. Inserts it at it's location
4. Repeats until it has iterated through the whole list.


Here is a suggested algorithm for approaching:

1. Use a for loop to iterate through the array
1. At each index, set a `temp` variable to hold the current index value
1. Create a new variable (j) to one position less than the outer for loop
1. while j is greater than zero (we are not at the end), and the value of temp is less than the position of j
	- "move" the value of j over one position
	- "decrement" j back one position
1. Once you are out of the while loop, you know at least 1 of 2 things is true:
	- j has reached the beginning of the list. 
	- the position of j is less than temp and you know where it needs to be inserted
1. Increment the outer for loop one more position and repeat until you hit the end of the list

## Efficiency

*BEST: (Big Mega)* At it's best, the array is already sorted. Giving us an O(n) linear search. 

*WORST: (Big O)* at it's worst, the array is reverse sorted, giving us a quadratic runtime of O(n^2)

*AVERAGE: (Big Theta)* At average, we can assume a random input of integers inside of our array. This will give us a quadratic approach still. This makes it impractical for large data sets. we are still at an O(n^2)

## Insertion vs Selection Sort

Insertion is similar to selection sort, except that selection sort scans the whole list every time for the "next" smallest value. Insertion, at it's best case, does approx. 1/2 the comparisons that selection does. At it's worst, insertion does  just as many comparisons as selection sort. A main difference between the two is that selection sort *is not* stable. 

A disadvantage to insertion is the number of "writes" that must happen. Because we have to swap and shift values on every iteration, we get an O(n^2) approach on writes, while in selection, it is just one write per traversal, giving us an O(n). If you need to take the memory of writing into consideration, than selection sort may be best instead of insertion. 


## Code

```javascript
1.		InsertionSort(int[] arr)
2.			for (int i = 1; i < arr.length; i++)
3.				int j <-- i - 1;
4.				int temp <-- arr[i];
5.
6.				while (j >= 0 && temp < arr[j])
7.					arr[j + 1] <-- arr[j];
8.					j--; ;
9.
10.				arr[j + 1] <-- temp;
```

### Walkthrough
Let's take a look at the following array:

```
[4,3,1,8,5,7,2]
```

Running the code from above, here is state of the array after the each run through of the for loop

```
1: [3,4,1,8,5,7,2]
2: [1,3,4,8,5,7,2]
3: [1,3,4,8,5,7,2]
4: [1,3,4,5,8,7,2]
5: [1,3,4,5,7,8,2]
6: [1,2,3,4,5,7,8]
```

Let's dive a bit deeper though...What is actually happening while the inner while loop is running?

1. We start our outer for loop at 1, because we can safely assume that position 0 is already where it needs to go. You cannot sort one item, so we have to start at the second element (index 1) to really have any value of sorting.
1. `j` will always start at one position less than i. This is because we want to compare the index against something. We have to determine if the target index is less than the value of the index to the left. 
1. We want to create a `temp` variable to hold the initial value of the array at position i. This is because later on we may potentially be overwriting this index with a new value as we shift values, and we have to remember and save the value we are placing elsewhere in the array. 
1. Once we hit the while loop, let's remind ourselves our variable values
	```
	i = 1
	j = 0
	temp = 3
	```
	picking back up on line 6, we can see that j is less than or equal to zero AND temp(3) is less than the value of arr position 0 (which is 4). This means that we will run the while loop. 
1. The point of this while loop is to shift all the values of the array over by one. We do this by taking the value of 'arr[j]` and shifting it one position to the left(j+1). This means that after line 7 executes, the state of our array is this `[4,4,1,8,5,7,2]`. 
1. The state of our array looks off because we haven't completed the full cycle of the for loop. Remember that we have the value that we are placing in the temp...so it's still safe. we will place it in it's correct location at the very end.
1. We will than decrement `j` because we want to continually move backwards from i to make sure we are putting our temp value in the correct location. 
1. After we decrement `j`, our values are as follows:
	```
	i = 1
	j = -1
	temp = 3
	```
1. since `j` is now less than 0, this is going to break us ouot of the while loop.
1. `array[j+1]` can be simplified to `arr[0]` since j = -1. This means that position 0 of the array will now be equal to the value of temp, which is 3. This is the state of the array after we set the value of `arr[0]` to temp.

```
[1,3,4,8,5,7,2]
```

1. After this, the for loop will than increment to 2, and the process starts all over again. Try and manually step through the code on you own?

## Conclusion

That's insertion sort in a nutshell. As stated above, the Big O runtime of insertion sort is O(n^2) with a space of O(1). Insertion is stable, and is really useful in small data sets. 

It is very likely that you will be asked questions about what insertion sort is, and how it compares across other sorts. You will want to know how it differs from the rest of the simple sorts and potentially why quick or merge sort may be a better option. Be educated. Know your sorts. 

