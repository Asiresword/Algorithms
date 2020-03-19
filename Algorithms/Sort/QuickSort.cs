using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public static class QuickSort
    {
        public static void Sort(List<int> ListToSort)
        {
            Sort(ListToSort, 0, ListToSort.Count - 1);

            foreach(int Sorted in ListToSort)
            {
                Console.Write($"{Sorted} ");
            }
            Console.WriteLine();
        }

        private static void Sort(List<int> ListToSort, int Low, int High)
        {
            if (Low < High)
            {
                int partitionIndex = Partition(ListToSort, Low, High);

                Sort(ListToSort, Low, partitionIndex - 1);
                Sort(ListToSort, partitionIndex + 1, High);
            }
        }

        private static int Partition(List<int> ListToSort, int Low, int High)
        {
            int pivot = ListToSort[High];

            int LowIndex = (Low - 1);

            for (int j = Low; j < High; j++)
            {
                if (ListToSort[j] <= pivot)
                {
                    LowIndex++;

                    int SwapTemp = ListToSort[LowIndex];
                    ListToSort[LowIndex] = ListToSort[j];
                    ListToSort[j] = SwapTemp;
                }
            }

            int Temp = ListToSort[LowIndex + 1];
            ListToSort[LowIndex + 1] = ListToSort[High];
            ListToSort[High] = Temp;

            return LowIndex + 1;
        }
    }
}
