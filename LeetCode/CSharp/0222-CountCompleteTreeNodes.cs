﻿using LeetCode.Shared;
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
            if (root is null)
            {
                return 0;
            }

            return CountNodes(root.left) + CountNodes(root.right) + 1;
        }
    }
}