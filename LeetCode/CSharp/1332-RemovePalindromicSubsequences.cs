using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1332 : IRunProgram
{
    public void Run()
    {
        RemovePalindromeSub("ababa").Print();
    }
    public int RemovePalindromeSub(string s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return 2;
            }
            left++;
            right--;
        }

        return 1;
    }
}
