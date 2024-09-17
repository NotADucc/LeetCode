using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3042 : IRunProgram
{
    public void Run()
    {
        
    }

    public int CountPrefixSuffixPairs(string[] words)
    {
        int total = 0;

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[j].IndexOf(words[i]) == 0 && words[j].LastIndexOf(words[i]) == words[j].Length - words[i].Length)
                {
                    total++;
                }
            }
        }

        return total;
    }
}
