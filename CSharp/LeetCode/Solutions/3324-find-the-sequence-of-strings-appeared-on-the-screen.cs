using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution3324 : IRunProgram
{
    public void Run()
    {
        
    }

    public IList<string> StringSequence(string target)
    {
        StringBuilder sb = new StringBuilder();
        List<string> output = new List<string>();
        while (sb.Length < target.Length || sb[^1] != target[^1])
        {
            int index = sb.Length - 1;
            if (index >= 0 && sb[index] < target[index])
            {
                sb[index]++;
            }
            else
            {
                sb.Append("a");
            }
            output.Add(sb.ToString());
        }
        return output;
    }
}
