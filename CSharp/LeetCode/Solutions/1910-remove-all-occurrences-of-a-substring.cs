using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions
{
    internal class Solution1910 : IRunProgram
    {
        public void Run()
        {

        }

        public string RemoveOccurrences(string s, string part)
        {
            bool compare(StringBuilder sb, int idx, ReadOnlySpan<char> part)
            {
                for (int i = 0; i < part.Length; i++)
                {
                    if (sb[idx + i] != part[i])
                        return false;
                }

                return true;
            }

            var sb = new StringBuilder(s);
            var n_p = part.Length;

            for (int i = 0; i <= sb.Length - n_p; i++)
            {
                if (compare(sb, i, part))
                {
                    sb.Remove(i, n_p);
                    i = -1;
                }
            }

            return sb.ToString();
        }
    }
}
