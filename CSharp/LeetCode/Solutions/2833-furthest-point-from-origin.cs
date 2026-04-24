using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution2833 : IRunProgram
{
    public void Run()
    {

    }

    public int FurthestDistanceFromOrigin(string moves)
    {
        int ans = 0, offset = 0;

        foreach (char ch in moves)
        {
            if (ch == 'L')
            {
                ans--;
            }
            else if (ch == 'R')
            {
                ans++;
            }
            else
            {
                offset++;
            }
        }

        return Math.Abs(ans) + offset;
    }
}
