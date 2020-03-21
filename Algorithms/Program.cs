using Algorithms.Search;
using Algorithms.Sort;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        private static void Separator()
        {
            Console.WriteLine(new string('-', 30));
        }

        internal static void Main()
        {
            List<int> ListToSort = new List<int>();
            Random rand = new Random();
            for(int i = 0; i < rand.Next(5, 20); i++)
            {
                ListToSort.Add(rand.Next(-100, 100));
            }

            #region Sorting algorithms

            #region Bubble Sort
            BubbleSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Shaker Sort
            ShakerSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Comb Sort
            CombSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Insertion Sort
            InsertionSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Shell Sort
            ShellSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Gnome Sort
            GnomeSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Selection Sort
            SelectionSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Heap Sort
            HeapSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Quick Sort
            QuickSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Merge Sort
            MergeSort.Sort(ListToSort);
            #endregion

            #endregion

            Separator();
            Separator();
            Separator();

            List<int> ListToFind = new List<int>();
            ListToFind.Add(1);
            ListToFind.Add(6);
            ListToFind.Add(3);
            ListToFind.Add(10);
            ListToFind.Add(7);

            // For some searching algorithms - we need a sorted container.
            List<int> SortedList = new List<int>(ListToFind);
            SortedList.Sort();

            #region Searching algorithms

            #region Linear search
            Console.WriteLine(LinearSearch.Find(ListToFind, 6));
            #endregion

            Separator();

            #region Binary search
            Console.WriteLine(BinarySearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Jump search
            Console.WriteLine(JumpSearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Interpolation search
            Console.WriteLine(InterpolationSearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Exponential search
            Console.WriteLine(ExponentialSearch.Find(SortedList, 3));
            #endregion

            Separator();

            #endregion
        }
    }
}
