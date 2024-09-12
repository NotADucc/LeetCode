using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1721 : IRunProgram
    {
        public void Run()
        {
            SwapNodes(ListNodeHelper.New(10), 3).Print();
        }

        public ListNode SwapNodes(ListNode head, int k)
        {
            var lst = new List<ListNode>();
            var slow = head;
            while (slow is not null)
            {
                lst.Add(slow);
                slow = slow.next;
            }

            var n1 = lst[k - 1];
            var n2 = lst[lst.Count - k];
            var temp = n1.val;
            n1.val = n2.val;
            n2.val = temp;

            return head;
        }
    }
}
