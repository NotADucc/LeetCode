using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1768 : IRunProgram
{
    public void Run()
    {
        MergeAlternately("abc", "pqr").Print();
    }

    public string MergeAlternately(string word1, string word2)
    {
        Span<char> output = stackalloc char[word1.Length + word2.Length];

        int i = 0, w1 = 0, w2 = 0;

        while (i < output.Length)
        {
            if ((w1 <= w2 && w1 < word1.Length) || w2 >= word2.Length)
            {
                output[i] = word1[w1];
                w1++;
            }
            else
            {
                output[i] = word2[w2];
                w2++;
            }
            i++;
        }

        return new string(output);
    }
}
