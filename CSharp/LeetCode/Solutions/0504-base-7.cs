using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0504 : IRunProgram
{
    public void Run()
    {

    }

    public string ConvertToBase7(int num)
    {
        if (num == 0)
            return "0";

        string ans = string.Empty;
        bool is_negative = num < 0;
        num = Math.Abs(num);

        while (num != 0)
        {
            ans = $"{num % 7}{ans}";
            num /= 7;
        }

        if (is_negative)
            ans = $"-{ans}";

        return ans;
    }
}
