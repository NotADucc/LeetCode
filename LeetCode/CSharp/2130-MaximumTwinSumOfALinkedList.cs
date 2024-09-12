using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution2130 : IRunProgram
    {
        public void Run()
        {
            PairSum(ListNodeHelper.New(10)).Print();
        }

        public int PairSum(ListNode head)
        {
            int max = 0;

            var slow = head;
            var fast = head;

            var temp = new List<int>();
            while (fast?.next is not null)
            {
                temp.Add(slow.val);
                slow = slow.next;
                fast = fast.next.next;
            }

            int i = temp.Count - 1;
            while (slow is not null)
            {
                max = Math.Max(max, temp[i] + slow.val);
                slow = slow.next;
                i--;
            }

            return max;
        }
    }
}
