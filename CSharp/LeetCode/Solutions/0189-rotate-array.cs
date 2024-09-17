using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0189 : IRunProgram
{
    public void Run()
    {

    }

    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        int end = nums.Length - k;
        int[] arr = [.. nums[end..], .. nums[..end]];
        Array.Copy(arr, nums, arr.Length);
    }
}
