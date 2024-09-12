using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1286 : IRunProgram
    {
        public void Run()
        {

        }
    }
    public class CombinationIterator
    {
        private LinkedList<string> nodes;
        public CombinationIterator(string characters, int combinationLength)
        {
            void Combos(LinkedList<string> llist, StringBuilder sb, string characters, int len, int index)
            {
                if (sb.Length == len)
                {
                    llist.AddLast(sb.ToString());
                }
                else
                {
                    for (int i = index; i < characters.Length; i++)
                    {
                        sb.Append(characters[i]);
                        Combos(llist, sb, characters, len, i + 1);
                        sb.Remove(sb.Length - 1, 1);
                    }
                }
            }

            nodes = new LinkedList<string>();
            Combos(nodes, new StringBuilder(), characters, combinationLength, 0);
        }

        public string Next()
        {
            string val = nodes.First();
            nodes.RemoveFirst();
            return val;
        }

        public bool HasNext()
        {
            return nodes.Count != 0;
        }
    }
}
