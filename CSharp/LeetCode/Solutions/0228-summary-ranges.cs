using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0228 : IRunProgram
{
    public void Run()
    {
        SummaryRanges([0]).Print();
        SummaryRanges([0, 1, 2, 4, 5, 7]).Print();
    }

    public List<string> SummaryRanges(int[] nums)
    {
        List<string> output = new List<string>();

        if (nums.Length == 0)
        {
            return output;
        }

        int start = nums[0];
        int offset = 0;


        for (int i = 0; i < nums.Length; i++, offset++)
        {
            if (start + offset == nums[i])
            {
                continue;
            }

            string temp = offset == 1 ? start.ToString() : $"{start}->{start + offset - 1}";
            output.Add(temp);

            start = nums[i];
            offset = 0;
        }

        string temp2 = offset == 1 ? start.ToString() : $"{start}->{start + offset - 1}";
        output.Add(temp2);

        return output;
    }
}
