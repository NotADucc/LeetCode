using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0205 : IRunProgram
{
    public void Run()
    {
        IsIsomorphic("egg", "add").Print();
        IsIsomorphic("foo", "bar").Print();
    }
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, char> dctS = new Dictionary<char, char>();
        Dictionary<char, char> dctT = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dctS.ContainsKey(s[i]))
            {
                dctS.Add(s[i], t[i]);
            }
            if (!dctT.ContainsKey(t[i]))
            {
                dctT.Add(t[i], s[i]);
            }
            if (dctS[s[i]] != t[i] || dctT[t[i]] != s[i])
            {
                return false;
            }
        }

        return true;
    }
}
