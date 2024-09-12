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
    internal class Solution2108 : IRunProgram
    {
        public void Run()
        {
            FirstPalindrome(["abc", "car", "ada", "racecar", "cool"]).Print();
        }

        public string FirstPalindrome(string[] words)
        {
            return words.FirstOrDefault(x => x.Equals(new string(x.Reverse().ToArray()))) ?? string.Empty;
        }
    }
}
