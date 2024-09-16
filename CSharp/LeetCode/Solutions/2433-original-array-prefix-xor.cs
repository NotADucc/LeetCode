using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2433 : IRunProgram
{
    public void Run()
    {
        FindArray([5, 2, 0, 3, 1]).Print();
    }
    public int[] FindArray(int[] pref)
    {
        int temp = pref[0];
        for (int i = 1; i < pref.Length; i++)
        {
            int t = pref[i];
            pref[i] = temp ^ pref[i];
            temp = t;
        }
        return pref;
    }
    public int[] FindArray2Arr(int[] pref)
    {
        int[] output = new int[pref.Length];
        output[0] = pref[0];
        for (int i = 1; i < pref.Length; i++)
        {
            output[i] = pref[i - 1] ^ pref[i];
        }
        return output;
    }
}
