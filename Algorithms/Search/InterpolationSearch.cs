using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class InterpolationSearch
    {
        public static int Find(List<int> ListToFind, int Key)
        {
            int Low = 0;
            int High = ListToFind.Count - 1;

            while (Low <= High && Key >= ListToFind[Low] && Key <= ListToFind[High])
            {
                if (Low == High)
                {
                    if (ListToFind[Low] == Key)
                    {
                        return Low;
                    }
                    return -1;
                }

                int Position = Low + (((High - Low) / (ListToFind[High] - ListToFind[Low])) * (Key - ListToFind[Low]));

                if (ListToFind[Position] == Key)
                {
                    return Position;
                }


                if (ListToFind[Position] < Key)
                {
                    Low = Position + 1;
                }
                else
                {
                    High = Position - 1;
                }
            }
            return -1;
        }
    }
}
