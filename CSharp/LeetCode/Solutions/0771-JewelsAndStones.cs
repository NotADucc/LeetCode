using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0771: IRunProgram
{
    public void Run()
    {
        NumJewelsInStones("aA", "aAAbbbb").Print();
    }
    public int NumJewelsInStones(string jewels, string stones)
    {
        int cnt = 0;
        Dictionary<char, int> dct = new Dictionary<char, int>();
        for (int i = 0; i < stones.Length; i++)
        {
            if (!dct.ContainsKey(stones[i]))
            {
                dct.Add(stones[i], 1);
                continue;
            }
            dct[stones[i]] += 1;
        }
        for (int i = 0; i < jewels.Length; i++)
        {
            if (dct.ContainsKey(jewels[i]))
            {
                cnt += dct[jewels[i]];
            }
        }
        return cnt;
    }
}
