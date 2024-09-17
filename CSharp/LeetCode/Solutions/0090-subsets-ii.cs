using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0090 : IRunProgram
{
    public void Run()
    {
        
    }

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> output = new List<IList<int>>();
        Backtrack(output, [], nums, 0);
        return output;
    }

    private void Backtrack(List<IList<int>> output, List<int> current, int[] nums, int index)
    {
        output.Add(new List<int>(current));

        for (int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            Backtrack(output, current, nums, i + 1);
            current.RemoveAt(current.Count - 1);
            while (i + 1 < nums.Length && nums[i] == nums[i + 1]) i++;
        }
    }
}
