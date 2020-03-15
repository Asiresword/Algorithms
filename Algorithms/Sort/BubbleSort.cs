using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public class BubbleSort
    {
        public static void Sort(List<int> ListToSort)
        {
            for (int write = 0; write < ListToSort.Count; write++)
            {
                int temp = 0;
                for (int sort = 0; sort < ListToSort.Count - 1; sort++)
                {
                    if (ListToSort[sort] > ListToSort[sort + 1])
                    {
                        temp = ListToSort[sort + 1];
                        ListToSort[sort + 1] = ListToSort[sort];
                        ListToSort[sort] = temp;
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
