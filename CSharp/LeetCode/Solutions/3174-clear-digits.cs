using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3174 : IRunProgram
{
    public void Run()
    {

    }

    public string ClearDigits(string s) 
    {
        var sb = new StringBuilder(s);
        
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] <= '9' && sb[i] >= '0')
            {
                sb.Remove(i - 1, 2);
                i = Math.Max(0, i - 2);
            }
        }

        return sb.ToString();
    }
}
