using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3295 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool ReportSpam(string[] message, string[] bannedWords)
    {
        HashSet<string> set = new HashSet<string>(bannedWords);
        int count = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if (set.Contains(message[i]))
            {
                count++;
                if (count > 1) return true;
            }
        }

        return false;
    }
}
