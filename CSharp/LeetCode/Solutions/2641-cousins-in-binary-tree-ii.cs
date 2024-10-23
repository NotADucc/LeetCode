using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2641 : IRunProgram
{
    public void Run()
    {

    }

    public TreeNode ReplaceValueInTree(TreeNode root) 
    {
        List<int> nums = new List<int>();
        GetSum(root, nums);
        Modify(null, root, nums);
        return root;
    }
    private void GetSum(TreeNode root, List<int> nums, int depth = 0)
    {
        if (root is null) return;

        if (nums.Count <= depth) nums.Add(root.val);
        else nums[depth] += root.val;

        GetSum(root.left, nums, depth + 1);
        GetSum(root.right , nums, depth + 1);
    }
    private void Modify(TreeNode parent, TreeNode child, List<int> nums, int depth = 0) 
    {
        if (child is null) return;
        if (parent is null)
        {
            child.val = 0;
        }
        else 
        {
            int temp = child.val, remove = 0;
            if (parent.left == child && parent.right is not null)
            {
                if (parent.right.val > 0)
                {
                    remove = parent.right.val;
                    parent.right.val += temp;
                }
            }
            else if (parent.right == child && parent.left is not null) 
            {
                if (parent.left.val > 0)
                {
                    remove = parent.left.val;
                    parent.left.val += temp;
                }
                else 
                {
                    parent.left.val = -parent.left.val;
                }
            }
            child.val = nums[depth] - temp - remove;
            if (parent.left == child  && parent.right is not null)
            child.val = -child.val;
        }

        Modify(child, child.left, nums, depth + 1);
        Modify(child, child.right, nums, depth + 1);
    }
}
