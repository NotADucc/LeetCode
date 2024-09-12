using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1385 : IRunProgram
    {
        public void Run()
        {
            FindTheDistanceValue([4, 5, 8], [10, 9, 1, 8], 1).Print();
        }
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            Array.Sort(arr2);
            int output = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                int arr1val = arr1[i];
                int arr2Index = ClosestValue(arr2, arr1val);
                if (arr2Index == -1)
                {
                    int j = 0;
                    for (; j < arr2.Length; j++)
                    {
                        int delta = Math.Abs(arr1val - arr2[j]);
                        if (delta <= d)
                        {
                            break;
                        }
                    }
                    output = j < arr2.Length ? output : output + 1;
                }
                else
                {
                    int delta = Math.Abs(arr1val - arr2[arr2Index]);
                    if (delta > d)
                    {
                        output++;
                    }
                }
            }

            return output;
        }

        int ClosestValue(int[] arr, int s)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;

                if (s > arr[m])
                {
                    l = m + 1;
                }
                else if (s < arr[m])
                {
                    r = m - 1;
                }
                else
                {
                    return m;
                }
            }
            return -1;
        }
    }
}
