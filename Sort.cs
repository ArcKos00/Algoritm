using System;

namespace Algoritms;

public class Algoritm
{
    public static void HeapSort<T>(T[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        for (int i = n - 1; i >= 0; i--)
        {
            var temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }

    public void Heapify<T>(T[] arr, int n, int i)
        where T : IComparable<T>
    {
        int largest = i;
        int l = 2 * i + 1;
        int r = 2 * i + 2;

        if (l < n && arr[l].CompareTo(arr[largest]) > 0)
        {
            largest = l;
        }

        if (r < n && arr[r].CompareTo(arr[largest]) > 0)
        {
            largest = r;
        }

        if (largest != i)
        {
            var temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            Heapify(arr, n, largest);
        }
    }
}