using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1358 : IRunProgram
{
    public void Run()
    {

    }

    public int NumberOfSubstrings(string s)
    {
        static int transform(char ch) => ch - 'a';
        static bool consists(int[] arr) => arr[0] > 0 && arr[1] > 0 && arr[2] > 0;
        int[] freq = [0, 0, 0];
        int res = 0, n = s.Length, l = 0;

        for (int r = 0; r < n; r++)
        {
            char ch = s[r];
            int idx = transform(ch);
            freq[idx]++;

            while (consists(freq))
            {
                res += n - r;
                ch = s[l++];
                idx = transform(ch);
                freq[idx]--;
            }
        }

        return res;
    }
}
