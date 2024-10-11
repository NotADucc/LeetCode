using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

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
            int mid = left + ((right - left) >> 1);
            int result_guess = guess(mid);
            if (result_guess == 1)
            {
                left = mid + 1;
            }
            else if (result_guess == -1)
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
