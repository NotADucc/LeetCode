using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1652 : IRunProgram
{
    public void Run()
    {
        
    }

    public int[] Decrypt(int[] code, int k) 
    {
        var res = new int[code.Length];
        if (k == 0) return res;
        int new_k = Math.Abs(k);
        int l = k < 0 ? code.Length + k : 1, r = l;
        for (int j = 1; j <= new_k; j++)
            res[0] += code[r++];
        for (int i = 1; i < code.Length; i++)
        {
            res[i] += res[i - 1];
            res[i] -= code[l++ % code.Length];
            res[i] += code[r++ % code.Length];
        }   

        return res;     
    }
}
