using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0763: IRunProgram
{
    public void Run()
    {
        PartitionLabels("ababcbacadefegdehijhklij").Print();
    }
    public IList<int> PartitionLabels(string s)
    {
        var res = new List<int>();
        var freq = new int[26];
        var set = new HashSet<char>();
        int n = s.Length, last_idx = -1;

        foreach (char ch in s) freq[ch - 'a']++;

        for (int i = 0; i < n; i++)
        {
            char ch = s[i];
            int idx = ch - 'a';
            freq[idx]--;
            bool _ = freq[idx] == 0 ? set.Remove(ch) : set.Add(ch);

            if (set.Count == 0)
            {
                res.Add(i - last_idx);
                last_idx = i;
            }
        }

        return res;
    }
}
