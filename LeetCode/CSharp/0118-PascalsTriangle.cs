using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0118 : IRunProgram
    {
        public void Run()
        {
            Generate(5).PrintNested();
            Generate(1).PrintNested();
        }

        public IList<IList<int>> Generate(int numRows)
        {
            var output = new List<IList<int>>(numRows);
            output.Add(new List<int>() { 1 });
            for (int i = 1; i < numRows; i++)
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
            return output;
        }
    }
}
