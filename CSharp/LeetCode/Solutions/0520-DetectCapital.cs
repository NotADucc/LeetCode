using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0520 : IRunProgram
{
    public void Run()
    {
        DetectCapitalUse("usa").Print();
        DetectCapitalUse("USA").Print();
    }
    public bool DetectCapitalUse(string word)
    {
        return word.Equals(word.ToUpper()) || word[1..].Equals(word[1..].ToLower());
    }
}
