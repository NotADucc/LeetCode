using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2523 : IRunProgram
{
    public void Run()
    {

    }
    public int[] ClosestPrimes(int left, int right)
    {
        static bool is_prime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0) return false;

            return true;
        }

        int[] res = [-1, -1];
        int latest_prime = -1;
        for (; left <= right; left++)
        {
            if (!is_prime(left)) 
                continue;

            if (latest_prime > -1)
            {
                if (left - latest_prime <= 2)
                    return [latest_prime, left];

                if (res[0] == -1 || res[1] - res[0] > left - latest_prime)
                {
                    res[0] = latest_prime;
                    res[1] = left;
                }

            }
            latest_prime = left;
        }

        return res;
    }
}
