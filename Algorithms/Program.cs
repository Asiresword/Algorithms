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
            /*
                Big O notation is a mathematical notation that describes 
                the limiting behavior of a function when the argument tends towards a particular value or infinity. 
            */

            List<int> ListToSort = new List<int>();
            Random rand = new Random();
            for(int i = 0; i < rand.Next(5, 20); i++)
            {
                ListToSort.Add(rand.Next(-100, 100));
            }

            #region Sorting algorithms

            #region Bubble Sort
            /*
                Bubble sort - one of the simplest sorting algorithms, which works by repeatedly swapping the adjacent elements.
                    Best computational complexity: O(n²)
                    Average computational complexity: O(n²)
                    Worst computational complexity: O(n²)
            */
            BubbleSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Shaker Sort
            /*
                Shaker sort/Cocktail sort - variation of bubble sorting algorithm. Unlike bubble sort, it orders array in both directions.
                    Best computational complexity: O(n)
                    Average computational complexity: O(n²)
                    Worst computational complexity: O(n²)
            */
            ShakerSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Comb Sort
            /*
                Comb sort - variation of bubble sort algorithm. It uses gap of size more than 1, 
                            which starts with a large value and shrinks by a factor of 1.3 in every iteration until it reaches the value 1.
                    Best computational complexity: O(n log n)
                    Average computational complexity: O(n²)
                    Worst computational complexity: O(n²)
            */
            CombSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Insertion Sort
            /*
                Insertion sort - a sorting algorithm in which the elements are transferred one at a time to the right position.
                    Best computational complexity: O(n)
                    Average computational complexity: O(n²)
                    Worst computational complexity: O(n²)
            */
            InsertionSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Shell Sort
            /*
                Shell sort - variation of insertion sorting algorithm. It sorting pairs of elements far apart from each other, 
                             then progressively reducing the gap between elements to be compared.
                    Best computational complexity: O(n log n)
                    Average computational complexity: O(n²)
                    Worst computational complexity: O(n²)
            */
            ShellSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Gnome Sort
            /*
                Gnome sort - one of the simplest sorting algorithms, finds the first place 
                             where two adjacent elements are in the wrong order and swaps them.
                    Best computational complexity: O(n)
                    Average computational complexity: O(n²)
                    Worst computational complexity: O(n²)
            */
            GnomeSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Selection Sort
            /*
                Selection sort - works by repeatedly finding the minimum element from unsorted part and putting it at the beginning.
                    Best computational complexity: O(n)
                    Average computational complexity: O(n²)
                    Worst computational complexity: O(n²)
            */
            SelectionSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Heap Sort
            /*
                Heap sort - works by repeatedly finding the maximum element from unsorted part and putting it at the end.
                    Best computational complexity: O(n log n)
                    Average computational complexity: O(n log n)
                    Worst computational complexity: O(n log n)
            */
            HeapSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Quick Sort
            /*
                Quick sort - works by picking an element as pivot and partitions the given array around the picked pivot.
                    Best computational complexity: O(n)
                    Average computational complexity: O(n log n)
                    Worst computational complexity: O(n²)
            */
            QuickSort.Sort(ListToSort);
            #endregion

            Separator();

            #region Merge Sort
            /*
                Merge sort - works by dividing input container in two halves, calls itself for the two halves 
                             and then merges the two sorted halves.
                    Best computational complexity: O(n)
                    Average computational complexity: O(n log n)
                    Worst computational complexity: O(n log n)
            */
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
            /*
                Linear search - one of the simplest searching algorithms, which works by sequentially checking
                                each element of the list until a match is found or the whole list has been searched.
                    Best computational complexity: O(1)
                    Average computational complexity: O(n)
                    Worst computational complexity: O(n)
            */
            Console.WriteLine(LinearSearch.Find(ListToFind, 6));
            #endregion

            Separator();

            #region Binary search
            /*
                Binary search - works by comparing the target value to the middle element of the container.
                    Best computational complexity: O(1)
                    Average computational complexity: O(log n)
                    Worst computational complexity: O(log n)
            */
            Console.WriteLine(BinarySearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Jump search
            /*
                Jump search - works by jumping ahead by fixed steps or skipping some elements in place of searching all elements.
                    Best computational complexity: O(1)
                    Average computational complexity: O(log n)
                    Worst computational complexity: O(log n)
            */
            Console.WriteLine(JumpSearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Interpolation search
            /*
                Interpolation search - variation of binary search. Works just like binary search, but can start from any position.
                    Best computational complexity: O(1)
                    Average computational complexity: O(log n)
                    Worst computational complexity: O(n)
            */
            Console.WriteLine(InterpolationSearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Exponential search
            /*
                Exponential search - works by searching a range, where is element may be present 
                                     and then uses a binary search within this range.
                    Best computational complexity: O(1)
                    Average computational complexity: O(log n)
                    Worst computational complexity: O(log n)
            */
            Console.WriteLine(ExponentialSearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Fibonacci search
            /*
                Fibonacci search - works by finding the smallest fibonacci number greater or equal to container size and then searching value within it.
                    Best computational complexity: O(1)
                    Average computational complexity: O(log n)
                    Worst computational complexity: O(log n)
            */
            Console.WriteLine(FibonacciSearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Recursive search
            /*
                Recursive search - works by recursively passing through the container.
                    Best computational complexity: O(1)
                    Average computational complexity: O(log n)
                    Worst computational complexity: O(log n)
            */
            Console.WriteLine(RecursiveSearch.Find(ListToFind, 6));
            #endregion

            Separator();

            #region Ternary search
            /*
                Ternary search - works by dividing container into 3 parts and determine which has the key. Then recursively search for an index.
                    Best computational complexity: O(1)
                    Average computational complexity: O(log n)
                    Worst computational complexity: O(log n)
            */
            Console.WriteLine(TernarySearch.Find(SortedList, 3));
            #endregion

            Separator();

            #region Ubiquitous binary search
            Console.WriteLine(UbiquitousBinarySearch.Find(SortedList, 3));
            #endregion

            Separator();

            #endregion
        }
    }
}
