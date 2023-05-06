The Quick Sort Algoritm O(n*log n)

The QuickSort algorithm is one of the most effective sorting algorithms. It is based on the divide-and-conquer method, that is, it breaks the input array into smaller subarrays, sorts them separately, and then merges the sorted subarrays into a single sorted array.

The algorithm works as follows: an element of the array, called a pivot, is selected, then all other elements of the array are compared to it. Elements that are smaller than the supporting element are placed to the left of it, and those that are larger are to the right. The algorithm then recursively sorts the left and right parts of the array using the same sorting algorithm.

For example, if we have to sort the array of numbers [3, 6, 1, 8, 4, 7, 2, 5], we can choose the reference element 4. After comparing all elements of the array with it, we will get two subarrays: [3, 1, 2 ] and [6, 8, 7, 5]. Then we recursively sort these two subarrays again using the quick sort algorithm. When both subarrays are sorted, we insert the reference element 4 to the left of the subarray with smaller elements, and the resulting array looks like this: [3, 1, 2, 4, 6, 8, 7, 5].

A fast sort algorithm has an average complexity of O(n*log n), but can reach O(n^2) complexity in the worst case. The worst case occurs when a reference element is selected