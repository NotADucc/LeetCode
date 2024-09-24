using FastSerialization;
using LeetCode.Solutions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace LeetCode.Solutions;

internal class Solution0208 : IRunProgram
{
    public void Run()
    {
        Trie trie = new Trie();
        trie.Insert("tenderheart");
        trie.Insert("tea");
        trie.Search("ten").Print();
    }

    public class Trie
    {
        private Dictionary<char, Trie> trie;
        public Trie()
        {
            trie = new Dictionary<char, Trie>();
        }
        public void Insert(ReadOnlySpan<char> word)
        {
            var temp = trie;
            for (int i = 0; i < word.Length; i++)
            {
                temp.TryAdd(word[i], new Trie());
                temp = temp[word[i]].trie;
            }
            temp.TryAdd('\0', new Trie());
        }
        public bool Search(string word) => ContainsWord(word);
        public bool StartsWith(string prefix) => ContainsWord(prefix, true);
        public bool ContainsWord(ReadOnlySpan<char> input, bool prefix = false)
        {
            var temp = trie;
            for (int i = 0; i < input.Length; i++)
            {
                if (temp is null || !temp.ContainsKey(input[i])) return false;
                temp = temp[input[i]].trie;
            }
            return prefix ? true : temp.ContainsKey('\0');
        }
        //for debugging
        public override string ToString() => string.Join(", ", trie.Select(kv => $"[{kv.Key} => {kv.Value}]"));
    }
}