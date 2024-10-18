using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0541 : IRunProgram
{
    public void Run()
    {

    }

    public string ReverseStr(string s, int k)
    {
        char[] arr = s.ToArray();
        int k_2 = k << 1;
        for (int i = 0; i < s.Length; i += k_2)
        {
            int l = i, r = Math.Min(l + k - 1, s.Length - 1);
            while (l < r)
            {
                arr[l] ^= arr[r];
                arr[r] ^= arr[l];
                arr[l] ^= arr[r];
                l++;
                r--;
            }
        }

        return new string(arr);
    }
}
