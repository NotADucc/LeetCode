using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0002 : IRunProgram
    {
        private record Input(ListNode l1, ListNode l2);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))))
                ,new Input(new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))), new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))
                ,new Input(new ListNode(1, new ListNode(8)), new ListNode())
                ,new Input(new ListNode(1, new ListNode(9)), new ListNode(9))
            };
            foreach (var input in inputs)
            {
                Console.WriteLine(AddTwoNumbers(input.l1, input.l2));
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 is null && l2 is null)
            {
                return null;
            }

            int val1 = l1?.val ?? 0;
            int val2 = l2?.val ?? 0;

            Helper(val1, val2, out int total, out bool overflow);

            if (overflow)
            {
                l1 ??= new ListNode(0);
                l2 ??= new ListNode(0);
                l1.next ??= new ListNode(0);
                l2.next ??= new ListNode(0);
                l1.next.val++;
            }


            return new ListNode(total, AddTwoNumbers(l1?.next, l2?.next));
        }

        public void Helper(int i1, int i2, out int total, out bool overflow)
        {
            int temp = i1 + i2;
            overflow = temp >= 10;
            total = overflow ? temp - 10 : temp;
        }
    }
}
