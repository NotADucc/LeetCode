using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2506 : IRunProgram
{
    public void Run()
    {
        SimilarPairs(["aba", "aabb", "abcd", "bac", "aabc"]).Print();
    }
    public int SimilarPairs(string[] words)
    {
        int[] converted = new int[words.Length];
        for (int i = 0; i < words.Length; i++) { converted[i] = Convert(words[i]); }
        var output = 0;
        for (int i = 0; i < converted.Length; i++)
        {
            for (int j = i + 1; j < converted.Length; j++)
            {
                if (converted[i] == converted[j])
                {
                    output++;
                }
            }
        }
        return output;
    }

    private int Convert(string input)
    {
        int val = 0;
        for (int i = 0; i < input.Length; i++)
        {
            val |= 1 << input[i] - 'a' + 1;
        }
        return val;
    }
}
