using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = { 8, 2, 7, 4, 5, 66, 9 };
            Console.WriteLine(BinarySearch.BinarySearchDisplay(newArray, 9));
            //Console.WriteLine(BinarySearchRecursive.BinarySearchDisplayRecursive(newArray,9));
            Console.WriteLine(Selection.SelectionSort(newArray));
            Console.WriteLine(Bubble.BubbleSort(newArray));
        }
    }
}
