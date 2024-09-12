using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1282 : IRunProgram
    {
        public void Run()
        {
            GroupThePeople([3, 3, 3, 3, 3, 1, 3]).PrintNested();
        }
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            //key is size
            //value is index of list
            var dct = new Dictionary<int, int>();
            var output = new List<IList<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                int size = groupSizes[i];
                if (!dct.ContainsKey(size))
                {
                    dct.Add(size, output.Count);
                    output.Add(new List<int>() { });
                }

                int index = dct[size];
                output[index].Add(i);

                if (size <= output[index].Count)
                {
                    dct.Remove(size);
                }
            }

            return output;
        }
    }
}
