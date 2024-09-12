using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0226 : IRunProgram
    {
        public void Run()
        {
            InvertTree(new TreeNode(1, new TreeNode(2), new TreeNode(3))).Print();
        }

        public TreeNode InvertTree(TreeNode root)
        {
            Invert(root);
            return root;
        }

        void Invert(TreeNode root)
        {
            if (root is null)
            {
                return;
            }

            var temp = root.right;
            root.right = root.left;
            root.left = temp;

            Invert(root.left);
            Invert(root.right);
        }
    }
}
