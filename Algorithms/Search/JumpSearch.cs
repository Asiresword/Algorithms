using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public static class JumpSearch
    {
        public static int Find(List<int> ListToFind, int Key)
        {
            int Step = (int)Math.Floor(Math.Sqrt(ListToFind.Count));

            int Previous = 0;
            while (ListToFind[Math.Min(Step, ListToFind.Count) - 1] < Key)
            {
                Previous = Step;
                Step += (int)Math.Floor(Math.Sqrt(ListToFind.Count));
                if (Previous >= ListToFind.Count)
                {
                    return -1;
                }
            }

            while (ListToFind[Previous] < Key)
            {
                Previous++;
                if (Previous == Math.Min(Step, ListToFind.Count))
                {
                    return -1;
                }
            }

            if (ListToFind[Previous] == Key)
            {
                return Previous;
            }

            return -1;
        }
    }
}
