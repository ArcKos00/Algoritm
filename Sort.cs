using System;

namespace Algoritms;

public class Algoritm
{
    public static void RingSort<T>(T[] arr)
    {
        int n = arr.Length;
        int left = 0;
        int right = n - 1;
    
        while (left < right)
        {
            int maxIndex = left;
    
            for (int i = left + 1; i <= right; i++)
            {
                if (arr[i].CompareTo(arr[maxIndex]) > 0)
                {
                    maxIndex = i;
                }
            }
    
            var temp = arr[maxIndex];
            arr[maxIndex] = arr[right];
            arr[right] = temp;
            right--;
    
            int minIndex = left;
            for (int i = left + 1; i <= right; i++)
            {
                if (arr[i].CompareTo(arr[minIndex]) < 0)
                {
                    minIndex = i;
                }
            }
    
            temp = arr[minIndex];
            arr[minIndex] = arr[left];
            arr[left] = temp;
            left++;
        }
    }
}