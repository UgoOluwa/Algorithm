using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class BinarySearch
    {
        public static int BinarySearchDisplay(int[] arr, int item)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;
            Array.Sort(arr);
            if (arr[0].Equals(item))
                return minNum;
            else if (arr[maxNum].Equals(item))
                return maxNum;
            else
            {
                while (minNum <= maxNum)
                {
                    int mid = (minNum + maxNum) / 2;
                    if (item.Equals(arr[mid]))
                    {
                        return mid;
                    }
                    else if (item < arr[mid])
                    {
                        maxNum = mid - 1;
                    }
                    else
                    {
                        minNum = mid + 1;
                    }
                }

                return -1;
            }
        }
    }
}
