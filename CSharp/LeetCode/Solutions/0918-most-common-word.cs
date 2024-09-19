using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0819 : IRunProgram
{
    public void Run()
    {

    }

    public string MostCommonWord(string paragraph, string[] banned)
    {
        var freq = new Dictionary<string, int>();
        string[] para = paragraph.Split([' ', '!', '?', ',', ';', '.'], StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < para.Length; i++)
        {
            string word = para[i].ToLower();
            if (!char.IsLetter(word[0])) word = word.Substring(1);
            if (!char.IsLetter(word[^1])) word = word.Substring(0, word.Length - 1);
            if (!banned.Contains(word) && !freq.TryAdd(word, 1)) freq[word]++;
        }

        return freq.OrderByDescending(x => x.Value).First().Key;
    }
}
