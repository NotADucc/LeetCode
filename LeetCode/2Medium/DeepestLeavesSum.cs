using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2Medium
{
    internal class DeepestLeavesSum : IRunProgram
    {
        private record Input(TreeNode Data, int Result);
        public void Run()
        {
            Input[] inputs = new Input[] 
            { 
                new Input(new TreeNode(1, new TreeNode(2, new TreeNode(4, new TreeNode(7)), new TreeNode(5)), new TreeNode(3, null, new TreeNode(6, null, new TreeNode(8))))
               , 15)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(Method(input.Data));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }
        public int Method(TreeNode root)
        {
            //TODO
            return 0;
        }
    }
}
