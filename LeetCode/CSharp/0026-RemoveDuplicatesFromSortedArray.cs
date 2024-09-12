using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0026: IRunProgram
{
    public void Run()
    {
        RemoveDuplicates([1, 1, 2]).Print();
        RemoveDuplicates([1, 1, 1, 2]).Print();
        RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]).Print();
    }

    public int RemoveDuplicates(int[] nums)
    {
        int trueIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[trueIndex] == nums[i])
            {
                continue;
            }
            trueIndex++;
            nums[trueIndex] = nums[i];
        }
        trueIndex++;
        return trueIndex;
    }
}
