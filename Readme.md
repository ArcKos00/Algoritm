The Insertion Sort Algoritm O(n^2)

This algorithm sorts the array "arr" using insertion sort. The algorithm goes through the array and for each element finds a place to insert into the sorted part of the array.

At the beginning of the algorithm, the sorted part of the array consists of the first element. The algorithm then selects the next element from the unsorted part of the array and finds an insertion point for it in the sorted part. A loop is used to find the insertion point, which shifts all elements larger than the key one position to the right. After the insertion point is found, the key is inserted into its position.

This algorithm has a complexity of O(n^2), since for each element of the array it is necessary to go through the sorted part of the array in search of the insertion point. But for small arrays, this algorithm can be faster than algorithms with O(n*log(n)) complexity, such as the binary sort algorithm.