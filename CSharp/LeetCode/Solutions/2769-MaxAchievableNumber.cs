using LeetCode.Shared;


namespace LeetCode.CSharp;

internal class Solution2769 : IRunProgram
{
    public void Run()
    {
        TheMaximumAchievableX(4, 1).Print();
        TheMaximumAchievableX(3, 2).Print();
    }

    public int TheMaximumAchievableX(int num, int t)
    {
        return num + t * 2;
    }
}
