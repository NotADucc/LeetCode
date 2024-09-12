using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1876 : IRunProgram
    {
        public void Run()
        {
            CountGoodSubstrings("xyzzaz").Print();
            CountGoodSubstrings("aababcabc").Print();
        }

        public int CountGoodSubstrings(string s)
        {
            int output = 0;
            int w = 0;
            while (w + 2 < s.Length)
            {
                if (!(s[w] == s[w + 1] || s[w] == s[w + 2] || s[w + 1] == s[w + 2]))
                {
                    output++;
                }
                w++;
            }

            return output;
        }
    }
}
