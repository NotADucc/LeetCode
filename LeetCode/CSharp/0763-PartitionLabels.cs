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
    internal class Solution0763: IRunProgram
    {
        public void Run()
        {
            PartitionLabels("ababcbacadefegdehijhklij").Print();
        }
        public IList<int> PartitionLabels(string s)
        {
            //key is letter
            //value is first seen and last seen
            var dct = new Dictionary<char, (int, int)>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dct.ContainsKey(s[i]))
                {
                    dct.Add(s[i], (i, i));
                }
                else
                {
                    dct[s[i]] = (dct[s[i]].Item1, i);
                }
            }

            var lst = new List<int>();

            int bound = dct.ElementAt(0).Value.Item2;
            int offset = 0;
            for (int i = 1; i < dct.Count; i++)
            {
                var current = dct.ElementAt(i);
                if (current.Value.Item1 < bound)
                {
                    bound = Math.Max(bound, current.Value.Item2);
                }
                else
                {
                    bound = current.Value.Item2;
                    lst.Add(current.Value.Item1 - offset);
                    offset = current.Value.Item1;
                }
            }

            lst.Add(s.Length - offset);

            return lst;
        }
    }
}
