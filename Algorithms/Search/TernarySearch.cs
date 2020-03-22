using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class TernarySearch
    {
        private static int Find(List<int> ListToFind, int Left, int Right, int Key)
        {
            if (Right >= Left)
            {
                int mid1 = Left + (Right - Left) / 3;
                int mid2 = Right - (Right - Left) / 3;

                if (ListToFind[mid1] == Key)
                {
                    return mid1;
                }
                if (ListToFind[mid2] == Key)
                {
                    return mid2;
                }

                if (Key < ListToFind[mid1])
                {
                    return Find(ListToFind, Left, mid1 - 1, Key);
                }
                else if (Key > ListToFind[mid2])
                {
                    return Find(ListToFind, mid2 + 1, Right, Key);
                }
                else
                {
                    return Find(ListToFind, mid1 + 1, mid2 - 1, Key);
                }
            }

            return -1;
        }
        public static int Find(List<int> ListToFind, int Key)
        {
            int Left = 0;
            int Right = ListToFind.Count;

            if (Right >= Left)
            {
                int mid1 = Left + (Right - Left) / 3;
                int mid2 = Right - (Right - Left) / 3;

                if (ListToFind[mid1] == Key)
                {
                    return mid1;
                }
                if (ListToFind[mid2] == Key)
                {
                    return mid2;
                }

                if (Key < ListToFind[mid1])
                {
                    return Find(ListToFind, Left, mid1 - 1, Key);
                }
                else if (Key > ListToFind[mid2])
                {
                    return Find(ListToFind, mid2 + 1, Right, Key);
                }
                else
                {
                    return Find(ListToFind, mid1 + 1, mid2 - 1, Key);
                }
            }

            return -1;
        }
    }
}
