using LeetCode.Shared;

namespace LeetCode.CSharp;

public class Solution0035 : IRunProgram
{
    public void Run()
    {
        SearchInsert([1, 3, 5, 6], 8);
        SearchInsert([5, 7, 7, 8, 8, 10], 6);
        SearchInsert([], 0);
    }

    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) >> 1;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
}
