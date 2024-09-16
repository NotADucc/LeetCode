using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0739: IRunProgram
{
    public void Run()
    {
        DailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]).Print();
    }
    public int[] DailyTemperatures(int[] temperatures)
    {
        int seeker = 1;
        int prev = int.MinValue;
        for (int i = 0; i < temperatures.Length; i++)
        {
            if (i > 0 && prev == temperatures[i])
            {
                temperatures[i] = Math.Max(temperatures[i - 1] - 1, 0);
                continue;
            }

            while (true)
            {
                if (i + seeker >= temperatures.Length)
                {
                    prev = temperatures[i];
                    temperatures[i] = 0;
                    seeker = 1;
                    break;
                }
                if (temperatures[i + seeker] > temperatures[i])
                {
                    prev = temperatures[i];
                    temperatures[i] = seeker;
                    seeker = 1;
                    break;
                }
                else
                {
                    seeker++;
                }
            }
        }

        return temperatures;
    }
}
