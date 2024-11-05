using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2914 : IRunProgram
{
    public void Run()
    {
        
    }
    public int MinChanges(string s)
    {
        int output = 0;
        for (int i = 0; i < s.Length - 1; i += 2)
        {
            if (s[i] != s[i + 1]) output++;
        }
        return output;
    }
}
