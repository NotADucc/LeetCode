using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0094 : IRunProgram
    {
        private record Input(TreeNode Root, List<int> Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new TreeNode(1, null, new TreeNode(2, new TreeNode(3))), new List<int>(){ 1, 3, 2 })
                , 
            };
            foreach (var input in inputs)
            {
                InorderTraversal(input.Root).Print();
                input.Result.Print();
                Console.WriteLine();
            }
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            var output = new List<int>();
            Helper(output, root);
            return output;
        }

        private void Helper(List<int> output, TreeNode root)
        {
            if (root is null)
            {
                return;
            }

            Helper(output, root.left);
            output.Add(root.val);
            Helper(output, root.right);
        }
    }
}
