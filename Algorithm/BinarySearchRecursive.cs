using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BinarySearchRecursive
    {
        public static int BinarySearchDisplayRecursive(int[] arr, int item)
        {
            return BinarySearchDisplayRecursive(arr, 0, arr.Length-1, item);
        }
        public static int BinarySearchDisplayRecursive(int[] arr, int left, int right, int Item)
        {
            Array.Sort(arr);

            if (left <= right)
            {
                int mid = (left + right) / 2;
                if (Item == arr[mid])
                {
                    return mid;
                }
                if (Item < arr[mid])
                {
                    return BinarySearchDisplayRecursive(arr, left, mid - 1, Item);
                }
                
                return BinarySearchDisplayRecursive(arr, mid + 1, right, Item);
                
            }
            return -1;
        }
    }
}
