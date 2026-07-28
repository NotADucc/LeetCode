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

        if (pivot != '\0')
            sb.Append(pivot);

        var copy_reverse = new StringBuilder(
            new string(sb.ToString().Reverse().ToArray())
        );
        sb.Append(copy_reverse);

        return sb.ToString();
    }
}
