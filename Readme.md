The Shell Sort Algoritm O(n*log n)

The Shell sort algorithm (English Shell Sort) is a modification of the insertion sort algorithm, in which reducing the step between elements allows more efficient insertion of elements into the sorted part of the array.

The essence of the algorithm is that the array is divided into subarrays using a "step", which decreases with each sorting step. An insertion sort algorithm is applied to each subarray. They usually start with a large step and reduce it to 1.