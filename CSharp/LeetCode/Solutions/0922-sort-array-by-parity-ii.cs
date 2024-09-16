using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0922: IRunProgram
{
    public void Run()
    {
        SortArrayByParityII([4, 2, 5, 7]).Print();
    }
    public int[] SortArrayByParityII(int[] nums)
    {
        int even = 0, odd = 1;
        var output = new int[nums.Length];
        foreach (var num in nums)
        {
            if (IsEven(num))
            {
                output[even] = num;
                even += 2;
            }
            else
            {
                output[odd] = num;
                odd += 2;
            }
        }

        return output;
    }

    public bool IsEven(int input) => (input & 1) == 0;
}
