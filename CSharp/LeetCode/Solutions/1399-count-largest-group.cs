using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1399 : IRunProgram
{
    public void Run()
    {

    }

    public int CountLargestGroup(int n)
    {
        static int convert(int nm)
        {
            int res = 0;
            while (nm > 0)
            {
                res += nm % 10;
                nm /= 10;
            }
            return res;
        }

        var freq = new Dictionary<int, int>();
        int res = 0, max = 0;
        for (int i = 1; i <= n; i++)
        {
            int dig = convert(i);
            if (!freq.TryAdd(dig, 1))
                freq[dig]++;

            int dic = freq[dig];
            if (dic > max)
            {
                max = dic;
                res = 1;
            }
            else if (dic == max)
            {
                res++;
            }
        }

        return res;
    }
}
