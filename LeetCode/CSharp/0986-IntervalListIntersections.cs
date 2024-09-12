using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0986: IRunProgram
    {
        public void Run()
        {
            IntervalIntersection([[0, 2], [5, 10], [13, 23], [24, 25]], [[1, 5], [8, 12], [15, 24], [25, 26]]).Print();
        }

        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            (int[][] small, int[][] large) = firstList.Length < secondList.Length
                ? (firstList, secondList)
                : (secondList, firstList);

            if (small.Length == 0)
            {
                return [];
            }

            int smallIndex = 0, largeIndex = 0;
            var output = new List<int[]>();
            while (largeIndex < large.Length && smallIndex < small.Length)
            {
                int startSmall = small[smallIndex][0], endSmall = small[smallIndex][1];
                int startLarge = large[largeIndex][0], endLarge = large[largeIndex][1];

                int start = Math.Max(startSmall, startLarge);
                int end = Math.Min(endSmall, endLarge);

                if (start <= end)
                {
                    output.Add([start, end]);
                }

                if (endSmall < endLarge)
                {
                    smallIndex++;
                }
                else
                {
                    largeIndex++;
                }
            }

            return output.ToArray();
        }
    }
}
