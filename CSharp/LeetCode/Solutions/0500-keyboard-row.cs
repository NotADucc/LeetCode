using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0500 : IRunProgram
{
    public void Run()
    {

    }
    public string[] FindWords(string[] words)
    {
        Span<int> keeb = [1, 2, 2, 1, 0, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 0, 0, 1, 0, 0, 2, 0, 2, 0, 2];
        List<string> ans = [];
        foreach (string word in words)
        {
            string cleaned = word.ToLower();
            int check = keeb[cleaned[0] - 'a'];
            bool is_valid = true;
            for (int i = 1; i < cleaned.Length; i++)
            {
                if (check != keeb[cleaned[i] - 'a'])
                {
                    is_valid = false;
                    break;
                }
            }
            if (is_valid)
                ans.Add(word);
        }

        return ans.ToArray();
    }
    public string[] FindWordsSimplified(string[] words)
    {
        int[] keeb = [1, 2, 2, 1, 0, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 0, 0, 1, 0, 0, 2, 0, 2, 0, 2];
        return [.. words.Where(x =>
        {
            string cleaned = x.ToLower();
            int check = keeb[cleaned[0] - 'a'];
            return cleaned.All(x => keeb[x - 'a'] == check);
        })];
    }
}
