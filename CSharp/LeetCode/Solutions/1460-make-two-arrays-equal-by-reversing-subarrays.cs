using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1460 : IRunProgram
{
    public void Run()
    {
        CanBeEqual([1, 2, 3, 4], [2, 4, 1, 3]).Print();
    }
    public bool CanBeEqualCheese(int[] target, int[] arr)
    {
        double t = 0;
        for (int i = 0; i < target.Length; i++)
        {
            t += Math.Pow(target[i], 2.1) - Math.Pow(arr[i], 2.1);
        }
        return (int)t == 0;
    }

    public bool CanBeEqual(int[] target, int[] arr)
    {
        //key is value
        //value is freq
        var dct = new Dictionary<int, int>();
        foreach (var targetValue in target)
        {
            dct.TryAdd(targetValue, 0);
            dct[targetValue]++;
        }
        foreach (var arrValue in arr)
        {
            if (dct.TryGetValue(arrValue, out int freq))
            {
                freq--;
                if (freq == 0)
                {
                    dct.Remove(arrValue);
                }
                else
                {
                    dct[arrValue] = freq;
                }
            }
            else
            {
                return false;
            }
        }


        return dct.Count == 0;
    }
}
