using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0088 : IRunProgram
{
    public void Run()
    {
        Merge([1, 2, 3, 0, 0, 0], 3, [1, 2, 3], 3);
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0) { return; }
        for (int i = 0; i < nums2.Length; i++)
        {
            nums1[m + i] = nums2[i];
        }


        Array.Sort(nums1);
    }
}
