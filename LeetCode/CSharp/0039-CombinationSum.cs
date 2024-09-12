using LeetCode.Shared;

namespace LeetCode.CSharp;

public class Solution0039 : IRunProgram
{
    public void Run()
    {
        CombinationSum([2, 3, 6, 7], 7).PrintNested();
        CombinationSum([2], 1).PrintNested();
    }

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
        var output = new List<IList<int>>();

        Helper(output, [], candidates, target, 0);

        return output;
    }

    private void Helper(List<IList<int>> lst, List<int> temp, int[] cand, int target, int index)
    {
        if (target < 0)
        {
            return;
        }
        else if (target == 0)
        {
            lst.Add(temp);
        }
        else
        {
            while (index < cand.Length)
            {
                Helper(lst, [.. temp, cand[index]], cand, target - cand[index], index);
                index++;
            }
        }
    }
}
