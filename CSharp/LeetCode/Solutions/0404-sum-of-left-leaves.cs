﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0404 : IRunProgram
{
    public void Run()
    {
        SumOfLeftLeaves(new TreeNode(1, new TreeNode(5))).Print();
        SumOfLeftLeaves(new TreeNode(1)).Print();
    }

    public int SumOfLeftLeaves(TreeNode root, bool is_left = false)
    {
        if (root is null)
        {
            return 0;
        }

        if (root.left is null && root.right is null && is_left)
        {
            return root.val;
        }

        return SumOfLeftLeaves(root.left, true) + SumOfLeftLeaves(root.right, false);
    }
}
