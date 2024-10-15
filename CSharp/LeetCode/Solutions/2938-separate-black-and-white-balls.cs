using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2938 : IRunProgram
{
    public void Run()
    {

    }

    public long MinimumSteps(string s)
    {
        // white = 0
        // black = 1
        int left = 0, right = s.Length - 1;
        long swaps = 0;


        while (left < right)
        {
            if (s[left] == '0')
            {
                left++;
            }
            else
            {
                if (s[right] == '0')
                {
                    swaps += right - left;
                    left++;
                }
                right--;
            }
        }

        return swaps;
    }
}
