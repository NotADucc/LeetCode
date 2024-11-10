using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3097 : IRunProgram
{
    public void Run()
    {
        MinimumSubarrayLength([41], 3).Print();
    }

    public int MinimumSubarrayLength(int[] nums, int k)
    {
        if (k == 0) return 1;

        int min = int.MaxValue, l = 0, r = 0;
        int[] bits = new int[30];
        int[] k_bits = new int[30];
        Func<int, int> add = num => num + 1, rem = num => num - 1;

        Modify(k, k_bits, add);

        while (r <= nums.Length)
        {
            while (Eq(bits, k_bits) && l < r)
            {
                min = Math.Min(min, r - l);
                int num_l = nums[l++];
                Modify(num_l, bits, rem);
            }
            if (r >= nums.Length) break;
            int num_r = nums[r++];
            Modify(num_r, bits, add);
        }

        return min == int.MaxValue ? -1 : min;
    }

    private void Modify(int num, int[] bits, Func<int, int> fn)
    {
        for (int i = 29; i >= 0; i--)
        {
            int mask = 1 << i;
            if ((num & mask) == mask)
            {
                bits[i] = fn(bits[i]);
                num -= mask;
            }
        }
    }

    private bool Eq(int[] b, int[] k)
    {
        int res = 0;
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] > 0) res += 1 << i;
            if (k[i] > 0) res -= 1 << i;
        }
        return res >= 0;
    }
}
