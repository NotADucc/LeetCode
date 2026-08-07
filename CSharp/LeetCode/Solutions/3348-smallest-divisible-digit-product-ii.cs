using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3348 : IRunProgram
{
    public void Run()
    {
        SmallestNumber("1234", 256).Print();
        SmallestNumber("11111", 26).Print(); 
        SmallestNumber("12", 22_020_096_000).Print(); 
    
    }

    public string SmallestNumber(string num, long t)
    {
        if (!is_possible(t))
            return "-1";

        List<int> numbers = num
            .Select(c => c - '0')
            .ToList();

        string t_string = t.ToString();

        for (int i = numbers.Count; i <= t_string.Length; i++)
            numbers.Add(9);

        while (numbers.Count < 15)
        {
            int d = 1;
            bool allowed = true;

            for (int i = 0; i < numbers.Count; i++)
            {
                int dd = numbers[i];
                if (dd == 0)
                {
                    allowed = false;
                    break;
                }
                d *= dd;
            }

            if (allowed && d % t == 0)
                return string.Join("", numbers);

            increase(numbers, numbers.Count - 1);
        }

        return "-1";
    }

    private void increase(List<int> numbers, int idx)
    {
        if (idx < 0)
        {
            numbers.Add(2);
            return;
        }

        if (numbers[idx] == 9)
        {
            numbers[idx] = 2;
            increase(numbers, idx - 1);
        }
        else 
        {
            numbers[idx]++;
        }
    }

    private bool is_possible(long t)
    {
        List<int> primes = [2, 3, 5, 7];
        while (t > 1)
        {
            long before = t;

            foreach (var prime in primes)
            {
                if (t % prime == 0)
                    t /= prime;
            }

            if (t == before)
                return false;
        }
        return true;
    }
}
