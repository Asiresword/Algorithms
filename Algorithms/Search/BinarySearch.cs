using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class BinarySearch
    {
        public static int Find(List<int> ListToFind, int Key)
        {
            int Low = 0;
            int High = ListToFind.Count - 1;
            int Middle = 0;

            while (true)
            {
                Middle = (Low + High) / 2;
                if (Key < ListToFind[Middle])
                {
                    High = Middle - 1;
                }
                else if (Key > ListToFind[Middle])
                {
                    Low = Middle + 1;
                }
                else
                {
                    return Middle;
                }

                if (Low > High)
                {
                    break;
                }
            }
            return -1;
        }
    }
}
