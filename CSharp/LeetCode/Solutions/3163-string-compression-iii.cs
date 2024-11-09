using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

public class Solution3163 : IRunProgram
{
    public void Run()
    {
        
    }

    public string CompressedString(string word) 
    {
        StringBuilder sb = new StringBuilder();
        int count = 1;

        for (int i = 0; i < word.Length - 1; i++) 
        {
            if (word[i] != word[i + 1] || count >= 9)
            {
                sb.Append(count);
                sb.Append(word[i]);
                count = 0;
            }
            count++;
        }

        sb.Append(count);
        sb.Append(word[^1]);

        return sb.ToString();        
    }
}
