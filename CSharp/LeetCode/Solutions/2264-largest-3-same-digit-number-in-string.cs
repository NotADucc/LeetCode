using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution2264 : IRunProgram
{
    public void Run()
    {

    }

    public string LargestGoodInteger(string num)
    {
        int n = num.Length;
        char res = '\0';

        for (int i = 0; i < n - 2; i++)
        {
            res = num[i] == num[i + 1] && num[i] == num[i + 2] && res < num[i]
                ? num[i]
                : res;
        }

        return res.Equals('\0') ? string.Empty : new string(res, 3);
    }
}
