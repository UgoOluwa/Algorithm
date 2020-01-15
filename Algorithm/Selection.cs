using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Selection
    {
        public static string SelectionSort(int[] arr)
        {
            int minIndex = 0;
            int minNumber = 0;
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                minNumber = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = minNumber;
            }
            StringBuilder sb = new StringBuilder(50);
            foreach (var item in arr)
            {

                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}



