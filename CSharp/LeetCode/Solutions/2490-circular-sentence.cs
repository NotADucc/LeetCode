using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2490 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool IsCircularSentence(string sentence)
    {
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                if (sentence[i - 1] != sentence[i + 1])
                {
                    return false;
                }
            }
        }
        return sentence[0] == sentence[^1];
    }
}
