using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0409 : IRunProgram
    {
        public void Run()
        {
            LongestPalindrome("abccccdd").Print();
            LongestPalindrome("abcccc").Print();
            LongestPalindrome("a").Print();
        }

        public int LongestPalindrome(string s)
        {
            //key chat
            //key freq
            var dct = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                dct.TryAdd(ch, 0);
                dct[ch]++;
            }

            bool is_s_odd = IsOdd(s.Length);
            bool seen_odd = false;
            int output = 0;
            foreach (var kvp in dct)
            {
                if (IsEven(kvp.Value))
                {
                    output += kvp.Value;
                }
                else if (IsOdd(kvp.Value) && !seen_odd)
                {
                    output += kvp.Value;
                    seen_odd = true;
                }
                else
                {
                    output += kvp.Value - 1;
                }
            }

            return output;
        }
        bool IsOdd(int input) => (input & 1) == 1;
        bool IsEven(int input) => (input & 1) == 0;
    }
}
