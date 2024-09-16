using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0040 : IRunProgram
{
    public void Run()
    {
        CombinationSum2([10, 1, 2, 7, 6, 1, 5], 8).PrintNested();
        CombinationSum2([2, 5, 2, 1, 2], 5).PrintNested();
    }

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
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
            if (index < cand.Length)
            {
                Helper(lst, [.. temp, cand[index]], cand, target - cand[index], index + 1);
                int add = 1;
                for (int i = index; index + add < cand.Length && cand[index] == cand[index + add]; add++) { }
                Helper(lst, [.. temp], cand, target, index + add);
            }
        }
    }
}
