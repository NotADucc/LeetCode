using LeetCode.Solutions.Shared;
using System.Text.RegularExpressions;

namespace LeetCode.Solutions;

internal class Solution0125 : IRunProgram
{
    public void Run()
    {
        IsPalindrome("A man, a plan, a canal: Panama").Print();
        IsPalindrome("A man").Print();
        IsPalindrome("race a car").Print();
        IsPalindrome(" ").Print();
    }
    public bool IsPalindrome(string s)
    {
        Regex sp = new Regex(@"[^a-zA-Z0-9]+");
        s = sp.Replace(s.ToLower(), string.Empty);
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (!s[i].Equals(s[^(i + 1)]))
            {
                return false;
            }
        }
        return true;
    }
}
