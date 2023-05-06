using System;

namespace Algoritms;

public class Algoritm
{
    static void ShellSort<T>(T[] arr)
    {
        int n = arr.Length;
        int gap = n / 2;

        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                var temp = arr[i];
                int j = i;

                while (j >= gap && arr[j - gap].CompareTo(temp) > 0)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }

                arr[j] = temp;
            }

            gap /= 2;
        }
    }
}