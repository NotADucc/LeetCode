using LeetCode.Shared;

namespace LeetCode.CSharp
{
    public class Solution0078 : IRunProgram
    {
        public void Run()
        {
            Subsets([1, 2, 3]).PrintNested();
            Subsets([0]).PrintNested();
        }

        public IList<IList<int>> Subsets(int[] nums)
        {
            var output = new List<IList<int>>();

            Helper(output, [], nums, 0);

            return output;
        }

        private void Helper(List<IList<int>> output, List<int> current, int[] nums, int index)
        {
            output.Add(new List<int>(current));

            for (int i = index; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                Helper(output, current, nums, i + 1);
                current.Remove(nums[i]);
            }
        }
    }
}
