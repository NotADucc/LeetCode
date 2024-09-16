using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0389 : IRunProgram
{
    public void Run()
    {
        FindTheDifference("abcd", "abcde").Print();
        FindTheDifference("", "y").Print();
    }

    public char FindTheDifference(string s, string t)
    {
        (ReadOnlySpan<char> small, ReadOnlySpan<char> big) = s.Length < t.Length ? (s, t) : (t, s);

        int output = 0;
        for (int i = 0; i < small.Length; i++)
        {
            output += big[i];
            output -= small[i];
        }
        output += big[^1];

        return (char)output;
    }
}
