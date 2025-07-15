using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3136 : IRunProgram
{
    public void Run()
    {

    }

    public bool IsValid(string word)
    {
        if (word.Length < 3) return false;
        bool has_vowel = false, has_cons = false;

        foreach (var ch in word)
        {
            if (!char.IsLetterOrDigit(ch)) return false;
            has_vowel |= "aeiouAEIOU".Contains(ch);
            has_cons |= "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains(ch);
        }

        return has_vowel && has_cons;
    }
}
