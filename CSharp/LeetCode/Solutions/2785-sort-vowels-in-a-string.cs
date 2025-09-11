using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;
internal class Solution2785 : IRunProgram
{
    public void Run()
    {

    }

    public unsafe string SortVowels(string s)
    {
        static bool is_vowel(char ch)
            => ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
            || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U';

        var vows = new List<char>();
        var idxs = new List<int>();
        var n = s.Length;

        for (int i = 0; i < n; i++)
        {
            char ch = s[i];
            if (is_vowel(ch))
            {
                vows.Add(ch);
                idxs.Add(i);
            }
        }

        vows.Sort();

        unsafe
        {
            fixed (char* ss = s)
            {
                for (int i = 0; i < vows.Count; i++)
                {
                    int idx = idxs[i];
                    ss[idx] = vows[i];
                }
            }
        }

        return s;
    }
}
