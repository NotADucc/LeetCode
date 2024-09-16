using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1684 : IRunProgram
{
    public void Run()
    {
        CountConsistentStrings("ab", ["ad", "bd", "aaab", "baa", "badab"]).Print();
    }

    public int CountConsistentStrings(string allowed, string[] words)
    {
        int output = 0;
        for (int i = 0; i < words.Length; i++)
        {
            output++;
            for (int j = 0; j < words[i].Length; j++)
            {
                if (!allowed.Contains(words[i][j]))
                {
                    output--;
                    break;
                }
            }
        }

        return output;
    }
}
