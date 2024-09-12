using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1302 : IRunProgram
    {
        public void Run()
        {
            DeepestLeavesSum(new TreeNode(1, new TreeNode(2, new TreeNode(4, new TreeNode(7)), new TreeNode(5)), new TreeNode(3, null, new TreeNode(6, null, new TreeNode(8)))));
        }
        int maxDepth = 0;
        int total = 0;
        public int DeepestLeavesSum(TreeNode root)
        {
            maxDepth = 0;
            total = 0;
            GetDepth(root);
            return total;
        }

        public void GetDepth(TreeNode root, int depth = 0)
        {
            depth++;

            if (depth > maxDepth)
            {
                maxDepth = depth;
                total = 0;
            }

            if (root.left is not null)
            {
                GetDepth(root.left, depth);
            }

            if (root.right is not null)
            {
                GetDepth(root.right, depth);
            }

            if (depth == maxDepth)
            {
                total += root.val;
            }
        }
    }
}
