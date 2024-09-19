using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0003 : IRunProgram
{
    public void Run()
    {
        LengthOfLongestSubstring("aabaab!bb").Print();
    }

    private Int128 ONE = 1;
    public int LengthOfLongestSubstring(string s)
    {
        int Convert(char ch) => ch - ' ';
        Int128 mask = 0;
        int l = 0, r = 0, output = 0;
        while (r < s.Length)
        {
            Int128 temp = mask ^ (ONE << Convert(s[r]));
            if (temp < mask)
            {
                while (s[l] != s[r])
                {
                    mask ^= ONE << Convert(s[l]);
                    l++;
                }
                mask ^= ONE << Convert(s[l]);
                l++;
            }
            else
            {
                mask = temp;
                output = Math.Max(output, r - l + 1);
                r++;
            }
        }

        return output;
    }
}
