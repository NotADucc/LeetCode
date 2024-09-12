using LeetCode.Shared;

namespace LeetCode.CSharp
{
    public class Solution0047 : IRunProgram
    {
        public void Run()
        {
            PermuteUnique([1, 2, 2, 2, 3]).PrintNested();
            PermuteUnique([0, 1, 1]).PrintNested();
            PermuteUnique([0]).PrintNested();
        }

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            var output = new List<IList<int>>();
            Helper(output, nums, []);
            return output;
        }

        private void Helper(List<IList<int>> output, int[] nums, List<int> current)
        {
            if (nums.Length == 0)
            {
                output.Add(new List<int>(current));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i > 0 && nums[i] == nums[i - 1])
                    {
                        continue;
                    }
                    current.Add(nums[i]);
                    Helper(output, [.. nums[..i], .. nums[(i + 1)..]], current);
                    int last = current.LastIndexOf(nums[i]);
                    current.RemoveAt(last);
                }
            }
        }
    }
}
