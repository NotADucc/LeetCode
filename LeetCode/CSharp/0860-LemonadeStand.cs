using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0860: IRunProgram
{
    public void Run()
    {
        LemonadeChange([5, 5, 5, 10, 20]).Print();
    }
    private const int MAGIC_SIZE = 3;

    public bool LemonadeChange(int[] bills)
    {
        int five = 0, ten = 0;

        foreach (var bill in bills)
        {
            if (bill == 5)
            {
                five++;
            }
            else if (bill == 10 && five > 0)
            {
                five--;
                ten++;
            }
            else if (bill == 20 && ten >= 1 && five >= 1)
            {
                ten--;
                five--;
            }
            else if (bill == 20 && five >= 3)
            {
                five -= 3;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
