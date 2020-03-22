using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class RecursiveSearch
    {
        private static int Find(List<int> ListToFind, int Left, int Right, int Key)
        {
            if (Right < Left)
            {
                return -1;
            }
            if (ListToFind[Left] == Key)
            {
                return Left;
            }
            if (ListToFind[Right] == Key)
            {
                return Right;
            }

            return Find(ListToFind, Left + 1, Right - 1, Key);
        }
        public static int Find(List<int> ListToFind, int Key)
        {
            int Left = 0;
            int Right = ListToFind.Count - 1;


            if (Right < Left)
            {
                return -1;
            }
            if (ListToFind[Left] == Key)
            {
                return Left;
            }
            if (ListToFind[Right] == Key)
            {
                return Right;
            }

            return Find(ListToFind, Left + 1, Right - 1, Key);
        }
    }
}
