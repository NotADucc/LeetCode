using LeetCode.Shared;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LeetCode.CSharp;

internal class Solution0055 : IRunProgram
{
    public void Run()
    {
        CanJump([1, 1, 1, 1, 1]).Print();
        CanJump([2, 3, 1, 1, 4]).Print();
        CanJump([3, 2, 1, 0, 4]).Print();
        CanJump([0, 2, 1, 0, 4]).Print();
    }

    public bool CanJump(int[] nums)
    {
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (max < i)
            {
                return false;
            }

            max = Math.Max(max, i + nums[i]);
        }
        return true;
    }
}
