using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2559 : IRunProgram
{
    public void Run()
    {

    }

    public int[] VowelStrings(string[] words, int[][] queries)
    {
        static bool IsVowel(char ch) => ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';

        var prefix = new int[words.Length];
        var res = new int[queries.Length];

        prefix[0] = (IsVowel(words[0][0]) && IsVowel(words[0][^1])) ? 1 : 0;
        for (int i = 1; i < words.Length; i++)
        {
            prefix[i] = prefix[i - 1] + ((IsVowel(words[i][0]) && IsVowel(words[i][^1])) ? 1 : 0);
        }

        for (int i = 0; i < res.Length; i++)
        {
            int end = queries[i][1];
            int start = queries[i][0] - 1;
            res[i] = prefix[end];
            if (start > -1)
            {
                res[i] -= prefix[start];
            }
        }

        return res;
    }
}
