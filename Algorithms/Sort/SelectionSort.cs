using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public static class SelectionSort
    {
        public static void Sort(List<int> ListToSort)
        {
            int Temp, Smallest;
            for (int i = 0; i < ListToSort.Count - 1; i++)
            {
                Smallest = i;
                for (int j = i + 1; j < ListToSort.Count; j++)
                {
                    if (ListToSort[j] < ListToSort[Smallest])
                    {
                        Smallest = j;
                    }
                }
                Temp = ListToSort[Smallest];
                ListToSort[Smallest] = ListToSort[i];
                ListToSort[i] = Temp;
            }

            foreach (int Sorted in ListToSort)
            {
                Console.Write($"{Sorted} ");
            }
            Console.WriteLine();
        }
    }
}
