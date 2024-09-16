using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0258 : IRunProgram
{
    public void Run()
    {
        AddDigits(38).Print();
        AddDigits(0).Print();
        AddDigits(41).Print();
    }

    public int AddDigits(int num)
    {
        int output = 0;
        while (num > 0)
        {
            output += num % 10;
            num /= 10;

            if (num == 0 && output >= 10)
            {
                num = output;
                output = 0;
            }
        }
        return output;
    }
}
