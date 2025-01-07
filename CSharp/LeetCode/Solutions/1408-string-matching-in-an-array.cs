using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1408 : IRunProgram
{
    public void Run()
    {

    }

    public IList<string> StringMatching(string[] words)
    {
        List<string> res = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (words[j].Contains(words[i]))
                {
                    res.Add(words[i]);
                    break;
                }
            }
        }

        return res;
    }
}
