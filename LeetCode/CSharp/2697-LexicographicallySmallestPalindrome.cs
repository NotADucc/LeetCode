using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2697 : IRunProgram
    {
        public void Run()
        {
            MakeSmallestPalindrome("egcfe").Print();
        }

        public string MakeSmallestPalindrome(string s)
        {
            Span<char> output = stackalloc char[s.Length];

            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                if (s[left] == s[right])
                {
                    output[left] = s[left];
                    output[right] = s[left];
                }
                else
                {
                    char smallestChar = (char)(Math.Min(s[left], s[right]));
                    output[left] = smallestChar;
                    output[right] = smallestChar;
                }

                left++;
                right--;
            }

            if (left == right)
            {
                output[left] = s[left];
            }

            return new string(output);
        }
    }
}
