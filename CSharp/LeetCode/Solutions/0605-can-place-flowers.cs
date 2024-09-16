using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0605 : IRunProgram
{
    public void Run()
    {
        CanPlaceFlowers([1, 0, 0, 0, 1], 1).Print();
        CanPlaceFlowers([1, 0, 0, 0, 1], 2).Print();
    }
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed.Length == 1)
        {
            return (flowerbed[0] == 0 && n <= 1) || (flowerbed[0] == 1 && n == 0);
        }

        for (int i = 0; i < flowerbed.Length; i++)
        {
            bool start = (i == 0 || flowerbed[i - 1] == 0) && (i + 1 < flowerbed.Length && flowerbed[i] == 0 && flowerbed[i + 1] == 0);
            bool end = (i == flowerbed.Length - 1 && flowerbed[i - 1] == 0 && flowerbed[i] == 0);
            if (start || end)
            {
                flowerbed[i] = 1;
                n--;
            }
        }

        return n <= 0;
    }
}
