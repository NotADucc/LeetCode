using LeetCode.Solutions.Shared;
using System.Collections.Generic;

namespace LeetCode.Solutions;

internal class Solution3043 : IRunProgram
{
    public void Run()
    {
        
    }

    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < arr1.Length; i++)
        {
            int num = arr1[i];
            while (num > 0)
            {
                set.Add(num);
                num /= 10;
            }
        }

        int max = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            int num = arr2[i];
            while (num > 0)
            {
                if (set.Contains(num))
                {
                    max = Math.Max(max, num.ToString().Length);
                    break;
                }
                num /= 10;
            }
        }
        return max;
    }

    public int LongestCommonPrefixTrie(int[] arr1, int[] arr2)
    {
        int max = 0;
        Trie trie = new Trie();
        for (int i = 0; i < arr1.Length; i++)
        {
            trie.AddTrie(arr1[i]);
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            max = Math.Max(max, trie.Search(arr2[i]));
        }
        return max;
    }

    internal class Trie
    {
        private Dictionary<int, Trie> trie;
        public Trie()
        {
            trie = new Dictionary<int, Trie>();
        }
        public void AddTrie(int add)
        {
            Span<int> span = stackalloc int[20];
            int len = -1;
            while (add > 0)
            {
                span[++len] = add % 10;
                add /= 10;
            }
            var temp = trie;
            for (; len >= 0; len--)
            {
                temp.TryAdd(span[len], new Trie());
                temp = temp[span[len]].trie;
            }
        }
        public int Search(int target)
        {
            Span<int> span = stackalloc int[20];
            int len = -1;
            while (target > 0)
            {
                span[++len] = target % 10;
                target /= 10;
            }

            int counter = 0;
            var temp = trie;
            for (; len >= 0; len--)
            {
                if (temp is null || !temp.ContainsKey(span[len])) break;
                counter++;
                temp = temp[span[len]].trie;
            }
            return counter;
        }
    }
}
