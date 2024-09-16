using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0292 : IRunProgram
{
    public void Run()
    {
        CanWinNim(1).Print();
        CanWinNim(2).Print();
        CanWinNim(3).Print();
        CanWinNim(4).Print();
        CanWinNim(9).Print();
        CanWinNim(90).Print();
    }

    public bool CanWinNim(int n)
    {
        return n % 4 != 0;
    }
}
