using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0383 : IRunProgram
    {
        public void Run()
        {
            CanConstruct("a", "b").Print();
            CanConstruct("aa", "ab").Print();
            CanConstruct("aa", "aab").Print();
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine.Length < ransomNote.Length)
            {
                return false;
            }

            Span<char> ransomSpan = stackalloc char[ransomNote.Length];
            ransomNote.AsSpan().CopyTo(ransomSpan);

            Span<char> magazineSpan = stackalloc char[magazine.Length];
            magazine.AsSpan().CopyTo(magazineSpan);

            ransomSpan.Sort();
            magazineSpan.Sort();

            int ransomIndex = 0;
            for (int i = 0; i < magazine.Length && ransomIndex < ransomSpan.Length; i++)
            {
                if (magazineSpan[i] == ransomSpan[ransomIndex])
                {
                    ransomIndex++;
                }
            }

            return ransomIndex == ransomNote.Length;
        }
    }
}
