using LeetCode.Solutions.Shared;
using System.Runtime.CompilerServices;

namespace LeetCode.Solutions;
internal class Solution3541 : IRunProgram
{
    public void Run()
    {

    }

    public int MaxFreqSum(string s)
    {
        Span<int> arr = stackalloc int[28];
        static int get_idx(char ch)
            => ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ? 26 : 27;

        foreach (char ch in s)
        {
            int ch_idx = ch - 'a';
            arr[ch_idx]++;
            int idx = get_idx(ch);
            arr[idx] = Math.Max(arr[idx], arr[ch_idx]);
        }

        return arr[26] + arr[27];
    }
}
