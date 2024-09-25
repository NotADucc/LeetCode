using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2416 : IRunProgram
{
    public void Run()
    {

    }
    public int[] SumPrefixScores(string[] words) 
    {
        var trie = new Trie();

        foreach(var word in words)
        {
            trie.AddWord(word);
        }
        int[] output = new int[words.Length];
        for(int i = 0; i < output.Length; i++)
        {
            output[i] = trie.GetPrefixScore(words[i]);
        }
        return output;
    }
    class Trie
    {
        private TrieHelper[] trie = new TrieHelper[26];
        public void AddWord(string word)
        {
            var temp = trie;
            foreach(var ch in word)
            {
                if(temp[ch - 'a'] is null)
                {
                    temp[ch - 'a'] = new TrieHelper(0, new Trie());
                }
                temp[ch - 'a'].count++;
                temp = temp[ch - 'a'].node.trie;
            }
        }
        public int GetPrefixScore(string word)
        {
            var temp = trie;
            int score = 0;
            foreach(var ch in word)
            {
                if(temp is null || temp[ch - 'a'] is null) break;
                score += temp[ch - 'a'].count;
                temp = temp[ch - 'a'].node.trie;
            }

            return score;
        }
    }
    private class TrieHelper
    {
        public int count;
        public Trie node;
        public TrieHelper(int count, Trie node)
        {
            this.count = count;
            this.node = node;
        }
    }
}
