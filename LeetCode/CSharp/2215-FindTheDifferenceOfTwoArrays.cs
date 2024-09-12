﻿using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2215 : IRunProgram
{
    public void Run()
    {
        FindDifference([1, 2, 3], [2, 4, 6]).Print();
    }

    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        return new List<IList<int>>() { set1.Except(set2).ToList(), set2.Except(set1).ToList() };
    }
}
