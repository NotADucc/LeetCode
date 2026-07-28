using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;
internal class Solution3517 : IRunProgram
{
    public void Run()
    {
        SmallestPalindrome("z").Print();
    }

    public string SmallestPalindrome(string s)
    {
        StringBuilder sb = new StringBuilder();
        int sb_idx = 0;
        char pivot = '\0';
        Span<int> freq = stackalloc int[26];

        foreach (char ch in s)
            freq[ch - 'a']++;

        for (int i = 0; i < freq.Length; i++)
        {
            int cnt = freq[i];
            if (cnt <= 0)
                continue;

            char ch = (char)('a' + i);

            if ((cnt & 1) == 1)
            {
                pivot = ch;
                cnt--;
            }
            int half = cnt >> 1;

            sb.Insert(sb_idx, new string(ch, cnt));
            sb_idx += half;
        }

        if (pivot != '\0')
            sb.Insert(sb.Length >> 1, pivot);

        return sb.ToString();
    }

    public string SmallestPalindromeDoubleSB(string s)
    {
        StringBuilder sb = new StringBuilder();
        char pivot = '\0';
        Span<int> freq = stackalloc int[26];

        foreach (char ch in s)
            freq[ch - 'a']++;

        for (int i = 0; i < freq.Length; i++)
        {
            int cnt = freq[i];
            if (cnt <= 0)
                continue;

            char ch = (char)('a' + i);
            int half = cnt >> 1;
            sb.Append(new string(ch, half));

            if ((cnt & 1) == 1)
            {
                pivot = ch;
            }
        }

        var copy_reverse = new StringBuilder(
            new string(sb.ToString().Reverse().ToArray())
        );

        if (pivot != '\0')
            sb.Append(pivot);

        sb.Append(copy_reverse);

        return sb.ToString();
    }
}
