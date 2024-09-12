using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0374 : IRunProgram
{
    public void Run()
    {
        GuessNumber(4).Print();
        GuessNumber(90).Print();
    }

    public int GuessNumber(int n)
    {
        int left = 0, right = n - 1;

        while (left <= right)
        {
            int mid = (int)(((long)left + right) >> 1);
            int gue = guess(mid);
            if (gue == 1)
            {
                left = mid + 1;
            }
            else if (gue == -1)
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

    // so compiler doesnt cry
    private int guess(int mid) { return 1; }
}
