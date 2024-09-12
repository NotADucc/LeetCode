using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution3271 : IRunProgram
    {
        public void Run()
        {
            StringHash("abcd", 2).Print();
        }

        public string StringHash(string s, int k)
        {
            Span<char> span = stackalloc char[s.Length / k];

            for (int i = 0; i < s.Length; i += k)
            {
                int c = 0;
                for (int j = 0; j < k; j++)
                {
                    c += s[i + j] - 'a';
                }
                span[i / k] = (char)(c % 26 + 'a');
            }

            return span.ToString();
        }
    }
}
