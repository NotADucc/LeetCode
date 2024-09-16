using LeetCode.Solutions.Shared;


namespace LeetCode.Solutions;

internal class Solution2798 : IRunProgram
{
    public void Run()
    {
        NumberOfEmployeesWhoMetTarget([0, 1, 2, 3, 4], 2).Print();
    }

    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        return hours.Count(x => x >= target);
    }
}
