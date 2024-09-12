using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0938: IRunProgram
    {
        public void Run()
        {
            
        }

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root is null)
            {
                return 0;
            }

            return (root.val >= low && root.val <= high ? root.val : 0) + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }
}
