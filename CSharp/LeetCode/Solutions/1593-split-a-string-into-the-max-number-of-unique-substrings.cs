using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1593 : IRunProgram
{
    public void Run()
    {
        
    }

    public int MaxUniqueSplit(string s)
    {
        var set = new HashSet<string>();
        int output = 0;
        Backtrack(ref output, set, 0, s);
        return output;
    }
    private void Backtrack(ref int output, HashSet<string> set, int index, string s)
    {
        if (output < set.Count)
        {
            output = set.Count;
        }
        for (int len = 1; index + len <= s.Length; len++)
        {
            string sub = s.Substring(index, len);
            if (set.Add(sub))
            {
                Backtrack(ref output, set, index + len, s);
                set.Remove(sub);
            }
        }
    }
}
