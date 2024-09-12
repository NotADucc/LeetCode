using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1657 : IRunProgram
    {
        public void Run()
        {
            CloseStrings("abc", "cba").Print();
        }

        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            Span<int> char_freq_1 = stackalloc int[26];
            Span<int> char_freq_2 = stackalloc int[26];

            for (int i = 0; i < word1.Length; i++)
            {
                char w1 = word1[i];
                char w2 = word2[i];
                char_freq_1[w1 - 'a']++;
                char_freq_2[w2 - 'a']++;
            }

            var delta_freq = new Dictionary<int, int>();
            for (int i = 0; i < char_freq_1.Length; i++)
            {
                if (char_freq_1[i] == 0 ^ char_freq_2[i] == 0)
                {
                    return false;
                }
                delta_freq.TryAdd(char_freq_1[i], 0);
                delta_freq.TryAdd(char_freq_2[i], 0);
                delta_freq[char_freq_1[i]]++;
                delta_freq[char_freq_2[i]]--;
            }

            return delta_freq.Values.All(x => x == 0);
        }
    }
}
