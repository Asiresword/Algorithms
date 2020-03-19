using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public static class MergeSort
    {
        public static void Sort(List<int> ListToSort)
        {
            if (ListToSort.Count <= 1)
            {
                Console.WriteLine(ListToSort[0]);
                return;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int median = ListToSort.Count / 2;
            for (int i = 0; i < median; i++)  //Dividing the unsorted list
            {
                left.Add(ListToSort[i]);
            }
            for (int i = median; i < ListToSort.Count; i++)
            {
                right.Add(ListToSort[i]);
            }

            left = Divide(left);
            right = Divide(right);
            foreach(int Sorted in Merge(left, right))
            {
                Console.Write($"{Sorted} ");
            }
            Console.WriteLine();
        }

        private static List<int> Divide(List<int> ListToSort)
        {
            if (ListToSort.Count <= 1)
            {
                return ListToSort;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int median = ListToSort.Count / 2;
            for (int i = 0; i < median; i++)
            {
                left.Add(ListToSort[i]);
            }
            for (int i = median; i < ListToSort.Count; i++)
            {
                right.Add(ListToSort[i]);
            }

            left = Divide(left);
            right = Divide(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>(); //The new collection

            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Any())
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Any())
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
