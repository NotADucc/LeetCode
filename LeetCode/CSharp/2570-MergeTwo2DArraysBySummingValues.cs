using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2570 : IRunProgram
    {
        public void Run()
        {
            MergeArrays([[1, 2], [2, 3], [4, 5]], [[1, 4], [3, 2], [4, 1]]).Print();
        }

        public int[][] MergeArrays(int[][] nums1, int[][] nums2)
        {
            int n1 = 0, n2 = 0;
            List<int[]> output = new List<int[]>(nums1.Length + nums2.Length);
            while (n1 < nums1.Length || n2 < nums2.Length)
            {
                if (n2 >= nums2.Length || (n1 < nums1.Length && nums1[n1][0] < nums2[n2][0]))
                {
                    output.Add([nums1[n1][0], nums1[n1][1]]);
                    n1++;
                }
                else if (n1 >= nums1.Length || (n2 < nums2.Length && nums2[n2][0] < nums1[n1][0]))
                {
                    output.Add([nums2[n2][0], nums2[n2][1]]);
                    n2++;
                }
                else
                {
                    if (nums1[n1][0] == nums2[n2][0])
                    {
                        output.Add([nums1[n1][0], nums1[n1][1] + nums2[n2][1]]);
                        n1++;
                        n2++;
                    }
                }
            }

            return output.ToArray();
        }
    }
}
