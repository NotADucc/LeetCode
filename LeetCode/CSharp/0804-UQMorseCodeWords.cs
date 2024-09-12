using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class UQMorseCodeWords : IRunProgram
    {
        private record Input(string[] Data, int Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            { 
                new Input(new string[] { "gin","zen","gig","msg" }, 2)
                ,new Input(new string[] { "a" }, 1)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(UniqueMorseRepresentations(input.Data));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
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
