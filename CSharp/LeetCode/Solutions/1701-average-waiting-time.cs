using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1701 : IRunProgram
{
    public void Run()
    {
        AverageWaitingTime([[1, 2], [2, 5], [4, 3]]).Print();
    }

    public double AverageWaitingTime(int[][] customers)
    {
        double sum_wait = 0;
        double hour_finished_cooking = 0;

        foreach (int[] customer in customers)
        {
            if (hour_finished_cooking > customer[0])
            {
                hour_finished_cooking += customer[1];
                sum_wait += hour_finished_cooking - customer[0];
            }
            else
            {
                hour_finished_cooking = customer[0] + customer[1];
                sum_wait += hour_finished_cooking - customer[0];
            }
        }


        return sum_wait / customers.Length;
    }
}
