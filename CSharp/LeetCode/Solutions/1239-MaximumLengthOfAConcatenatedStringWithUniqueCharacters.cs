using LeetCode.Shared;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;

namespace LeetCode.CSharp;

internal class Solution1239 : IRunProgram
{
    public void Run()
    {
        MaxLength(["fui", "lo", "yr", "i", "hxo", "rou", "q", "spu", "d", "lo", "p", "xjb", "idm", "bwj", "s", "ec"]).Print();
        MaxLength(["un", "iq", "ue"]).Print();
        MaxLength(["cha", "r", "act", "ers"]).Print();
        MaxLength(["abcdefghijklmnopqrstuvwxyz"]).Print();
    }
    public int MaxLength(IList<string> arr)
    {
        List<int> masks = GetMasks(arr);
        int max_len = 0;
        Backtrack(ref max_len, 0, masks, 0);
        return max_len;
    }

    private void Backtrack(ref int max_len, int current_mask, List<int> masks, int index) 
    {
        for (int i = index; i < masks.Count; i++)
        {
            if ((current_mask & masks[i]) == 0)
            {
                int xor = current_mask ^ masks[i]; // current_mask | masks[i]; is also possible
                max_len = Math.Max(max_len, int.PopCount(xor));
                Backtrack(ref max_len, xor, masks, i + 1);
            }
            else 
            { 
                Backtrack(ref max_len, current_mask, masks, i + 1);
            }
        }
    }

    private List<int> GetMasks(IList<string> arr) 
    {
        List<int> masks = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
            int mask = 0; bool is_unique = true;
            for (int j = 0; j < arr[i].Length; j++)
            {
                // strings dont contain unique chars, those that arent can be skipped since it can never be used
                int temp = mask ^ (1 << arr[i][j] - 'a');
                if (temp < mask)
                {
                    is_unique = false;
                    break;
                }
                mask = temp;
            }
            if (is_unique) masks.Add(mask);
        }
        return masks;
    }
}
