The Heap Sort Algoritms O(n*log n)

Heap Sort is an efficient sorting algorithm that uses the heap data structure. Heap sorting works in O(n * log n) time, where n is the size of the array.

The essence of the algorithm is that the array is turned into a heap (a binary tree in which each node is greater than or equal to its child nodes) and the maximum element is removed from it. After that, the maximum element is inserted into the sorted part of the array, and the rest of the array is turned into a heap again and the process is repeated until all elements are sorted.