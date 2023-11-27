using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    public class MaxDepthBinaryTree : IRunProgram
    {
        private record Input(TreeNode Root, int Result);
        public void Run()
        {
            Input[] inputs = new Input[] 
            { 
                new Input(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))), 3)
                ,new Input(new TreeNode(1, new TreeNode(2)), 2)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(MaxDepth(input.Root));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }

        private int _max;
        public int MaxDepth(TreeNode root)
        {
            if (root is null) 
            {
                return 0;
            }
            int depth = GetDepth(root, 1);
            _max = 0;
            return depth;
        }
        public int GetDepth(TreeNode root, int depth)
        {
            if (root is null)
            {
                return depth;
            }

            if (root.left is not null)
            {
                GetDepth(root.left, depth + 1);
            }

            if (root.right is not null)
            {
                GetDepth(root.right, depth + 1);
            }

            _max = Math.Max(_max, depth);
            return _max;
        }
    }
}
