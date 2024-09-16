using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2220 : IRunProgram
{
    public void Run()
    {
        MinBitFlips(10, 7).Print();
    }

    public int MinBitFlips(int start, int goal)
    {
        return int.PopCount(start ^ goal);
    }
}
