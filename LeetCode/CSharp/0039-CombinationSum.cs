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
        var output = new List<IList<int>>();

        Helper(output, [], candidates, target, 0);

        return output;
    }

    private void Helper(List<IList<int>> lst, List<int> current, int[] candidates, int target, int index)
    {
        if (target < 0)
        {
            return;
        }
        else if (target == 0)
        {
            lst.Add(new List<int>(current));
        }
        else
        {
            for (; index < candidates.Length; index++)
            {
                current.Add(candidates[index]);
                Helper(lst, current, candidates, target - candidates[index], index);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
