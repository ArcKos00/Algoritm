using System;

namespace Algoritms;

public class Algoritm
{
    public static void QuickSort<T>(T[] arr, int left, int right)
        where T: IComparable<T>
        {
            int i = left;
            int j = right;
            var pivot = arr[(left + right) / 2];
            while (i <= j)
            {
                i++;
            }

            while (arr[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                i++;
                j--;
            }

            if (left < j)
            {
                QuickSort(arr, left, j);
            }

            if (i < right)
            {
                QuickSort(arr, i, right);
            }
        }
}