using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0202 : IRunProgram
{
    public void Run()
    {
        IsHappy(19).Print();
        IsHappy(2).Print();
    }
    public bool IsHappy(int n)
    {
        var set = new HashSet<int>();

        while (n != 1)
        {
            n = Calc(n);
            if (!set.Add(n))
            {
                return false;
            }
        }

        return true;
    }

    private int Calc(int input)
    {
        int output = 0;

        while (input > 0)
        {
            int temp = input % 10;
            input /= 10;
            output += temp * temp;
        }

        return output;
    }
}
