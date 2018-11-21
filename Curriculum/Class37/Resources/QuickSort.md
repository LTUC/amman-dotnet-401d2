# Quicksort

Quick sort is a "Divide and Conquer" algorithm. It picks an element as a "pivot" and partitions the given array around the pivot that was picked. 

The way we pick the pivot varies. The pivot can be the first element, last element, random element, or medium element. Where you decide to pick your pivot may take an effect on your efficiency. 

The most important part of the quicksort is the `Partition()`. This is the determining point that will start the sort off. At the very end of the sort, the partition will stay in it's original location. 

In a quick sort, which is different than a merge sort, we still use smaller arrays to sort the values on each side of the partition. The biggest difference between the two is that there is no combining of the values that have been divided. 



## Algorithm
1. Create a partition
2. Sort the left
3. Sort the right

Looking a bit closer, we want to utilize the partition so that any value less than the partition is on the left, and any value larger is on the right. 
The algorithm will scan from left to right, skipping over the smaller numbers (since we want those to stay on the left), and stopping at the larger numbers to swap them to the other half. The same is true for the right to left, it will skip over larger numbers (since we want those to stay on the right), and stop on the smaller numbers prepping it to be swapped to the other side. 



## Time and Effeciency

The Big O of a quick sort will be 

*Average:(O Theta):* O (n log n)

*Worst: (Big O)*: O(n^2) 

*Best: (O Mega):* O(n log n)

Space, using recursion, will be O(n). 

