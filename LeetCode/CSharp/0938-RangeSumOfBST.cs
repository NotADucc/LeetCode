using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0938: IRunProgram
    {
        public void Run()
        {
            
        }

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root is null)
            {
                return 0;
            }

            return (root.val >= low && root.val <= high ? root.val : 0) + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }
}
