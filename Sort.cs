using System;

namespace Algoritms;

public class Algoritm
{
    public static void BinarySort<T>(T[] arr)
        where T: IComparable<T>
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var key = arr[i];
                int j = i - 1;
                int pos = Array.BinarySearch(arr, 0, i, key);

                if (pos < 0)
                {
                    pos = ~pos;
                }

                while (j >= pos)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
}