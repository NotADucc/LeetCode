using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2523 : IRunProgram
{
    public void Run()
    {

    }
    public int[] ClosestPrimes(int left, int right)
    {
        bool is_prime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0) return false;

            return true;
        }

        var q = new PriorityQueue<int[], int>();
        var first = -1;
        while (left <= right)
        {
            if (is_prime(left))
            {
                if (first == -1)
                {
                    first = left;
                }
                else
                {
                    if (left - first <= 2)
                        return [first, left];
                    q.Enqueue([first, left], left - first);
                    first = left;
                }
            }
            left++;
        }

        return q.Count == 0 ? [-1, -1] : q.Dequeue();
    }
}
