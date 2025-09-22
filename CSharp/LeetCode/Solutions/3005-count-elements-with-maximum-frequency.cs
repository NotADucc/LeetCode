using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3005 : IRunProgram
{
    public void Run()
    {
        
    }

    public int MaxFrequencyElements(int[] nums) 
	{
        Span<int> freq = stackalloc int[101];
        int max = 0, res = 0;
        foreach (int num in nums)
        {
            max = Math.Max(max, ++freq[num]);
        }
        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] == max)
                res += max;
        }
        return res;
    }
}
