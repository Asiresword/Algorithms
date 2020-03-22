using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class UbiquitousBinarySearch
    {
        public static int Find(List<int> ListToFind, int Key)
        {
            int Low = 0;
            int High = ListToFind.Count - 1;

            while(High - Low > 1)
            {
                int Mid = Low + (High - Low) / 2;

                if (ListToFind[Mid] <= Key)
                {
                    Low = Mid;
                }
                else 
                {
                    High = Mid;
                }
            }

            if(ListToFind[Low] == Key)
            {
                return Low;
            }

            return -1;
        }
    }
}
