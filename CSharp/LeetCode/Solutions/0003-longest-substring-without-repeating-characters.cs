using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0003 : IRunProgram
{
    public void Run()
    {
        LengthOfLongestSubstring("abcabcbb").Print();
        LengthOfLongestSubstring("bbbbb").Print();
        LengthOfLongestSubstring("pwwkew").Print();
    }

    public int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<char>();
        int output = 0;
        int l = 0, r = 0;

        while (r < s.Length)
        {
            if (set.Contains(s[r]))
            {
                while (s[l] != s[r])
                {
                    set.Remove(s[l]);
                    l++;
                }
                set.Remove(s[l]);
                l++;
            }
            else
            {
                set.Add(s[r]);
                output = Math.Max(output, r - l + 1);
                r++;
            }
        }

        return output;
    }
}
