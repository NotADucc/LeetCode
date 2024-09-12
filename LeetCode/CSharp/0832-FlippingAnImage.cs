using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0832: IRunProgram
    {
        public void Run()
        {
            FlipAndInvertImage([[1, 1, 0], [1, 0, 1], [0, 0, 0]]).Print();
        }
        public int[][] FlipAndInvertImage(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                int left = 0;
                int right = image.Length - 1;

                while (left < right)
                {
                    int temp = image[i][left];
                    image[i][left] = Flip(image[i][right]);
                    image[i][right] = Flip(temp);

                    left++;
                    right--;
                }

                if ((image.Length & 1) == 1)
                {
                    image[i][(image.Length >> 1)] = Flip(image[i][(image.Length >> 1)]);
                }
            }

            return image;
        }

        public int Flip(int input)
        {
            return input == 0 ? 1 : 0;
        }
    }
}
