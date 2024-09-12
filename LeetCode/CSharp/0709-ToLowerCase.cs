using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0709: IRunProgram
{
    public void Run()
    {
        ToLowerCase("AAAAA").Print();
    }
    public string ToLowerCase(string s)
    {
        return s.ToLower();
    }
}
