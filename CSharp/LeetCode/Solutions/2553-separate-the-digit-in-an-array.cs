using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2553 : IRunProgram
{
    public void Run()
    {
        SeparateDigits([13, 25, 83, 77]).Print();
    }

    public int[] SeparateDigits(int[] nums)
    {
        var output = new List<int>();
        int list_index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int add = 0;
            while (nums[i] > 0)
            {
                output.Insert(list_index, nums[i] % 10);
                nums[i] /= 10;
                add++;
            }
            list_index += add;
        }

        return output.ToArray();
    }
}
