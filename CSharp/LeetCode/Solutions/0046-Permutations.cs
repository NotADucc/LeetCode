using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0046 : IRunProgram
{
    public void Run()
    {
        Permute([1, 2, 3]).PrintNested();
        Permute([0, 1]).PrintNested();
        Permute([0]).PrintNested();
    }

    public IList<IList<int>> Permute(int[] nums)
    {
        var output = new List<IList<int>>();
        Helper(output, [], nums);
        return output;
    }

    private void Helper(List<IList<int>> output, List<int> curr, int[] nums)
    {
        if (nums.Length == 0)
        {
            output.Add(new List<int>(curr));
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                curr.Add(num);
                Helper(output, curr, nums.Where(x => x != num).ToArray());
                curr.Remove(num);
            }
        }
    }
}
