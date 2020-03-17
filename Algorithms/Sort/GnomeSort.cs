using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public static class GnomeSort
    {
        public static void Sort(List<int> ListToSort)
        {
            int Index = 0;

            while (Index < ListToSort.Count)
            {
                if (Index == 0)
                {
                    Index++;
                }

                if (ListToSort[Index] >= ListToSort[Index - 1])
                {
                    Index++;
                }

                else
                {
                    int Temp = 0;
                    Temp = ListToSort[Index];
                    ListToSort[Index] = ListToSort[Index - 1];
                    ListToSort[Index - 1] = Temp;
                    Index--;
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
