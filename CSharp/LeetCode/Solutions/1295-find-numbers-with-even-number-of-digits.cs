using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1295: IRunProgram
{
    public void Run()
    {

    }

    public int FindNumbers(int[] nums) 
    {
        static bool is_even(int num)
        {
            int res = 0;
            for (; num > 0;res++)
                num /= 10;
            return (res & 1) == 0;
        }
        
        int res = 0;
        foreach (int num in nums)
            if (is_even(num)) res++;

        return res;
    }
}
