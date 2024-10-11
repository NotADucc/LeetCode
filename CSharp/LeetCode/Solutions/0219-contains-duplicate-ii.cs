using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0219 : IRunProgram
{
    public void Run()
    {
        ContainsNearbyDuplicate([1, 2, 3, 1], 3).Print();
    }

    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        // key is value
        // value is index
        var dct = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dct.TryGetValue(nums[i], out int last_index))
            {
                if (i - last_index <= k) return true;
            }
            dct[nums[i]] = i;
        }

        return false;
    }
}
