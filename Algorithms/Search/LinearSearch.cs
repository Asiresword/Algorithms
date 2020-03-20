using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class LinearSearch
    {
        public static int Find(List<int> ListToFind, int Key)
        {
            for(int i = 0; i < ListToFind.Count; i++)
            {
                if(ListToFind[i] == Key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
