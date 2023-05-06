using System;

namespace Algoritms;

public class Algoritm
{
    public static void MergeSort<T>(T[] arr, int left, int right)
        where T : IComparable<T>
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);

            var temp = new T[arr.Length];

            for (int i = left; i<= right; i++)
            {
                temp[i] = arr[i];
            }

            int i = left;
            int j = middle + 1;
            int k = left;
            
            while (i <= middle && j <= right)
            {
                if (temp[i].CompareTo(temp[j]) <= 0)
                {
                    arr[k] = temp[i];
                    i++;
                }
                else
                {
                    arr[k] = temp[j];
                    j++;
                }

                k++;
            }

            while (i <= middle)
            {
                arr[k] = temp[i];
                k++;
                i++;
            }
        }
    }
}