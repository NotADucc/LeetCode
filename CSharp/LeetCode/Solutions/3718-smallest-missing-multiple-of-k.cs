using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3718 : IRunProgram
{
    public void Run()
    {

    }

    public int MissingMultiple(int[] nums, int k)
    {
        HashSet<int> set = new HashSet<int>(nums);

        for (int i = 1; ; i++)
        {
            int num = k * i;
            if (!set.Contains(num))
                return num;
        }

        return -1;
    }
}
