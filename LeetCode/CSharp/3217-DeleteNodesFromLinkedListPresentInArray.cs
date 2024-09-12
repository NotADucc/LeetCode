using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution3217 : IRunProgram
    {
        public void Run()
        {
            ModifiedList([1, 2, 3], ListNodeHelper.New(5)).Print();
        }

        public ListNode ModifiedList(int[] nums, ListNode head)
        {
            HashSet<int> delete = new HashSet<int>(nums);

            Helper(delete, head, null);

            return head;
        }

        private void Helper(HashSet<int> nums, ListNode head, ListNode prev)
        {
            if (head is null)
            {
                return;
            }

            if (nums.Contains(head.val))
            {
                if (head.next is not null)
                {
                    head.val = head.next.val;
                    head.next = head.next.next;
                }
                else
                {
                    head.val = prev.val;
                    prev.next = prev.next.next;
                }

                Helper(nums, head, prev);
            }
            else
            {
                Helper(nums, head.next, prev = head);
            }
        }
    }
}
