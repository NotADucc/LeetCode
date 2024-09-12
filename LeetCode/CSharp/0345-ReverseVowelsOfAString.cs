using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0345 : IRunProgram
    {
        public void Run()
        {
            ReverseVowels("iceCreAm").Print();
            ReverseVowels("leetcode").Print();
        }

        public string ReverseVowels(string s)
        {
            var a = s.ToArray();
            int left = 0;
            int right = a.Length - 1;
            while (left < right)
            {
                if (!IsVowel(a[left]))
                {
                    left++;
                    continue;
                }

                if (!IsVowel(a[right]))
                {
                    right--;
                    continue;
                }

                var temp = a[left];
                a[left] = a[right];
                a[right] = temp;
                left++;
                right--;
            }

            return String.Join("", a);
        }

        private bool IsVowel(char input)
        {
            input = char.ToLower(input);
            return
            'a' == input
            | 'e' == input
            | 'i' == input
            | 'o' == input
            | 'u' == input;
        }
    }
}
