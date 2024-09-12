using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1763 : IRunProgram
    {
        public void Run()
        {
            LongestNiceSubstring("YazaAay").Print();
            LongestNiceSubstring("Bb").Print();
        }

        public string LongestNiceSubstring(string s)
        {
            var set = new HashSet<char>();
            int start = 0, len = 0;
            bool is_nice = false;

            for (int i = 0; i < s.Length; i++)
            {
                set.Clear();
                for (int j = i; j < s.Length; j++)
                {
                    set.Add(s[j]);
                    if (char.IsLower(s[j]))
                    {
                        is_nice = set.Contains((char)(s[j] - 32));
                    }
                    else
                    {
                        is_nice = set.Contains((char)(s[j] + 32));
                    }

                    if (is_nice && j - i + 1 > len)
                    {
                        Span<int> freq = stackalloc int[26];
                        foreach (var ch in set)
                        {
                            freq[char.ToLower(ch) - 'a']++;
                        }
                        int k = 0;
                        for (; k < freq.Length; k++)
                        {
                            if (freq[k] == 1)
                            {
                                break;
                            }
                        }

                        if (k == freq.Length)
                        {
                            start = i;
                            len = j - i + 1;
                        }
                    }
                }
            }

            return s.Substring(start, len);
        }
    }
}
