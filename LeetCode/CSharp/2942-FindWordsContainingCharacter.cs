using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2942 : IRunProgram
    {
        public void Run()
        {
            FindWordsContaining(["leet", "code"], 'e').Print();
        }

        public IList<int> FindWordsContaining(string[] words, char x)
        {
            var output = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].IndexOf(x) > -1)
                {
                    output.Add(i);
                }
            }

            return output;
        }
    }
}
