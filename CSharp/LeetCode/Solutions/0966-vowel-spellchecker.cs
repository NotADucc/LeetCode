using LeetCode.Solutions.Shared;
using System.Text;
using System.Threading.Tasks.Sources;

namespace LeetCode.Solutions;
internal class Solution0996 : IRunProgram
{
    public void Run()
    {
        Spellchecker(
            ["KiTe", "kite", "kIte", "hare", "Hare"],
            ["kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto"]
        ).Print();

        Spellchecker(
            ["zeo", "Zuo"],
            ["zuo"]
        ).Print();
    }
    public string[] Spellchecker(string[] wordlist, string[] queries)
    {
        static bool is_vowel(char ch)
            => ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';

        static string build_string(string s)
        {
            StringBuilder sb = new();
            foreach (char ch in s)
            {
                char add = is_vowel(ch) ? '_' : ch;
                sb.Append(add);
            }
            return sb.ToString();
        }

        string[] res = new string[queries.Length];
        HashSet<string> eggzact = [];
        Dictionary<string, string> wordlist_vowel = [];
        Dictionary<string, string> wordlist_case = [];

        foreach (string word in wordlist)
        {
            string lower = word.ToLower();
            string vowel = build_string(lower);
            eggzact.Add(word);
            wordlist_case.TryAdd(lower, word);
            wordlist_vowel.TryAdd(vowel, word);
        }

        for (int i = 0; i < queries.Length; i++)
        {
            string word = queries[i];
            if (eggzact.Contains(word))
            {
                res[i] = word;
            }
            else 
            {
                string lower = word.ToLower();
                string vowel = build_string(lower);
                string value = string.Empty;
                if (wordlist_case.TryGetValue(lower, out value))
                    res[i] = value;
                else if (wordlist_vowel.TryGetValue(vowel, out value)) 
                    res[i] = value;
                else res[i] = string.Empty;
            }
        }

        return res;
    }
}
