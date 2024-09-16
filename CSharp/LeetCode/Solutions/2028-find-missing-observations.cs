using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2028 : IRunProgram
{
    public void Run()
    {
        MissingRolls([3, 2, 4, 3], 4, 2).Print();
    }
    private static int[] _rolls = [6, 5, 4, 3, 2, 1];
    public int[] MissingRolls(int[] rolls, int targ_avg, int missing)
    {
        int curr_total = 0;
        for (int i = 0; i < rolls.Length; i++)
        {
            curr_total += rolls[i];
        }
        int targ_total = targ_avg * (rolls.Length + missing);
        int delta_missing = targ_total - curr_total;

        if (delta_missing < missing || delta_missing > 6 * missing) { return []; }

        int[] fill = new int[6];
        var output = new List<int>(missing);

        for (int i = 0; i < _rolls.Length; i++)
        {
            fill[i] = delta_missing / _rolls[i];
            missing -= fill[i];
            delta_missing %= _rolls[i];
        }

        int index = 0;
        while (missing > 0)
        {
            if (fill[index] > 0)
            {
                fill[index]--;
                fill[index + 1]++;
                fill[^1]++;
                missing--;
            }
            else
            {
                index = index + 1 >= fill.Length - 1 ? 0 : index + 1;
            }
        }

        for (int i = 0; i < fill.Length; i++)
        {
            output.AddRange(Enumerable.Repeat(6 - i, fill[i]));
        }

        return output.ToArray();
    }
}
