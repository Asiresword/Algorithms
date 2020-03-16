using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public static class InsertionSort
    {
        public static void Sort(List<int> ListToSort)
        {
            int j, Temp;
            for (int i = 1; i <= ListToSort.Count - 1; i++)
            {
                Temp = ListToSort[i];
                j = i - 1;
                while (j >= 0 && ListToSort[j] > Temp)
                {
                    ListToSort[j + 1] = ListToSort[j];
                    j--;
                }
                ListToSort[j + 1] = Temp;
            }

            foreach (int Sorted in ListToSort)
            {
                Console.Write($"{Sorted} ");
            }
            Console.WriteLine();
        }
    }
}
