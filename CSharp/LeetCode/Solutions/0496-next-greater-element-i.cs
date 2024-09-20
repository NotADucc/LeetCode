using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0496 : IRunProgram
{
    public void Run()
    {

    }
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var stack = new Stack<int>();
        var dct = new Dictionary<int, int>();
        for (int i = nums2.Length - 1; i >= 0; i--)
        {
            dct[nums2[i]] = i;
            while (stack.Count > 0 && stack.Peek() < nums2[i])
            {
                stack.Pop();
            }
            int temp = stack.Count == 0 ? -1 : stack.Peek();
            stack.Push(nums2[i]);
            nums2[i] = temp;
        }
        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            result[i] = nums2[dct[nums1[i]]];
        }
        return result;
    }

}
