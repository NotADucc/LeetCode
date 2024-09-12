using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0111 : IRunProgram
    {
        public void Run()
        {
            MinDepth(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))).Print();
        }

        public int MinDepth(TreeNode root)
        {
            if (root is null) { return 0; }
            int depth = int.MaxValue;
            Helper(root, ref depth, 0);
            return depth;
        }

        public void Helper(TreeNode root, ref int depth, int curr)
        {
            if (root is null)
            {
                return;
            }

            curr++;

            if (root.left is null && root.right is null)
            {
                depth = Math.Min(depth, curr);
            }

            Helper(root.left, ref depth, curr);
            Helper(root.right, ref depth, curr);
        }
    }
}
