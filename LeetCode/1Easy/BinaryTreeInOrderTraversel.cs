using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    public class BinaryTreeInOrderTraversel : IRunProgram
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
            List<int> output = new List<int>();

            Helper(root, output);

            return output;
        }
        private void Helper(TreeNode root, List<int> output)
        {
            if (root is null)
            {
                return;
            }

            Helper(root.left, output);

            output.Add(root.val);

            Helper(root.right, output);
        }
    }
}
