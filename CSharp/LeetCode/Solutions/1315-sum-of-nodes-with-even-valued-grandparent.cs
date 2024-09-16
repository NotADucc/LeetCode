using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1315 : IRunProgram
{
    public void Run()
    {

    }
    public int SumEvenGrandparent(TreeNode root)
    {
        int sum = 0;
        Helper(root, ref sum);
        return sum;
    }

    private void Helper(TreeNode root, ref int sum)
    {
        if (root is null)
        {
            return;
        }

        if (IsEven(root.val))
        {
            if (root.left is not null)
            {
                sum += root.left.left?.val ?? 0;
                sum += root.left.right?.val ?? 0;
            }
            if (root.right is not null)
            {
                sum += root.right.left?.val ?? 0;
                sum += root.right.right?.val ?? 0;
            }
        }
        Helper(root.left, ref sum);
        Helper(root.right, ref sum);
    }
    private bool IsEven(int input) => (input & 1) == 0;
}
