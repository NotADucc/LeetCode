using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2000 : IRunProgram
{
    public void Run()
    {
        ReversePrefix("abcdefd", 'd').Print();
    }
    public string ReversePrefix(string word, char ch)
    {
        int end = Math.Max(word.IndexOf(ch) + 1, 0);

        var prefix = word.Substring(0, end).Reverse().ToArray();

        return new string(prefix) + word.Substring(end);
    }
}
