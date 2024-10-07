using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0047 : IRunProgram
{
    public void Run()
    {
        PermuteUnique([1, 2, 2, 2, 3]).PrintNested();
        PermuteUnique([0, 1, 1]).PrintNested();
        PermuteUnique([0]).PrintNested();
    }

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);
        var output = new List<IList<int>>();
        Backtrack(output, nums.ToList(), []);
        return output;
    }

    private void Backtrack(List<IList<int>> output, List<int> nums, List<int> current)
    {
        if (nums.Count == 0)
        {
            output.Add(new List<int>(current));
        }
        else
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int num = nums[i];
                current.Add(num);
                nums.Remove(num);
                Backtrack(output, nums, current);
                nums.Insert(i, num);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
