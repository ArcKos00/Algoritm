The Binary Sort Algoritm O(n*log(n))

This algorithm sorts the array "arr" using binary search to find the insertion point of each new element. The Array.BinarySearch() method is used to find the position at which to insert a new element into the sorted array. If an element is already present in the array, the method will return its position, but we want to add a new element, so we move the position to the next element if a duplicate is found.

This algorithm has O(n*log(n)) complexity because it involves searching for the insertion point for each element, which is performed using a binary search.