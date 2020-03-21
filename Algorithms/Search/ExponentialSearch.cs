using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class ExponentialSearch
    {
        public static int Find(List<int> ListToFind, int Key)
        {
            if (ListToFind[0] == Key)
            {
                return 0;
            }

            int i = 1;
            while (i < ListToFind.Count && ListToFind[i] <= Key)
            {
                i = i * 2;
            }

            return InnerBinarySearch(ListToFind, i / 2,
                               Math.Min(i, ListToFind.Count), Key);
        }

        private static int InnerBinarySearch(List<int> ListToFind, int Left, int Right, int Key)
        {
            if (Right >= Left)
            {
                int mid = Left + (Right - Left) / 2;

                if (ListToFind[mid] == Key)
                {
                    return mid;
                }

                if (ListToFind[mid] > Key)
                {
                    return InnerBinarySearch(ListToFind, Left, mid - 1, Key);
                }

                return InnerBinarySearch(ListToFind, mid + 1, Right, Key);
            }

            return -1;
        }
    }
}
