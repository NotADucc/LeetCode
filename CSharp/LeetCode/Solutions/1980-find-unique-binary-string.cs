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
        {
            int num = Convert.ToInt32(nums[i], 2);
            set.Add(num);
        }

        int output = 1;
        for (int i = 0; i < nums.Length * nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                output = i;
                break;
            }
        }

        string s = Convert.ToString(output, 2);

        return new string('0', nums.Length - s.Length) + s;
    }
}
