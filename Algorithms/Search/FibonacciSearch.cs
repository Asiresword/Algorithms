using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class FibonacciSearch
    {
        public static int Find(List<int> ListToFind, int Key)
        {
            int FibMM2 = 0;
            int FibMM1 = 1;
            int FibM = FibMM2 + FibMM1;

            while (FibM < ListToFind.Count)
            {
                FibMM2 = FibMM1;
                FibMM1 = FibM;
                FibM = FibMM2 + FibMM1;
            }

            int offset = -1;

            while (FibM > 1)
            {
                int i = Math.Min(offset + FibMM2, ListToFind.Count - 1);

                if (ListToFind[i] < Key)
                {
                    FibM = FibMM1;
                    FibMM1 = FibMM2;
                    FibMM2 = FibM - FibMM1;
                    offset = i;
                }

                else if (ListToFind[i] > Key)
                {
                    FibM = FibMM2;
                    FibMM1 = FibMM1 - FibMM2;
                    FibMM2 = FibM - FibMM1;
                }

                else
                {
                    return i;
                }
            }

            if (FibMM1 == 1 && ListToFind[offset + 1] == Key)
            {
                return offset + 1;
            }

            return -1;
        }
    }
}
