using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3760 : IRunProgram
{
    public void Run()
    {

    }

    public int MaxDistinct(string s)
    {
        return new HashSet<char>(s).Count;
    }
}
