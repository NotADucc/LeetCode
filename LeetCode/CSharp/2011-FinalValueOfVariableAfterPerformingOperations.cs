using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution2011 : IRunProgram
    {
        public void Run()
        {
            FinalValueAfterOperations(["--X", "X++", "X++"]).Print();
        }
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            foreach (var item in operations)
            {
                if (item[0] == '-' || item[^1] == '-')
                {
                    x--;
                }
                else
                {
                    x++;
                }
            }
            return x;
        }
    }
}
