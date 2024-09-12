using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Solution0101 : IRunProgram
    {
        private record Input(TreeNode Root, bool Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3))), true)
                , new Input(new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3))), false)
                , new Input(new TreeNode(1, new TreeNode(2, new TreeNode(2)), new TreeNode(2, new TreeNode(2))), false)
            };
            foreach (var input in inputs)
            {
                Console.WriteLine(IsSymmetric(input.Root));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
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

            bool b = true;

            b = Helper(leftNode.left, rightNode.right);
            if (b)
            {
                b = Helper(leftNode.right, rightNode.left);
            }

            return b;
        }
    }
}
