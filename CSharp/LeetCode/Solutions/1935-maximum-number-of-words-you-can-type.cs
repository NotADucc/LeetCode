using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1935 : IRunProgram
{
    public void Run()
    {
        CanBeTypedWords("hello world", "ad").Print();
        CanBeTypedWords("leet code", "e").Print();
    }

    public int CanBeTypedWords(string text, string brokenLetters)
    {
        Span<bool> is_broken = stackalloc bool[26];

        foreach (char ch in brokenLetters)
            is_broken[ch - 'a'] = true;

        ReadOnlySpan<char> text_span = text.AsSpan();
        int n = 0, broken_count = 0;

        while (true)
        {
            int offset = text_span.IndexOf(' ');
            bool at_end = false;
            if (offset == -1)
            {
                offset = text_span.Length;
                at_end = true;
            }
            for (int i = 0; i < offset; i++)
            {
                char ch = text_span[i];
                if (is_broken[ch - 'a'])
                {
                    broken_count++;
                    break;
                }
            }
            n++;
            if (at_end) break;
            text_span = text_span.Slice(offset + 1);
        }

        return n - broken_count;
    }
}
