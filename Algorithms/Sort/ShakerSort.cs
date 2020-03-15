using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public static class ShakerSort
    {
        public static void Sort(List<int> ListToSort)
        {
            for (var i = 0; i < ListToSort.Count / 2; i++)
            {
                int temp = 0;
                var swapFlag = false;
                for (var j = i; j < ListToSort.Count - i - 1; j++)
                {
                    if (ListToSort[j] > ListToSort[j + 1])
                    {
                        temp = ListToSort[j + 1];
                        ListToSort[j + 1] = ListToSort[j];
                        ListToSort[j] = temp;
                        swapFlag = true;
                    }
                }
                for (var j = ListToSort.Count - 2 - i; j > i; j--)
                {
                    if (ListToSort[j - 1] > ListToSort[j])
                    {
                        temp = ListToSort[j - 1];
                        ListToSort[j - 1] = ListToSort[j];
                        ListToSort[j] = temp;
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }

            foreach(int Sorted in ListToSort)
            {
                Console.Write($"{Sorted} ");
            }
            Console.WriteLine();
        }
    }
}
