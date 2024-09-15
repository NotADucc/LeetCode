using LeetCode.Shared;
using System.Numerics;

namespace LeetCode.CSharp;

internal class Solution1672 : IRunProgram
{
    public void Run()
    {
        MaximumWealth([[1, 2, 3],[3, 2, 1]]).Print();
    }

    public int MaximumWealth(int[][] accounts)
    {
        int l = accounts.Length;
        int[] totals = new int[l];

        for (int i = 0; i < l; i++)
        {
            totals[i] = accounts[i].Sum();
        }

        return totals.Max();
    }

    public int MaximumWealthNoBuiltInMethods(int[][] accounts)
    {
        int l = accounts.Length;
        int max = int.MinValue;

        for (int i = 0; i < l; i++)
        {
            int temp = SumArray(accounts[i]);
            if (temp > max)
            {
                max = temp;
            }
        }

        return max;
    }
    public int SumArray(int[] arr) 
    {
        var vSize = Vector<int>.Count;
        int result = 0;
        int i = 0;
        for (; i <= arr.Length - vSize; i += vSize)
        {
            var v1 = new Vector<int>(arr, i);
            result += Vector.Sum<int>(v1);
        }
        for (; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result;
    }
}
