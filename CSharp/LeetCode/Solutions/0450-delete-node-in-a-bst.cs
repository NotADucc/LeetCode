using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0450 : IRunProgram
{
    public void Run()
    {

    }
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        Delete(ref root, key);
        return root;
    }
    private void Delete(ref TreeNode root, int key)
    {
        if (root is null) return;
        if (root.val < key)
        {
            Delete(ref root.right, key);
        }
        else if (root.val > key)
        {
            Delete(ref root.left, key);
        }
        else
        {
            if (root.left is not null)
            {
                var temp = root.right;
                root = root.left;
                if (temp is null) return;
                Append(root, temp);
            }
            else if (root.right is not null)
            {
                var temp = root.left;
                root = root.right;
                if (temp is null) return;
                Append(root, temp);
            }
            else
            {
                root = null;
            }
        }
    }

    private void Append(TreeNode root, TreeNode add)
    {
        if (root.val < add.val)
        {
            if (root.right is null)
            {
                root.right = add;
            }
            else
            {
                Append(root.right, add);
            }
        }
        else if (root.val > add.val)
        {
            if (root.left is null)
            {
                root.left = add;
            }
            else
            {
                Append(root.left, add);
            }
        }
    }
}
