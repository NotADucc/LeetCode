using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2206: IRunProgram
{
    public void Run()
    {

    }

    public bool DivideArray(int[] nums)
    {
        var freq = new HashSet<int>();
        var n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            int num = nums[i];
            if (!freq.Remove(num))
                freq.Add(num);
        }
        return freq.Count == 0;
    }
}
