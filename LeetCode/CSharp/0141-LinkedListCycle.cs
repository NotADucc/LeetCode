﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0141 : IRunProgram
    {
        public void Run()
        {
            HasCycle(ListNodeHelper.New(5)).Print();
        }
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast is not null)
            {
                slow = slow.next;
                fast = fast.next?.next;

                if (slow is not null && fast is not null && slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}