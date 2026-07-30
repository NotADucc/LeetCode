using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0521 : IRunProgram
{
    public void Run()
    {

    }

    public int FindLUSlength(string a, string b)
    {
        return a == b ?
            -1 : Math.Max(a.Length, b.Length);
    }
}
