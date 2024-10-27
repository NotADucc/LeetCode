
using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2458 : IRunProgram
{
    public void Run()
    {

    }

    // key is root_val, val is lvl
    Dictionary<int, int> lvls = new Dictionary<int, int>();
    // key is root_val, val is 
    Dictionary<int, int> height = new Dictionary<int, int>();
    // key is lvl, value are top 2 heights
    Dictionary<int, int[]> maxes = new Dictionary<int, int[]>();
    public int[] TreeQueries(TreeNode root, int[] queries)
    {
        Traverse(root, 0);
        for (int i = 0; i < queries.Length; i++)
        {
            int query = queries[i];
            int lvl = lvls[query];
            int max = maxes[lvl][0] == height[query] ? maxes[lvl][1] : maxes[lvl][0];
            int val = lvl + max - 1;
            queries[i] = val;
        }
        return queries;
    }

    private int Traverse(TreeNode root, int lvl)
    {
        if (root is null) return lvl;
        lvls.Add(root.val, lvl);

        int max = Math.Max(Traverse(root.left, lvl + 1), Traverse(root.right, lvl + 1));
        int delta = max - lvl;
        height.Add(root.val, delta);
        if (!maxes.ContainsKey(lvl))
        {
            maxes.Add(lvl, [delta, 0]);
        }
        else
        {
            if (maxes[lvl][0] < delta)
            {
                maxes[lvl][1] = maxes[lvl][0];
                maxes[lvl][0] = delta;
            }
            else if (maxes[lvl][1] < delta)
            {
                maxes[lvl][1] = delta;
            }
        }

        return max;
    }
}
