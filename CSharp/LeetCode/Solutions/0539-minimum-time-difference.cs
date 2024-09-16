using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0539 : IRunProgram
{
    public void Run()
    {
        FindMinDifference(["00:00", "23:59", "23:59", "00:01"]).Print();
    }

    public int FindMinDifference(IList<string> timePoints)
    {
        int GetHours(string time) => (time[0] - '0') * 10 + time[1] - '0';
        int GetMinutes(string time) => (time[3] - '0') * 10 + time[4] - '0';

        List<int> mins = timePoints
            .Select(x => GetHours(x) * 60 + GetMinutes(x))
            .OrderBy(x => x)
            .ToList();
        int smallest_delta = Math.Min(mins[0] + 24 * 60 - mins[^1], mins[^1] - mins[0]);

        for (int i = 0; i < timePoints.Count - 1; i++)
        {
            int time_1 = mins[i];
            int time_2 = mins[i + 1];
            int time_1_max = time_1 + 24 * 60;
            int min_deltas = Math.Min(time_2 - time_1, time_1_max - time_2);
            smallest_delta = Math.Min(smallest_delta, min_deltas);
            if (smallest_delta == 0) return smallest_delta;
        }

        return smallest_delta;
    }
}
