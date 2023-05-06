The Selection Sort Algoritm O(n^2)

This algorithm sorts the array "arr" using selection sort. The algorithm traverses the array and for each element finds the minimum element in the unsorted part of the array.

At the beginning of the algorithm, the unsorted part of the array consists of the entire array. The algorithm then finds the minimum element in the unsorted part of the array and swaps it with the first element in the unsorted part. After that, the first element becomes part of the sorted part of the array and the rest of the array becomes unsorted. The algorithm is repeated for the unsorted part of the array until the entire array is sorted.

This algorithm has a complexity of O(n^2), since for each element of the array it is necessary to go through the entire unsorted part of the array in search of the minimum element. But for small arrays, this algorithm can be faster than algorithms with O(n*log(n)) complexity, such as the binary sort algorithm.