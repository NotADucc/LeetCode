using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1261 : IRunProgram
{
    public void Run()
    {

    }

    public class FindElements
    {
        HashSet<int> set = [];
        public FindElements(TreeNode root)
        {
            Rec(root, 0);
        }

        private void Rec(TreeNode root, int val)
        {
            if (root is null)
                return;

            set.Add(val);
            if (root.left is not null)
            {
                Rec(root.left, val * 2 + 1);
            }

            if (root.right is not null)
            {
                Rec(root.right, val * 2 + 2);
            }
        }

        public bool Find(int target)
        {
            return set.Contains(target);
        }
    }
}
