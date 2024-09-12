using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0350 : IRunProgram
{
    public void Run()
    {
        Intersect([1, 2, 2, 1], [2, 2]).Print();
    }

    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Span<int> span = stackalloc int[1001];
        var output = new List<int>();
        foreach (var num in nums1)
        {
            span[num]++;
        }

        foreach (var num in nums2)
        {
            if (span[num] > 0)
            {
                span[num]--;
                output.Add(num);
            }
        }

        return output.ToArray();
    }
}
