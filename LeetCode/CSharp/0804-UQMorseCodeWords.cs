using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0804 : IRunProgram
    {
        public void Run()
        {
            UniqueMorseRepresentations(["gin", "zen", "gig", "msg"]);
            UniqueMorseRepresentations(["a"]);
        }

        private Dictionary<char, string> _codes = new Dictionary<char, string>() 
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."}
        };
        public int UniqueMorseRepresentations(string[] words)
        {
            return words.Select
            (
                s => string.Join
                ("",
                    s.Select
                    (
                        c => _codes[c]
                    )
                )
            ).ToHashSet().Count;
        }
    }
}
