using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0448 : IRunProgram
{
    public void Run()
    {
        FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]).Print();
        FindDisappearedNumbers([1, 1]).Print();
    }
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> output = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int num = Math.Abs(nums[i]) - 1;
            if (nums[num] > 0) nums[num] = -nums[num];
        }

        for (int i = 0; i < nums.Length; i++)
        {

        }

        Console.WriteLine(string.Join(", ", nums));

        return output;
    }

}
