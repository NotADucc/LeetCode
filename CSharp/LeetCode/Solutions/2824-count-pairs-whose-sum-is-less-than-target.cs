using LeetCode.Solutions.Shared;


namespace LeetCode.Solutions;

internal class Solution2824 : IRunProgram
{
    public void Run()
    {
        CountPairs([-1, 1, 2, 3, 1], 2).Print();
    }

    public int CountPairs(IList<int> nums, int target)
    {
        var numList = nums as List<int>;

        numList.Sort();

        int count = 0;

        int left = 0;
        int right = numList.Count - 1;

        while (left < numList.Count)
        {
            if (numList[left] + numList[right] < target)
            {
                count += right - left;

                left++;
                right = numList.Count - 1;
            }
            else
            {
                if (left >= right)
                {
                    left++;
                    right = numList.Count - 1;
                }
                else
                {
                    right--;
                }
            }
        }

        return count;
    }
}
