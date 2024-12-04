using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2825 : IRunProgram
{
    public void Run()
    {

    }

    public bool CanMakeSubsequence(string str1, string str2)
    {
        int idx1 = 0, idx2 = 0;

        while (idx1 < str1.Length && idx2 < str2.Length)
        {
            if (str1[idx1] == str2[idx2] || (str1[idx1] - 'a' + 1) % 26 == str2[idx2] - 'a')
            {
                idx2++;
            }
            idx1++;
        }

        return idx2 >= str2.Length;
    }
}
