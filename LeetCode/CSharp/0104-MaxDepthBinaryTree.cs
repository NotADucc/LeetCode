using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0104 : IRunProgram
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

        public int MaxDepth(TreeNode root)
        {
            int max = 0;
            Helper(root, ref max);
            return max;
        }

        private void Helper(TreeNode root, ref int max, int curr = 0)
        {
            if (root is null)
            {
                return;
            }

            curr++;
            max = Math.Max(max, curr);

            Helper(root.left, ref max, curr);
            Helper(root.right, ref max, curr);
        }
    }
}
