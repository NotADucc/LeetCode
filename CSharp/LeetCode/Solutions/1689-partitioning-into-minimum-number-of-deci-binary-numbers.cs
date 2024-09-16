using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1689 : IRunProgram
{
    public void Run()
    {
        MinPartitions("32").Print();
    }

    public int MinPartitions(string n)
    {
        return Convert.ToInt32(n.Max());
    }
}
