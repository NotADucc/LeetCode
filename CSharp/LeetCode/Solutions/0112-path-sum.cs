﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0112 : IRunProgram
{
    public void Run()
    {
        HasPathSum(new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))), new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1)))), 22).Print();
        HasPathSum(new TreeNode(1, new TreeNode(2), new TreeNode(3)), 5).Print();
    }

    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root is null)
        {
            return false;
        }

        if (root.val == targetSum && root.left is null && root.right is null)
        {
            return true;
        }

        return GetSum(root, root.val, targetSum);
    }
    private static bool GetSum(TreeNode r, int c, int t)
    {
        bool b = false;

        if (r.left is not null)
        {
            int temp = r.left.val + c;

            if (r.left.left is null && r.left.right is null)
            {
                b = temp == t;
            }
            if (!b)
            {
                b = GetSum(r.left, temp, t);
            }
        }

        if (r.right is not null)
        {
            int temp = r.right.val + c;

            if (r.right.left is null && r.right.right is null)
            {
                b = temp == t;
            }
            if (!b)
            {
                b = GetSum(r.right, temp, t);
            }
        }

        return b;
    }
}
