using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Bubble
    {
        public static string BubbleSort(int[] arr)
        {
            int temp;
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - (1 + i); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            string array = "";
            foreach (var item in arr)
            {

                array = array + item;
            }

            return array;
        }
    }
}
