using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public static class ShellSort
    {
        public static void Sort(List<int> ListToSort)
        {
            int i, j, Pos, Temp;
            Pos = 3;
            while (Pos > 0)
            {
                for (i = 0; i < ListToSort.Count; i++)
                {
                    j = i;
                    Temp = ListToSort[i];
                    while ((j >= Pos) && (ListToSort[j - Pos] > Temp))
                    {
                        ListToSort[j] = ListToSort[j - Pos];
                        j = j - Pos;
                    }
                    ListToSort[j] = Temp;
                }

                if (Pos / 2 != 0)
                {
                    Pos = Pos / 2;
                }
                else if (Pos == 1)
                {
                    Pos = 0;
                }
                else
                {
                    Pos = 1;
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
