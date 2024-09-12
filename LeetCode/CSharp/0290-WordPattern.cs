using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0290 : IRunProgram
    {
        public void Run()
        {
            WordPattern("abba", "dog cat cat dog").Print();
            WordPattern("abba", "dog cat cat fish").Print();
        }

        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dct = new Dictionary<char, string>();
            Dictionary<string, char> dct2 = new Dictionary<string, char>();
            var split = s.Split();
            if (split.Length != pattern.Length)
            {
                return false;
            }
            for (int i = 0; i < pattern.Length; i++)
            {
                if ((dct.ContainsKey(pattern[i]) && !dct[pattern[i]].Equals(split[i])) || (dct2.ContainsKey(split[i]) && !dct2[split[i]].Equals(pattern[i])))
                {
                    return false;
                }
                if (dct.ContainsKey(pattern[i]) || dct2.ContainsKey(split[i]))
                {
                    continue;
                }
                dct.Add(pattern[i], split[i]);
                dct2.Add(split[i], pattern[i]);
            }
            return true;
        }
    }
}
