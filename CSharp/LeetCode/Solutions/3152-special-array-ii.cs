using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3152 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool[] IsArraySpecial(int[] nums, int[][] queries)
    {
        bool IsEvenParity(int num1, int num2) => (num1 & 1) == (num2 & 1);
        int[] temp = new int[nums.Length];
        var res = new bool[queries.Length];

        for (int i = 1; i < nums.Length; i++)
        {
            temp[i] = temp[i - 1];
            if (IsEvenParity(nums[i - 1], nums[i]))
            {
                temp[i]++;
            }
        }

        for (int i = 0; i < queries.Length; i++)
        {
            int start = queries[i][0];
            int end = queries[i][1];
            int cnt = temp[end] - temp[start];
            res[i] = cnt == 0;
        }

        return res;
    }
}
