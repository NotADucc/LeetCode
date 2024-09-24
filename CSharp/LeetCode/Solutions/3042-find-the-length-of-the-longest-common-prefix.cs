using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3043 : IRunProgram
{
    public void Run()
    {
        
    }

    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var set = new HashSet<string>();

        for (int i = 0; i < arr1.Length; i++)
        {
            string num = arr1[i].ToString();
            for (int j = 1; j <= num.Length; j++)
            {
                set.Add(num.Substring(0, j));
            }
        }

        int max = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            string num = arr2[i].ToString();
            for (int j = num.Length; j >= 1; j--)
            {
                if (set.Contains(num.Substring(0, j)))
                {
                    max = Math.Max(max, j);
                    break;
                }
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
