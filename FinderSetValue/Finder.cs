using System.Collections.Generic;

namespace FinderSetValue
{
    public class Finder
    {
        public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            if (list == null || list.Count == 0)
            {
                start = end = 0;
                return;
            }
            
            start = 0;
            end = 1;
            ulong partialSum = list[0];

            while (end != list.Count || partialSum >= sum)
            {
                if (partialSum == sum)
                    return;

                if (partialSum < sum)
                {
                    partialSum += list[end];
                    end++;
                    continue;
                }

                partialSum -= list[start];
                start++;
            }

            start = end = 0;
        }
    }
}