using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0746 : IRunProgram
{
    public void Run()
    {

    }

    public int MinCostClimbingStairs(int[] cost)
    {
        int[] n_cost = new int[cost.Length + 1];
        Array.Copy(cost, n_cost, cost.Length);

        for (int i = n_cost.Length - 4; i >= 0; i--)
        {
            n_cost[i] += Math.Min(n_cost[i + 1], n_cost[i + 2]);
        }

        return Math.Min(n_cost[0], n_cost[1]);
    }
}
