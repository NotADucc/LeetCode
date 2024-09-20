using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0014 : IRunProgram
{
    public void Run()
    {
        LongestCommonPrefix(["flower", "flow", "flight"]).Print();
        LongestCommonPrefix(["dog", "racecar", "car"]).Print();
    }

    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }
        int len = 0;

        string smallest = strs.OrderBy(c => c.Length).FirstOrDefault();

        for (int i = 0; i < smallest.Length; i++)
        {
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j][i] != smallest[i])
                {
                    return smallest.Substring(0, len);
                }
            }
            len++;
        }
        return smallest.Substring(0, len);
    }
}
