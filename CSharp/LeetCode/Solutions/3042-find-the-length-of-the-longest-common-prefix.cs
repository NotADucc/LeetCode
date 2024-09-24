using LeetCode.Solutions.Shared;

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

    public class Trie
    {
        private Dictionary<char, Trie> trie;
        public Trie()
        {
            trie = new Dictionary<char, Trie>();
        }
        public void AddTrie(int add)
        {
            string num = add.ToString();
            var temp = trie;
            for (int i = 0; i < num.Length; i++)
            {
                temp.TryAdd(num[i], new Trie());
                temp = temp[num[i]].trie;
            }
        }
        public int Search(int target)
        {
            string num = target.ToString();
            int counter = 0;
            var temp = trie;
            for (int i = 0; i < num.Length; i++)
            {
                if (temp is null || !temp.ContainsKey(num[i])) break;
                counter++;
                temp = temp[num[i]].trie;
            }
            return counter;
        }
    }
}
