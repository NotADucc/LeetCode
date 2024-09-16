using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0387 : IRunProgram
{
    public void Run()
    {
        FirstUniqChar("leetcode").Print();
        FirstUniqChar("aabb").Print();
    }
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!freq.TryAdd(s[i], i))
            {
                freq[s[i]] = -1;
            }
        }

        return freq.FirstOrDefault(x => x.Value > -1, defaultValue: new KeyValuePair<char, int>('&', -1)).Value;
    }
}
