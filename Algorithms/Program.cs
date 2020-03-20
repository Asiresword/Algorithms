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

            #region Searching algorithms

            #region Linear search
            Console.WriteLine(LinearSearch.Find(ListToFind, 6));
            #endregion

            Separator();

            #region Binary search
            // For binary search - we need a sorted container.
            List<int> BinarySorted = new List<int>(ListToFind);
            BinarySorted.Sort();
            Console.WriteLine(BinarySearch.Find(BinarySorted, 3));
            #endregion

            #endregion
        }
    }
}
