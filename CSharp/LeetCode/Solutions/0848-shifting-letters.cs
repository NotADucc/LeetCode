using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution0848 : IRunProgram
{
    public void Run()
    {

    }

    public string ShiftingLetters(string s, int[] shifts)
    {
        StringBuilder sb = new StringBuilder(s);
        int count = 0;

        for (int i = shifts.Length - 1; i >= 0; i--)
        {
            count = (count + shifts[i]) % 26;
            sb[i] = (char)(((sb[i] - 'a' + count) % 26) + 'a');
        }

        return sb.ToString();
    }
}
