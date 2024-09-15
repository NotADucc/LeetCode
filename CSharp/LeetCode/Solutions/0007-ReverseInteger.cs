using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0007 : IRunProgram
{
    public void Run()
    {
        Reverse(123).Print();
        Reverse(321).Print();
    }
    public int Reverse(int x)
    {
        int output = 0;

        while (x != 0)
        {
            int quot = x % 10;
            int temp = (output * 10) + quot;
            x = x / 10;
            if (
                output > 0 && temp < output
                || output < 0 && temp > output
                || x != 0 && temp > 214_748_365
                || x != 0 && temp < -214_748_365
            )
            {
                return 0;
            }
            output = temp;
        }

        return output;
    }
}
