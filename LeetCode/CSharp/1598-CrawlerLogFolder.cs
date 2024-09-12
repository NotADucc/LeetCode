using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1598 : IRunProgram
    {
        public void Run()
        {
            MinOperations(["d1/", "d2/", "../", "d21/", "./"]).Print();
        }
        public int MinOperations(string[] logs)
        {
            var output = 0;
            foreach (var log in logs)
            {
                if (log.Equals("../") && output > 0)
                {
                    output--;
                }
                else if (log.Equals("./") || (log.Equals("../") && output == 0)) { }
                else
                {
                    output++;
                }
            }
            return output;
        }
    }
}
