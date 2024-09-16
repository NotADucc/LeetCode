using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0567 : IRunProgram
{
    public void Run()
    {
        CheckInclusion("ab", "eidbaoo").Print();
    }
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) { return false; }

        var dct1 = s1
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
        var dct2 = new Dictionary<char, int>();
        for (int i = 0; i < s2.Length; i++)
        {
            dct2.TryAdd(s2[i], 0);
            dct2[s2[i]]++;

            if (i < s1.Length - 1)
            {
                continue;
            }
            else if (i > s1.Length - 1)
            {
                int old = i - s1.Length;
                dct2[s2[old]]--;
            }


            bool full_match = true;
            foreach (var kvp in dct1)
            {
                if (!dct2.ContainsKey(kvp.Key) || dct2[kvp.Key] != kvp.Value)
                {
                    full_match = false;
                    break;
                }
            }
            if (full_match) { return true; }
        }

        return false;
    }
}
