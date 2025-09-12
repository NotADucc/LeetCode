using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3227 : IRunProgram
{
    public void Run()
    {

    }

    public bool DoesAliceWin(string s)
    {
        static bool is_vowel(char ch)
            => ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
            || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U';

        foreach (char ch in s)
        {
            if (is_vowel(ch))
                return true;
        }

        return false;
    }
}
