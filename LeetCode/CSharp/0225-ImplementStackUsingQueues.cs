﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0225 : IRunProgram
    {
        public void Run()
        {

        }
    }

    public class MyStack
    {
        Queue<int> q1;

        public MyStack()
        {
            q1 = new Queue<int>();
        }

        public void Push(int x)
        {
            q1.Enqueue(x);
            for (int i = 0; i < q1.Count - 1; i++)
            {
                q1.Enqueue(q1.Dequeue());
            }
        }

        public int Pop()
        {
            return q1.Dequeue();
        }

        public int Top()
        {
            return q1.Peek();
        }

        public bool Empty()
        {
            return q1.Count == 0;
        }
    }
}