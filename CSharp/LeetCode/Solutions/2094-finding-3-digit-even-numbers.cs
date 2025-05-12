using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2094 : IRunProgram
{
    public void Run()
    {
        
    }

	public int[] FindEvenNumbers(int[] digits) 
	{
        List<int> res = [];
        Span<int> freq = stackalloc int[10];

        foreach (int digit in digits)
            freq[digit]++;

        for (int i = 100; i < 1000; i += 2)
        {
            Span<int> compare = stackalloc int[10];
            int dig1 = i / 100, dig2 = (i / 10) % 10, dig3 = i % 10;
            compare[dig1]++;
            compare[dig2]++;
            compare[dig3]++;
            if (compare[dig1] <= freq[dig1]
                && compare[dig2] <= freq[dig2]
                && compare[dig3] <= freq[dig3]) 
                res.Add(i);
        }

        return res.ToArray();
    }
}
