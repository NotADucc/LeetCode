using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0101 : IRunProgram
    {
        public void Run()
        {
            IsSymmetric(new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)))).Print();
            IsSymmetric(new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3)))).Print();
        }
        public bool IsSymmetric(TreeNode root)
        {
            return Helper(root.left, root.right);
        }
        private bool Helper(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode is null || rightNode is null)
            {
                return leftNode == rightNode;
            }

            if (leftNode.val != rightNode.val)
            {
                return false;
            }

            return Helper(leftNode.left, rightNode.right) && Helper(leftNode.right, rightNode.left);
        }
    }
}
