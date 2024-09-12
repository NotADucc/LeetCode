using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0003 : IRunProgram
    {
        public void Run()
        {
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        }

        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();
            int output = 0;
            int l = 0, r = 0;

            while (r < s.Length)
            {
                if (set.Contains(s[r]))
                {
                    while (s[l] != s[r])
                    {
                        set.Remove(s[l]);
                        l++;
                    }
                    set.Remove(s[l]);
                    l++;
                }
                else
                {
                    set.Add(s[r]);
                    output = Math.Max(output, r - l + 1);
                    r++;
                }
            }

            return output;
        }
    }
}
