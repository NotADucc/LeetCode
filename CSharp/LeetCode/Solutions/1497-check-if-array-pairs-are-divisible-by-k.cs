using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1497 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool CanArrange(int[] arr, int k)
    {
        //key is remainder
        //value is freq
        var freq = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int remainder = ((arr[i] % k) + k) % k;
            if (!freq.TryAdd(remainder, 1)) freq[remainder]++;
        }

        foreach (var kvp in freq)
        {
            int key = kvp.Key;
            int value = kvp.Value;
            if (key == 0)
            {
                if ((value & 1) == 1) return false;
            }
            else
            {
                int rem = k - key;
                if (!freq.ContainsKey(rem) || freq[rem] != value)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
