using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2000 : IRunProgram
    {
        public void Run()
        {
            ReversePrefix("abcdefd", 'd').Print();
        }
        public string ReversePrefix(string word, char ch)
        {
            int end = Math.Max(word.IndexOf(ch) + 1, 0);

            var prefix = word.Substring(0, end).Reverse().ToArray();

            return new string(prefix) + word.Substring(end);
        }
    }
}
