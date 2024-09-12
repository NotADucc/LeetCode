using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1071: IRunProgram
    {
        public void Run()
        {
            GcdOfStrings("ABCABC", "ABC").Print();
        }

        public string GcdOfStrings(string str1, string str2)
        {
            (ReadOnlySpan<char> large, ReadOnlySpan<char> small) = str1.Length < str2.Length
                ? (str2, str1)
                : (str1, str2);

            int divisor_small_length = small.Length, large_length = large.Length;

            for (int i = 0; divisor_small_length > 0;)
            {
                if (i == large_length)
                {
                    break;
                }
                if (large_length - i < divisor_small_length
                    || small.Length % divisor_small_length != 0
                    || !large.Slice(i, divisor_small_length).Equals(small.Slice(0, divisor_small_length), StringComparison.Ordinal))
                {
                    i = 0;
                    divisor_small_length--;
                }
                i += divisor_small_length;
            }

            for (int i = 0; divisor_small_length > 0;)
            {
                if (i == small.Length)
                {
                    break;
                }

                if (!small.Slice(i, divisor_small_length).Equals(small.Slice(0, divisor_small_length), StringComparison.Ordinal))
                {
                    return string.Empty;
                }
                i += divisor_small_length;
            }

            return small.Slice(0, divisor_small_length).ToString();
        }
    }
}
