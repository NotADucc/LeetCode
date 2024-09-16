using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2161 : IRunProgram
{
    public void Run()
    {
        PivotArray([9, 12, 5, 10, 14, 3, 10], 10).Print();
    }

    public int[] PivotArray(int[] nums, int pivot)
    {
        var small = new List<int>();
        var big = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > pivot)
            {
                big.Add(nums[i]);
            }
            else if (nums[i] == pivot) { }
            else
            {
                small.Add(nums[i]);
            }
        }

        small.AddRange(new int[nums.Length - (small.Count + big.Count)].Select(x => pivot));
        small.AddRange(big);

        return small.ToArray();
    }
}
