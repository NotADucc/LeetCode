using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1233 : IRunProgram
{
    public void Run()
    {

    }
    public IList<string> RemoveSubfolders(string[] folder)
    {
        var output = new List<string>();
        var trie = new Trie();

        foreach (string sub in folder)
        {
            trie.Add(sub.AsSpan().Slice(1));
        }

        foreach (string sub in folder)
        {
            if (!trie.IsSub(sub.AsSpan().Slice(1)))
            {
                output.Add(sub);
            }
        }

        return output;
    }

    class Trie
    {
        private Trie[] children;
        private bool end = false;
        public Trie()
        {
            children = new Trie[27];
        }
        public void Add(ReadOnlySpan<char> input)
        {
            var trie = this;
            foreach (char ch in input)
            {
                int index = ch == '/' ? 26 : ch - 'a';
                if (trie.children[index] is null)
                {
                    trie.children[index] = new Trie();
                }
                trie = trie.children[index];
            }
            trie.end = true;
        }

        public bool IsSub(ReadOnlySpan<char> input)
        {
            var trie = this;
            for (int i = 0; i < input.Length; i++)
            {
                int index = input[i] == '/' ? 26 : input[i] - 'a';
                if (trie.children[index].end && i + 1 < input.Length)
                {
                    if (input[i + 1] == '/')
                        return true;
                }
                trie = trie.children[index];
            }

            return false;
        }
    }
}