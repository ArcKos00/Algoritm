using System;

namespace Algoritms;

public class Algoritm
{
    public static void CoctailShakeSort<T>(T[] arr)
    {
        var swapped = true;
        int start = 0;
        int end = arr.Length - 1;
    
        while (swapped)
        {
            swapped = false;
    
            for (int i = start; i < end; ++i)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }
    
            if (!swapped)
            {
                break;
            }
    
            swapped = false;
    
            for (int i = end - 1; i >= start; --i)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }
    
            end--;
        }
    }
}