using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution2125 : IRunProgram
{
    public void Run()
    {
        NumberOfBeams(["011001", "000000", "010100", "001000"]).Print();
        NumberOfBeams(["000", "111", "000"]).Print();
    }

    public int NumberOfBeams(string[] bank)
    {
        int ans = 0, prev = 0;

        foreach (var line in bank)
        {
            int laser_count = 0;
            foreach (var sq in line)
            {
                if (sq == '1') laser_count++;
            }

            ans += prev * laser_count;
            if (laser_count > 0)
                prev = laser_count;
        }

        return ans;
    }
}
