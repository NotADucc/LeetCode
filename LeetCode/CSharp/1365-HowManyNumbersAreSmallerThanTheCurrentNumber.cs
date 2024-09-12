using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1365 : IRunProgram
    {
        public void Run()
        {
            SmallerNumbersThanCurrent([8, 1, 2, 2, 3]).Print();
        }
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            //key is value
            //value is index
            var dct = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dct.ContainsKey(nums[i]))
                {
                    dct.Add(nums[i], new List<int>());
                }
                dct[nums[i]].Add(i);
            }

            Array.Sort(nums);
            var output = new int[nums.Length];

            int w1 = 0, w2 = 1, diff = 0;

            while (w1 < nums.Length)
            {
                if (w2 >= nums.Length)
                {
                    var indexes = dct[nums[w1]];
                    foreach (int i in indexes)
                    {
                        output[i] = diff;
                    }
                    break;
                }

                if (nums[w1] < nums[w2])
                {
                    var indexes = dct[nums[w1]];
                    foreach (int i in indexes)
                    {
                        output[i] = diff;
                    }
                    diff += indexes.Count;
                    w1 += indexes.Count;
                    w2 = w1 + 1;
                }
                else if (nums[w1] == nums[w2])
                {
                    w2++;
                }
                else
                {
                    w1++;
                    w2 = w1 + 1;
                }
            }

            return output;
        }
    }
}
