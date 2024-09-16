using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0242 : IRunProgram
{
    public void Run()
    {
        IsAnagram("", "").Print();
        IsAnagram("rat", "car").Print();
        IsAnagram("anagram", "nagaram").Print();
    }

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) { return false; }
        var dct = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            dct.TryAdd(s[i], 0);
            dct.TryAdd(t[i], 0);
            dct[s[i]]++;
            dct[t[i]]--;
        }

        return dct.Values.All(x => x == 0);
    }
}
