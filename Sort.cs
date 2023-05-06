using System;

namespace Algoritms;

public class Algoritm
{
    public static void InsertionSort<T>(T[] arr)
            where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                T key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }
}