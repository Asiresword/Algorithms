using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public static class CombSort
    {
        public static void Sort(List<int> ListToSort)
        {
            double Gap = ListToSort.Count;
            bool Swap = true;

            while (Gap > 1 || Swap)
            {
                Gap /= 1.247330950103979;

                if (Gap < 1)
                {
                    Gap = 1;
                }

                int i = 0;
                Swap = false;

                while (i + Gap < ListToSort.Count)
                {
                    int igap = i + (int)Gap;

                    if (ListToSort[i] > ListToSort[igap])
                    {
                        int temp = ListToSort[i];
                        ListToSort[i] = ListToSort[igap];
                        ListToSort[igap] = temp;
                        Swap = true;
                    }
                    ++i;
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
