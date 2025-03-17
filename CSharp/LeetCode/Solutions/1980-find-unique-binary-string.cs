using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1980 : IRunProgram
{
    public void Run()
    {
        FindDifferentBinaryString(["01", "10"]).Print();
        FindDifferentBinaryString(["00", "10"]).Print();
    }
    public string FindDifferentBinaryString(string[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
            set.Add(Convert.ToInt32(nums[i], 2));

        int res = 0;
        while (true)
        {
            if (!set.Contains(res))
                break;
            res++;
        }

        string s = Convert.ToString(res, 2);

        return $"{new string('0', nums.Length - s.Length)}{s}";
    }
}
