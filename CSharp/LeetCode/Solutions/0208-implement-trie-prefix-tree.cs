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
}

public class Trie
{
    private TrieNode trie;
    public Trie()
    {
        trie = new TrieNode();
    }
    public void Insert(string word) => trie.AddWord(word);
    public bool Search(string word) => trie.ContainsWord(word);
    public bool StartsWith(string prefix) => trie.ContainsWord(prefix, true);
}

class TrieNode
{
    private Dictionary<char, TrieNode> nodes;
    public TrieNode()
    {
        nodes = new Dictionary<char, TrieNode>();
    }
    public void AddWord(ReadOnlySpan<char> input)
    {
        nodes.TryAdd(input[0], new TrieNode());
        if (input.Length == 1)
        {
            nodes[input[0]].nodes.TryAdd('\0', new TrieNode());
        }
        else
        {
            nodes[input[0]].AddWord(input.Slice(1));
        }
    }
    public bool ContainsWord(ReadOnlySpan<char> input, bool prefix = false)
    {
        var temp = this;
        for (int i = 0; i < input.Length; i++)
        {
            if (temp is null || !temp.nodes.ContainsKey(input[i])) return false;
            temp = temp.nodes[input[i]];
        }
        return prefix ? true : temp.nodes.ContainsKey('\0');
    }
    public override string ToString() => string.Join(", ", nodes.Select(kv => $"[{kv.Key} => {kv.Value}]"));
}