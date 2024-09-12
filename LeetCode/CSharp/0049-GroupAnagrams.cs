using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    public class Solution0049 : IRunProgram
    {
        public void Run()
        {
            GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]).PrintNested();
            GroupAnagrams(["a"]).PrintNested();
            GroupAnagrams([""]).PrintNested();
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dct = new Dictionary<int, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var hash = HashCode.Combine(string.Concat(strs[i].OrderBy(x => x)));
                if (!dct.TryAdd(hash, new List<string>() { strs[i] }))
                {
                    dct[hash].Add(strs[i]);
                }
            }

            return dct.Values.ToList();
        }
    }
}
