using LeetCode.Shared;

namespace LeetCode.CSharp
{
    public class Solution0034 : IRunProgram
    {
        public void Run()
        {
            SearchRange([5, 7, 7, 8, 8, 10], 8);
            SearchRange([5, 7, 7, 8, 8, 10], 6);
            SearchRange([], 0);
        }

        public int[] SearchRange(int[] nums, int target)
        {
            int search = SearchStart(nums, target);
            if (search == -1)
            {
                return [-1, -1];
            }
            else
            {
                int end = SearchEnd(nums, target);

                return [search, end];
            }
        }

        private int SearchStart(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) >> 1;
                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else if (arr[mid] > target || (mid - 1 >= 0 && arr[mid - 1] == target))
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        private int SearchEnd(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) >> 1;
                if (arr[mid] < target || (mid + 1 < arr.Length && arr[mid + 1] == target))
                {
                    left = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
