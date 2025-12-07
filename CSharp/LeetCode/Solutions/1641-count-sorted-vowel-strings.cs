using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1641 : IRunProgram
{
    public void Run()
    {
        CountVowelStrings(1).Print();
        CountVowelStrings(2).Print();
    }

    public int CountVowelStrings(int n)
    {
        return rec(n);
    }
    private static int rec(int n)
    {
        const int MAX = 5;
        Dictionary<(int, int), int> memo = [];

        int inner(int curr, int idx)
        {
            if (idx >= MAX)
            {
                return 0;
            }

            var key = (curr, idx);
            if (memo.TryGetValue(key, out int value))
            {
                return value;
            }

            if (n == curr)
            {
                memo[key] = 1;
                return 1;
            }

            var res = 0;

            for (int i = 0; i < MAX; i++)
                res += inner(curr + 1, idx + i);

            memo[key] = res;

            return res;
        }

        return inner(0, 0);
    }
}
