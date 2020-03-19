using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public class HeapSort
    {
        public static void Sort(List<int> ListToSort)
        {
            int ListLength = ListToSort.Count;
            for (int i = ListLength / 2 - 1; i >= 0; i--)
            {
                Heapify(ListToSort, ListLength, i);
            }
            for (int i = ListLength - 1; i >= 0; i--)
            {
                int temp = ListToSort[0];
                ListToSort[0] = ListToSort[i];
                ListToSort[i] = temp;
                Heapify(ListToSort, i, 0);
            }

            foreach (int Sorted in ListToSort)
            {
                Console.Write($"{Sorted} ");
            }
            Console.WriteLine();
        }

        private static void Heapify(List<int> ListToSort, int ListLength, int i)
        {
            int Largest = i;
            int Left = 2 * i + 1;
            int Right = 2 * i + 2;
            if (Left < ListLength && ListToSort[Left] > ListToSort[Largest])
            {
                Largest = Left;
            }
            if (Right < ListLength && ListToSort[Right] > ListToSort[Largest])
            {
                Largest = Right;
            }
            if (Largest != i)
            {
                int Temp = ListToSort[i];
                ListToSort[i] = ListToSort[Largest];
                ListToSort[Largest] = Temp;
                Heapify(ListToSort, ListLength, Largest);
            }
        }
    }
}