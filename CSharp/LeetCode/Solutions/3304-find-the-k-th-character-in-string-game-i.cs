using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution3304 : IRunProgram
{
    public void Run()
    {
        KthCharacter(5).Print();
    }
    public char KthCharacter(int k)
    {
        StringBuilder sb = new StringBuilder("a", capacity: k);
        while (sb.Length < k)
        {
            sb.Append(string.Join("", sb.ToString().Select(Helper)));
        }
        return sb[k - 1];
    }
    private char Helper(char ch) => ch == 'z' ? 'a' : (char)(ch + 1);
}
