using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0119 : IRunProgram
    {
        public void Run()
        {
            GetRow(5).Print();
            GetRow(1).Print();
        }

        public IList<int> GetRow(int rowIndex)
        {
            rowIndex++;
            var output = new List<IList<int>>(rowIndex)
            {
                new List<int>() { 1 }
            };
            for (int i = 1; i < rowIndex; i++)
            {
                var temp = new List<int>();
                temp.Add(1);
                for (int j = 1; j < i; j++)
                {
                    temp.Add(output[i - 1][j - 1] + output[i - 1][j]);
                }
                temp.Add(1);
                output.Add(temp);
            }
            return output[^1];
        }
    }
}
