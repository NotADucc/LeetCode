using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0222 : IRunProgram
    {
        public void Run()
        {
            CountNodes(new TreeNode(1, new TreeNode(2)));
        }
        public int CountNodes(TreeNode root)
        {
            int total = 0;

            if (root is null)
            {
                return total;
            }
            total++;
            if (root.left is not null)
            {
                total += CountNodes(root.left);
            }

            if (root.right is not null)
            {
                total += CountNodes(root.right);
            }

            return total;
        }
    }
}
