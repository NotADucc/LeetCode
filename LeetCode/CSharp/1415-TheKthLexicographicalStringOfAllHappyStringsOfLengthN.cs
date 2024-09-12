using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1415 : IRunProgram
    {
        public void Run()
        {
            GetHappyString(1, 3).Print();
        }
        public string GetHappyString(int n, int k)
        {
            int total = 3 * (int)Math.Pow(2, n - 1);
            if (k > total) { return string.Empty; }
            if (n == 1) { return ((char)('a' + k - 1)).ToString(); }

            List<string> output = new List<string>();
            StringBuilder sb = new StringBuilder();
            Helper(output, sb, ['a', 'b', 'c'], -1, n, k);

            return output[k - 1];
        }

        private void Helper(List<string> output, StringBuilder sb, char[] ch, int exclude, int n, int k)
        {
            if (sb.Length == n)
            {
                output.Add(sb.ToString());
            }
            else
            {
                if (output.Count >= k)
                {
                    return;
                }
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i == exclude)
                    {
                        continue;
                    }
                    sb.Append(ch[i]);
                    Helper(output, sb, ch, i, n, k);
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }
    }
}
