using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1367 : IRunProgram
    {
        public void Run()
        {
            
        }
        public bool IsSubPath(ListNode head, TreeNode root, bool seeking_match = false)
        {
            if (root is null) { return head is null; }
            if (head is null) { return true; }

            bool result = false;

            if (root.val == head.val)
            {
                result = IsSubPath(head.next, root.left, true) || IsSubPath(head.next, root.right, true);
                if (result) { return true; }
            }

            if (!seeking_match)
            {
                result = IsSubPath(head, root.left) || IsSubPath(head, root.right);
            }

            return result;
        }
    }
}
