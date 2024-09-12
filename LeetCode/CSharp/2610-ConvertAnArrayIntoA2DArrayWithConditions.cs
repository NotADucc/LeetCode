using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution2610 : IRunProgram
    {
        public void Run()
        {
            FindMatrix([1, 3, 4, 1, 2, 3, 1]).PrintNested();
        }

        public IList<IList<int>> FindMatrix(int[] nums)
        {
            //key is value
            //value is index
            var dct = new Dictionary<int, int>();
            var output = new List<IList<int>>()
        {
            new List<int>(),
        };
            foreach (int num in nums)
            {
                if (!dct.ContainsKey(num))
                {
                    dct.Add(num, 0);
                }
                else
                {
                    dct[num]++;
                }
                if (dct[num] > output.Count - 1)
                {
                    output.Add(new List<int>());
                }
                output[dct[num]].Add(num);
            }

            return output;
        }
    }
}
