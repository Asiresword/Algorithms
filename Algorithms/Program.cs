﻿using Algorithms.Sort;
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
        }
    }
}
