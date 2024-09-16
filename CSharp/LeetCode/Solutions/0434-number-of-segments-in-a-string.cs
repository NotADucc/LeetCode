using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0434 : IRunProgram
{
    public void Run()
    {
        
    }
    public int CountSegments(string s)
    {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();
    }
}
