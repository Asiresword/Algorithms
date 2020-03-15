using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public class BubbleSort
    {
        public static void Sort(List<int> ListToSort)
        {
            for (int i = 0; i < ListToSort.Count; i++)
            {
                int temp = 0;
                for (int j = 0; j < ListToSort.Count - 1; j++)
                {
                    if (ListToSort[j] > ListToSort[j + 1])
                    {
                        temp = ListToSort[j + 1];
                        ListToSort[j + 1] = ListToSort[j];
                        ListToSort[j] = temp;
                    }
                }
            }


            foreach (int Sorted in ListToSort)
            {
                Console.Write($"{Sorted} ");
            }
            Console.WriteLine();
        }
    }
}
