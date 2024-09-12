using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0011 : IRunProgram
    {
        public void Run()
        {
            MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }).Print();
            MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 8 }).Print();
            MaxArea(new int[] { 2, 3, 4, 5, 18, 17, 6 }).Print();
        }

        public int MaxArea(int[] height)
        {
            int output = 0;

            int left = 0, right = height.Length - 1;

            while (left < right)
            {
                int min = Math.Min(height[left], height[right]);
                output = Math.Max(output, min * (right - left));
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return output;
        }

        //TLE
        public int MaxAreaBrute(int[] height)
        {
            int v = 0;
            int l = height.Length;

            for (int i = 0; i < l; i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    int smallerPillar = Math.Min(height[i], height[j]);
                    v = Math.Max(smallerPillar * (j - i), v);
                }
            }

            return v;
        }
    }
}
