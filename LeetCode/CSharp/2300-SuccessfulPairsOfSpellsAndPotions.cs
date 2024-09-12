using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2300 : IRunProgram
{
    public void Run()
    {
        SuccessfulPairs([5, 1, 3], [1, 2, 3, 4, 5], 7).Print();
    }

    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);

        for (int i = 0; i < spells.Length; i++)
        {
            int index = Search(potions, spells[i], success);
            spells[i] = potions.Length - index;
        }

        return spells;
    }

    private int Search(int[] potions, int spell, long succes_roll)
    {
        int left = 0, right = potions.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) >> 1;
            long roll = (long)potions[mid] * spell;
            if (roll < succes_roll)
            {
                left = mid + 1;
            }
            else if (roll > succes_roll)
            {
                right = mid - 1;
            }
            else if (mid + 1 < potions.Length && (long)potions[mid + 1] * spell == succes_roll)
            {
                right = mid - 1;
            }
            else
            {
                return mid;
            }
        }
        return left;
    }
}
